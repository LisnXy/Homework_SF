using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
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

        public OrderDetial(string Name, double SingleCost, int Quantity)
        {
            IdCounter += 1;
            this.DetialId = IdCounter;
            this.Name = Name;
            this.SingleCost = SingleCost;
            this.Quantity = Quantity;
            this.TotalCost = Quantity * SingleCost;
        }
    }
}