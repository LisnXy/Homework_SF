using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using OrderManager;
using System.Data.Entity;

namespace OrderManager
{
   
    [Serializable]
    public class Order
    {
        public string Id { set; get; }
        public double Cost { set; get; }
        public string Client { set; get; }
        public virtual List<OrderDetial> merchandise { set; get; }

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

        public virtual Order order { set; get; }

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
      
        //public  List<Order> orders = new List<Order>();//创建订单List，用于存储订单
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
            using(var orderDb = new OrderDbContext())
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
        }

        public void ReviseOrder(Order oldOrder,Order newOrder)
        {
            using (var context = new OrderDbContext())
            {
                if(oldOrder != null || newOrder != null)
                {
                    context.Entry(oldOrder).State = System.Data.Entity.EntityState.Modified;
                    var order = context.Entry(oldOrder).Entity;
                    order.Client = newOrder.Client;
                    order.Cost = newOrder.Cost;
                    order.merchandise = newOrder.merchandise;
                }
            }
        }
        public  void DeleteOrder(Order order)//删除订单
        {
            using(var context = new OrderDbContext())
            {
                if(order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
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
             using(var context = new OrderDbContext()){
                var query = context.Orders.Where(order => order.Id == id);
                return query;
            }
        }

        public  IEnumerable<Order> QueryOrderByClient(string client)
        {
            using (var context = new OrderDbContext())
            {
                var query = context.Orders.Where(order => order.Client == client);
                return query;
            }
        }

        public IEnumerable<Order> QueryOrderByCost(double cost)
        {
            using (var context = new OrderDbContext())
            {
                var query = context.Orders.Where(order => order.Cost == cost);
                return query;
            }
        }


        //将目前所有的订单序列化为XML文件
        public  void Export(string path)
        {
            using (var context = new OrderDbContext())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DbSet<Order>));
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    xmlSerializer.Serialize(fs, context.Orders);
                }
            }
        }

        public  DbSet<Order> Inport(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DbSet<Order>));
            using(FileStream fout = new FileStream(path, FileMode.Open))
            {
                var orders_xml = (DbSet<Order>)xmlSerializer.Deserialize(fout);
                return orders_xml;
            }
        }
    }
}

