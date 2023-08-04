using System.Collections.Generic;

namespace Factory.Models;
{
  public int MachineId { get; set; }
public string Name { get; set; }
public string Description { get; set; }
public List<Engineer> Engineers { get; set; }
}