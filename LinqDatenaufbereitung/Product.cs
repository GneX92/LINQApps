using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDatenaufbereitung;

internal class Product
{
    public string? Name { get; set; }

    public double Price { get; set; }

    public string? Category { get; set; }

    public override string ToString() => $"{Name} , {Price:C} , {Category}";
}