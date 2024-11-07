using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin;

public class Bestellung
{
    public List<Entry> AllePositionen { get; set; }

    public override string ToString()
    {
        string result = string.Empty;

        foreach ( var item in AllePositionen )
            result += item.ToString() + "\n";

        return result;
    }
}