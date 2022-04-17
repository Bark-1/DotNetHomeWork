﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    public class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
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
            urls.Add(startUrl, false);//加入初始页面

        }
        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
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
                if (new Regex(@"[?]").IsMatch(strRef))
                {
                    strRef = new Regex(@"[^?]+").Match(strRef).Value;
                }
                if (!(strRef.EndsWith(".html") || strRef.EndsWith(".aspx") || strRef.EndsWith(".htm") || strRef.EndsWith(".jsp") || strRef.EndsWith("/"))) continue;

                if ((urls[strRef] == null))
                {
                    urls[strRef] = false; 
                }
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
