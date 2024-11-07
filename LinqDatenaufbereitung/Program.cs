using LinqDatenaufbereitung;
using Spectre.Console;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] productstring = File.ReadAllLines( @"C:\Users\ITA5-TN05\Desktop\Produkte.txt" );
List<Product> products = new();

Table table = new Table();
table.AddColumn( new TableColumn( "Product" ).LeftAligned() );
table.AddColumn( new TableColumn( "Price" ).RightAligned() );
table.AddColumn( new TableColumn( "Category" ).Centered() );
table.Border( TableBorder.Rounded );
table.BorderColor( Color.Yellow );

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

foreach ( Product p in products )
    table.AddRow( p.Name.ToString() , p.Price.ToString( "C" ) , p.Category.ToString() );

AnsiConsole.Write( table );

//foreach ( Product product in products )
//    Console.WriteLine( product );

var avgpricepercatgeory =
    products.GroupBy( p => p.Category )
            .Select( g => new { Category = g.Key , AvgPrice = g.Average( p => p.Price ) } );

Console.WriteLine();

var grid = new Grid();
grid.AddColumn();
grid.AddColumn();
grid.AddColumn();
grid.AddColumn();

foreach ( var p in avgpricepercatgeory )
    grid.AddRow( new Text []{
    new Text("Category: ", new Style(Color.Orange1 )).LeftJustified(),
    new Text(p.Category , new Style(Color.White )).LeftJustified(),
    new Text("Average Price: ", new Style(Color.Orange1 )).LeftJustified(),
    new Text(p.AvgPrice.ToString("C"), new Style(Color.White )).RightJustified()
 } );

AnsiConsole.Write( grid );

//foreach ( var group in avgpricepercatgeory )
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write( $"Category: " );
//    Console.ResetColor();
//    Console.Write( $"{group.Category} " );
//    Console.ForegroundColor = ConsoleColor.DarkYellow;
//    Console.Write( $"Average Price: " );
//    Console.ResetColor();
//    Console.Write( $"{group.AvgPrice:C}\n" );
//}

Console.ReadLine();