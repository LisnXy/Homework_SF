using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager;
namespace OrderWindow
{
    public partial class Form3 : Form2
    {
        public Form3(Order target)
        {           
            InitializeComponent();            
            order = target;
            textBox_Client.Text = order.Client;
            textBox_ID.Text = $"order.OrderId";
            label_TotalCost.Text = order.Cost.ToString();
            bindingSource_OrderDetial.DataSource = order.Merchandise;
        }
     
        protected override void AddOrder()
        {
            this.Close();
        }
    }
}
