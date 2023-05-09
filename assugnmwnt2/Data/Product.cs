using System.ComponentModel.DataAnnotations;

namespace assugnmwnt2.Data
{
    public class Product
    {
        [Key]
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_description { get; set;}
    }
}
