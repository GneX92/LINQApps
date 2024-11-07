using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin;

public class Entry
{
    public int Id { get; set; }
    public int Artikelnummer { get; set; }
    public int Anzahl { get; set; }

    public override string ToString()
    {
        return $"{Id,1} {Artikelnummer} {Anzahl,4}";
    }
}