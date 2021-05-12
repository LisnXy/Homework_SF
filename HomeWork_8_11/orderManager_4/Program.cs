using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using OrderManager;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManager
{
   
    [Serializable]
    public class Order
    {
        public static int IdCounter = 0;
        [Key]
        public int OrderId { set; get; }
        public double Cost { set; get; }
        public string Client { set; get; }
        public List<OrderDetial> Merchandise { set; get; }

        public Order()
        {
            IdCounter += 1;
            this.OrderId = IdCounter;
            this.Cost = 0;
            this.Client = "unknown";
        }
        public Order(string Client)
        {
            IdCounter += 1;
            this.OrderId = IdCounter;
            this.Cost = 0;
            this.Client = Client;
        }

        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            if(this.OrderId == temp.OrderId)
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
        public static int IdCounter = 0;
        [Key]
        public int DetialId { set; get; }
        public string Name { set; get; }
        public double SingleCost { set; get; }
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        public virtual Order Order { set; get; }
        
        public OrderDetial(string Name, double SingleCost,int Quantity)
        {
            IdCounter += 1;
            this.DetialId = IdCounter;
            this.Name = Name;
            this.SingleCost = SingleCost;
            this.Quantity = Quantity;
            this.TotalCost = Quantity * SingleCost;
        }

       

    }

    public class OrderServices
    {
      
        
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
            if (order != null)
            {
                using (var orderDb = new OrderDbContext())
                {
                    orderDb.Orders.Add(order);
                    orderDb.SaveChanges();
                }
            }
        }

        public void ReviseOrder(Order oldOrder,Order newOrder)//修改订单
        {
            using (var context = new OrderDbContext())
            {
                if(oldOrder != null || newOrder != null)
                {
                    context.Entry(oldOrder).State = System.Data.Entity.EntityState.Modified;
                    var order = context.Entry(oldOrder).Entity;
                    order.Client = newOrder.Client;
                    order.Cost = newOrder.Cost;
                    order.Merchandise = newOrder.Merchandise;
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

       

        public  void AddMerchandise(Order order,OrderDetial merchandise)//添加商品明细
        {
            if (merchandise != null)
            {
                using (var context = new OrderDbContext())
                {
                    //获取对应的实体
                    var target = context.Entry(order).Entity;
                    //为对应的Order添加明细
                    target.Merchandise.Add(merchandise);
                    context.SaveChanges();
                }
            }
        }
        public void DelMerchandise(Order order,OrderDetial merchandise)
        {
            if (merchandise != null)
            {
                using (var context = new OrderDbContext())
                {
                    //获取对应的实体
                    var target = context.Entry(order).Entity;
                    if (target.Merchandise.Contains(merchandise))
                    {
                        target.Merchandise.Remove(merchandise);
                        context.SaveChanges();
                    }
                }
            }
        }
        //查找订单
        public IEnumerable<Order> QueryOrderById(int id)
        {
             using(var context = new OrderDbContext()){
                var query = context.Orders.Where(order => order.OrderId == id);
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

