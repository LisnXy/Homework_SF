using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace OrderManager
{
   
    [Serializable]
    public class Order
    {
        public string Id { set; get; }
        public double Cost { set; get; }
        public string Client { set; get; }
        public List<OrderDetial> merchandise = new List<OrderDetial>();

        public Order() { }
        public Order(string Id, string Client)
        {
            this.Id = Id;
            this.Cost = 0;
            this.Client = Client;
        }

        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            if(this.Id == temp.Id)
            {
                return true;
            }
            return false;
        }
        public static void Main(){ }

        }
        [Serializable]
    public class OrderDetial
    {
        public string Name { set; get; }
        public double SingleCost { set; get; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }

        public OrderDetial() { }
        public OrderDetial(string Name, double SingleCost,int Quantity)
        {
            this.Name = Name;
            this.SingleCost = SingleCost;
            this.Quantity = Quantity;
            this.TotalCost = Quantity * SingleCost;
        }

       

    }

    public class OrderServices
    {
      
        public  List<Order> orders = new List<Order>();//创建订单List，用于存储订单
        private static OrderServices OrderManager;
        public static OrderServices getManager()
        {
            if(OrderManager == null)
            {
                OrderManager = new OrderServices();
            }
            return OrderManager;
        }
        private OrderServices() { }
        public void AddOrder(Order order)//添加订单
        {
            orders.Add(order);
        }

        public void ReviseOrder(Order oldOrder,Order newOrder)
        {
            if (orders.Contains(oldOrder))
            {
                int index = orders.IndexOf(oldOrder);
                orders.RemoveAt(index);
                orders.Insert(index,newOrder);
            }
        }
        public  void DeleteOrder(Order order)//删除订单
        {
            if (orders.Contains(order))
            {
                orders.Remove(order);
            }
        }

       

        public  void AddMerchandise(Order order,OrderDetial merchandise)
        {
            order.merchandise.Add(merchandise);
            order.Cost += merchandise.TotalCost;
        }
        public void DelMerchandise(Order order,OrderDetial merchandise)
        {
            if (order.merchandise.Contains(merchandise))
            {
                order.merchandise.Remove(merchandise);
                order.Cost -= merchandise.TotalCost;
            }
        }
        //查找订单
        public IEnumerable<Order> QueryOrderById(string id)
        {
            var target = from s in orders where s.Id == id select s;
            return target;
        }

        public  IEnumerable<Order> QueryOrderByClient(string client)
        {
            var target = from s in orders where s.Client == client select s;           
            return target;
        }

        public IEnumerable<Order> QueryOrderByCost(double cost)
        {
            var target = from s in orders where s.Cost == cost select s;            
            return target;
        }

        public  void ShowAllOrders()
        {
            foreach(Order order in orders)
            {
                Console.WriteLine(order.Id);
            }
        }
        //将目前所有的订单序列化为XML文件
        public  void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create,FileAccess.ReadWrite))
            {
                xmlSerializer.Serialize(fs, orders);              
            }
        }

        public  List<Order> Inport(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fout = new FileStream(path, FileMode.Open))
            {
                List<Order> orders_xml = (List<Order>)xmlSerializer.Deserialize(fout);
                return orders_xml;
            }
        }
    }
}

