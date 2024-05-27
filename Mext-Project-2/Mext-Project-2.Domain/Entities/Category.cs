using System;
using Mext_Project_2.Domain.Comman;

namespace Mext_Project_2.Domain.Entities
{
  public class Category:EntityBase
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Product> Products { get; set; }

  }
}

