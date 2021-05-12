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
    public partial class Form2 : Form
    {
        protected OrderServices orderManager = OrderServices.getManager();
        protected Order order;
        public Form2()
        {
            InitializeComponent();
            if(order == null)
            {
                order = new Order();
            }
            dataGridView_Detials.ReadOnly = true;
            bindingSource_OrderDetial.DataSource = order.Merchandise;            
        }
       

        protected void numericUpDown_SingleCost_ValueChanged(object sender, EventArgs e)
        {
            label_Detial_TotalCostNumber.Text = (numericUpDown_SingleCost.Value * numericUpDown_Quantity.Value).ToString();
        }

        protected void numericUpDown_Quantity_ValueChanged(object sender, EventArgs e)
        {
            label_Detial_TotalCostNumber.Text = (numericUpDown_SingleCost.Value * numericUpDown_Quantity.Value).ToString();
        }

        protected void button_AddDetial_Click(object sender, EventArgs e)
        {
            orderManager.AddMerchandise(order, new OrderDetial(textBox_Detial_Name.Text, (double)numericUpDown_SingleCost.Value, (int)numericUpDown_Quantity.Value));
            bindingSource_OrderDetial.ResetBindings(true);
            label_TotalCost.Text = order.Cost.ToString();
        }

        protected void button_DelDetial_Click(object sender, EventArgs e)
        {
            if (dataGridView_Detials.SelectedRows.Count != 0)
            {
                OrderDetial delTarget = dataGridView_Detials.SelectedRows[0].DataBoundItem as OrderDetial;
                orderManager.DelMerchandise(order, delTarget);
            }
            bindingSource_OrderDetial.ResetBindings(true);
            label_TotalCost.Text = order.Cost.ToString();
        }

        protected void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            order.OrderId = Convert.ToInt32(textBox_ID.Text);
        }

        protected void textBox_Client_TextChanged(object sender, EventArgs e)
        {
            order.Client = textBox_Client.Text;
        }

        protected void dataGridView_Detials_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        protected virtual void AddOrder()
        {
            orderManager.AddOrder(order);
            this.Close();
        }
    }
}
