using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceDatabase.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        //Belnges_TO
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //ORDERED_IN
        [InverseProperty("Product")]
        public List<OrderProduct> OrderProducts { get; set; }
    }
}