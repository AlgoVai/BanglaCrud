using System.ComponentModel.DataAnnotations;

namespace banglaCrud.Models
{
    public class House
    {

        [Key]
        public int houseId { get; set; }
        public string HouseName { get; set; }
        public int price { get; set; }
        public int sqFeet { get; set; }
    }
}
