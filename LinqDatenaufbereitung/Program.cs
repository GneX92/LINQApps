using LinqDatenaufbereitung;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] productstring = File.ReadAllLines( @"C:\Users\ITA5-TN05\Desktop\Produkte.txt" );
List<Product> products = new();

foreach ( string line in productstring )
{
    var p = new Product();
    string [] fields = line.Split( ';' );
    p.Name = fields [ 0 ];
    fields [ 1 ] = fields [ 1 ].Replace( '.' , ',' );
    p.Price = double.Parse( fields [ 1 ] );
    p.Category = fields [ 2 ];
    products.Add( p );
    Console.WriteLine( p );
}

var avgpricepercatgeory = products.GroupBy( p => p.Category , p => p.Name );

foreach ( var product in products )

    Console.ReadLine();