using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsForms1
{
    public partial class FormResult : Form
    {
        public FormResult(string startURL)
        {
            InitializeComponent();
            SimpleCrawler.SimpleCrawler myCrawler = new SimpleCrawler.SimpleCrawler(startURL);
            myCrawler.ResultSuccessChange += On_ResultSuccessChange;
            myCrawler.ResultFailureChange += On_ResultFailureChange;
            new Thread(myCrawler.Crawl).Start();
            
            
        }
        private void On_ResultSuccessChange(object sender, SimpleCrawler.TextEventArgs e)
        {
            this.textBoxSuccess.Text = e.Text;
        }
        private void On_ResultFailureChange(object sender, SimpleCrawler.TextEventArgs e)
        {
            this.textBoxFail.Text = e.Text;
        }
    }
}
