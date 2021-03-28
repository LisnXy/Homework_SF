using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order_1 = new Order("477523", "Lisn");
            OrderServices.AddMerchandise(order_1, new OrderDetial("Mac", 7299));
            OrderServices.AddMerchandise(order_1, new OrderDetial("Apple Watch", 3199));
            OrderServices.AddOrder(order_1);

            Order order_2 = new Order("213244", "Jack");
            OrderServices.AddMerchandise(order_2, new OrderDetial("Mate P40", 6199));
            OrderServices.AddOrder(order_2);
           
            Order temp = OrderServices.QueryOrderByClient("Lisn");
            Console.WriteLine(temp.ToString());
            OrderServices.ShowDetials(temp);

            temp = OrderServices.QueryOrderById("213244");
            Console.WriteLine();
            Console.WriteLine(temp.ToString());
            OrderServices.ShowDetials(temp);
        }
    }

    public class Order
    {
        public string Id { set; get; }
        public double Cost { set; get; }
        public string Client { set; get; }
        public List<OrderDetial> merchandise = new List<OrderDetial>();

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

        public override string ToString()
        {
            return new string("ID:" + this.Id + "\n" + "Cost:" + this.Cost + "\n" + "Client:" + this.Client);
        }
    }

    public class OrderDetial
    {
        public string Name { set; get; }
        public double Cost { set; get; }

        public OrderDetial(string Name, double Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }

        public override string ToString()
        {
            return new string(this.Name + "  " + this.Cost);
        }
    }

    public class OrderServices
    {
        public static List<Order> orders = new List<Order>();//创建订单List，用于存储订单
        public static void AddOrder(Order order)//添加订单
        {
            orders.Add(order);
        }

        public static void DeleteOrder(Order order)//删除订单
        {
            foreach (Order temp in orders)
            {
                if (temp == order){
                    orders.Remove(temp);
                    Console.WriteLine("成功删除订单");
                    return;
                }
                Console.WriteLine("未找到需要删除的订单");
            }
        }

        public static void ShowDetials(Order order)//显示订单细节
        {
            foreach(OrderDetial detial in order.merchandise)
            {
                Console.WriteLine(detial.ToString());
            }
        }

        public static void AddMerchandise(Order order,OrderDetial merchandise)
        {
            order.merchandise.Add(merchandise);
            order.Cost += merchandise.Cost;
        }

        //查找订单
        public static Order QueryOrderById(string id)
        {
            var target = from s in orders where s.Id == id select s;
            Order order = target.FirstOrDefault();
            return order;
        }

        public static Order QueryOrderByClient(string client)
        {
            var target = from s in orders where s.Client == client select s;
            Order order = target.FirstOrDefault();
            return order;
        }

        public static Order QueryOrderByCost(double cost)
        {
            var target = from s in orders where s.Cost == cost select s;
            Order order = target.FirstOrDefault();
            return order;
        }

        public static void ShowAllOrders()
        {
            foreach(Order order in orders)
            {
                Console.WriteLine(order.Id);
            }
        }
    }
}

