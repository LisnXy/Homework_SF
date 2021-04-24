using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormApp
{
    public partial class Form1 : Form
    {       
        private SimpleCrawler crawler = new SimpleCrawler();
        
        public Form1()
        {
            InitializeComponent();           
            bindingSource_Results.DataSource = crawler.results;
            bindingSource_Exception.DataSource = crawler.exceptions;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            crawler.Crawl();
            bindingSource_Results.ResetBindings(true);
            bindingSource_Exception.ResetBindings(true);
        }

        private void textBox_Target_TextChanged(object sender, EventArgs e)
        {
            crawler.target = textBox_Target.Text;
        }
    }
}
