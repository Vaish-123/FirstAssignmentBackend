using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAssignment.Models
{
    public class Product
    {
        [Key]
        public int ProdKey { get; set; }
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Pprice { get; set; }
        public int Pquantity { get; set; }
        public int Pamount { get; set; }

    }
}
