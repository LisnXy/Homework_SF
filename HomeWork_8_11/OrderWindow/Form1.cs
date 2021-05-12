using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager;

namespace OrderWindow
{
    public partial class Manager : Form
    {
        OrderServices orderManager = OrderServices.getManager();
        public Manager()
        {
            InitializeComponent();
            //生成一个订单
            var order = new Order("张三");
            order.Merchandise.Add(new OrderDetial("瓜子", 2.0, 3));
            orderManager.AddOrder(order);
            dataGridView_Order.ReadOnly = true;
        }


        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            bindingSource_Order.ResetBindings(true);
        }

        //删除订单
        private void button_DelOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_Order.SelectedRows.Count != 0)
            {
                //获得选中的订单实体
                Order selectedOrder = dataGridView_Order.SelectedRows[0].DataBoundItem as Order;
                orderManager.DeleteOrder(selectedOrder);
            }
            bindingSource_Order.ResetBindings(true);
        }

      

        
        //修改订单
        private void button_ReviseOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView_Order.SelectedRows.Count != 0)
            {
                new Form3(dataGridView_Order.SelectedRows[0].DataBoundItem as Order).ShowDialog();
                bindingSource_Order.ResetBindings(false);
            }
        }

        private void button_InportOrder_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            bindingSource_Order.ResetBindings(true);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (var context = new OrderDbContext())
            {               
                DbSet<Order> orderSet = orderManager.Inport(openFileDialog.FileName);
                context.Orders.AddRange(orderSet);
            }          
        }

        private void button_ExportOrder_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            orderManager.Export(saveFileDialog.FileName);
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            switch (comboBox_Query.SelectedIndex)
            {
                case 0: { 
                        bindingSource_Order.DataSource = orderManager.QueryOrderById(Convert.ToInt32(textBox_Query.Text));
                        break;
                    }
                case 1:
                    {
                        bindingSource_Order.DataSource = orderManager.QueryOrderByCost(Convert.ToDouble(textBox_Query.Text));
                        break;
                    }
                case 2:
                    {
                        bindingSource_Order.DataSource = orderManager.QueryOrderByClient(textBox_Query.Text);
                        break;
                    }
                default:break;
            }
            bindingSource_Order.ResetBindings(true);
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            bindingSource_Order.ResetBindings(true);
        }
    }
}
