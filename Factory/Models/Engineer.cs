using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        [Required(ErrorMessage = "Please enter the engineer's name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }


        public List<EngineerMachine> JoinEntities { get; }
    }
}