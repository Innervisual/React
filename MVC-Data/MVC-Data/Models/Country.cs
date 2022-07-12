using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class Country
    {
        [Key]
        public string Name { get; set; }
        public int Id { get; set; }
        //[Required]  
        public List<City> Cities { get; set; }
    }
}
