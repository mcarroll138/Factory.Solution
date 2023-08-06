using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Please enter the name of machine")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter a machine description")]
    public string Description { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}

