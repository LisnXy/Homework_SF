using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
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
            this.Merchandise = new List<OrderDetial>();
        }
        public Order(string Client)
        {
            IdCounter += 1;
            this.OrderId = IdCounter;
            this.Cost = 0;
            this.Client = Client;
            this.Merchandise = new List<OrderDetial>();
        }

        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            if (this.OrderId == temp.OrderId)
            {
                return true;
            }
            return false;
        }
    }
}