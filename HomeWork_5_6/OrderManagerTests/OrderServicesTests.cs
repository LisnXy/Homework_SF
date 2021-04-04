using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Tests
{
    [TestClass()]
    public class OrderServicesTests
    {
        public Order testOrder = new Order("1135", "Lin");
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderServices.AddOrder(testOrder);
            Assert.IsTrue(OrderServices.orders.Contains(testOrder));
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderServices.DeleteOrder(testOrder);
            Assert.IsFalse(OrderServices.orders.Contains(testOrder));
        }

        [TestMethod()]
        public void ShowDetialsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddMerchandiseTest()
        {
            OrderDetial testDetial = new OrderDetial("banana", 5.6);
            OrderServices.AddMerchandise(testOrder, testDetial);
            Assert.IsTrue(testOrder.merchandise.Contains(testDetial));
        }

        [TestMethod()]
        public void QueryOrderByIdTest()
        {
            Order order = OrderServices.QueryOrderById("1135");
            Assert.AreEqual(testOrder, order);
        }

        [TestMethod()]
        public void QueryOrderByClientTest()
        {
            OrderServices.AddOrder(testOrder);
            Order order = OrderServices.QueryOrderByClient("Lin");
            Assert.AreEqual(testOrder, order);
        }

        [TestMethod()]
        public void QueryOrderByCostTest()
        {
            OrderServices.AddOrder(testOrder);
            OrderDetial testDetial = new OrderDetial("banana", 5.6);
            OrderServices.AddMerchandise(testOrder, testDetial);
            Order order = OrderServices.QueryOrderByCost(5.6);
            Assert.AreEqual(testOrder, order);
        }

        [TestMethod()]
        public void ShowAllOrdersTest()
        { 
            Assert.Fail();
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderServices.Export();
            Assert.IsTrue(File.Exists(@"order.xml"));
        }

        [TestMethod()]
        public void InportTest()
        {
            List<Order> list = OrderServices.Inport();
            Assert.AreEqual(list, OrderServices.orders);
        }
    }
}