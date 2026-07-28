using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceDatabase.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        //can_place
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        //contain
        [InverseProperty("Order")]
        public List<OrderProduct> OrderProducts { get; set; }

        //Has_R
        [InverseProperty("Order")]
        public Review Review { get; set; }
    }
}
