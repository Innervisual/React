using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class Language
    {
        [Key]
        public string Name { get; set; }  
        public int Id { get; set; }
        
        //[Required]  
        //public List<Person> People = new List<Person>();

        public List<PersonLanguage> PersonLanguages { get; set; }

    }
}
