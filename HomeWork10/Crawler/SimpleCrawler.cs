using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace SimpleCrawler
{
    public class SimpleCrawler
    {
        //private ConcurrentDictionary<string, bool> url = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> urls = new ConcurrentQueue<string>();

        private int count = 1;
        private string StartUrl{ set; get; }
        public string ResultSuccess { set; get; } 
        public event EventHandler<TextEventArgs> ResultSuccessChange;
        public string ResultFailure { set; get; }
        public event EventHandler<TextEventArgs> ResultFailureChange;

        static void Main(string[] args)
        {
            string startUrl = "http://www.cnblogs.com";

            if (args.Length >= 1) startUrl = args[0];
            SimpleCrawler myCrawler = new SimpleCrawler(startUrl);
            new Thread(myCrawler.Crawl).Start();
        }

        public SimpleCrawler(string startUrl)
        {
            StartUrl = startUrl;
            urls.Enqueue(startUrl);//加入初始页面

        }
        public void Crawl()
        {
            List<Task> list = new List<Task>();
            while (true)
            {
                if (count > 50) break;
                string current = null;
                //task全部结束且urls为空，才停止
                if (urls.IsEmpty)
                {
                    Task.WaitAll(list.ToArray());
                }
                if (urls.IsEmpty) break;
                if (!urls.TryDequeue(out current)) continue;

                count++;
                list.Add(Task.Run(() =>
                {
                    string html = DownLoad(current);
                    Parse(html);//解析,并加入新的链接
                }));
            }
            Task.WaitAll(list.ToArray());
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                ResultSuccess += url + "\r\n";
                ResultSuccessChange(this, new TextEventArgs(ResultSuccess));
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ResultFailure += url + "\r\n" + ex.Message + "\r\n";
                ResultFailureChange(this, new TextEventArgs(ResultFailure));
                return "";
            }
        }

        private void Parse(string html)
        {
            if (html == "") return;
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //相对地址变绝对地址
                Uri baseUri = new Uri(StartUrl);
                Uri abUri = new Uri(baseUri, strRef);
                strRef = abUri.ToString();
                //只爬指定地址的
                if (!new Regex(StartUrl).IsMatch(strRef)) continue;
                //只爬网页
                string file = abUri.LocalPath;
                if (!(file.EndsWith(".html") || file.EndsWith(".aspx") || file.EndsWith(".htm") || file.EndsWith(".jsp") || file.EndsWith("/"))) continue;

                urls.Enqueue(strRef);
                
            }
        }
    }
    public class TextEventArgs : EventArgs
    {
        public string Text { set; get; }
        //事件参数
        public TextEventArgs(string text)
        {
            this.Text = text;
        }
    }
}
