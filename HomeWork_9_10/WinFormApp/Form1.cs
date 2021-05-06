using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Stopwatch sw = new Stopwatch();           
            Thread thread1 = new Thread(() => {
                sw.Start();
                crawler.Crawl();
                if (this.InvokeRequired)
                {
                 Action<bool> action = bindingSource_Results.ResetBindings;
                    action += bindingSource_Exception.ResetBindings;
                    this.Invoke(action, true);
                    Console.WriteLine(sw.ElapsedMilliseconds);
                }                
                sw.Stop();
            });
            thread1.Start();            
        }

        

        private void textBox_Target_TextChanged(object sender, EventArgs e)
        {
            crawler.target = textBox_Target.Text;
        }
    }
}
