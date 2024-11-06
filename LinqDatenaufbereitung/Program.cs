using LinqDatenaufbereitung;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] productstring = File.ReadAllLines( @"C:\Users\julia\Desktop\Produkte.txt" );
List<Product> products = new();

foreach ( string line in productstring )
{
    var p = new Product();
    string [] fields = line.Split( ';' );
    p.Name = fields [ 0 ];
    fields [ 1 ] = fields [ 1 ].Replace( '.' , ',' );
    p.Price = double.Parse( fields [ 1 ] );
    p.Category = fields [ 2 ].Trim();
    products.Add( p );
}

foreach ( Product product in products )
    Console.WriteLine( product );

var avgpricepercatgeory =
    products.GroupBy( p => p.Category )
            .Select( g => new { Category = g.Key , AvgPrice = g.Average( p => p.Price ) } );

Console.WriteLine(  );

foreach ( var group in avgpricepercatgeory )
    Console.WriteLine( $"Category: {group.Category} Average Price: {group.AvgPrice:C}" );

Console.ReadLine();