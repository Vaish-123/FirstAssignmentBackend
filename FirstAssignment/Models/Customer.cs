using System.ComponentModel.DataAnnotations;

namespace FirstAssignment.Models
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Caddress { get; set; }
    }
}
