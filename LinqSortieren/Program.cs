int [] numbers = { 5 , 4 , 1 , 3 , 9 , 8 , 6 , 7 , 2 , 0 , 22 , 12 , 16 , 18 , 11 , 19 , 13 };var asc = numbers.OrderBy( x => x );
var desc = numbers.OrderByDescending( x => x );

var ascgerade = numbers.Where( x => x % 2 == 0 ).OrderBy( x => x );

Console.WriteLine( "Aufsteigend:" );
foreach ( var i in asc )
    Console.WriteLine( i );

Console.WriteLine( "\nAbsteigend:" );
foreach ( var i in desc )
    Console.WriteLine( i );

Console.WriteLine( "\nGerade Aufsteigend:" );

foreach ( var i in ascgerade )
    Console.WriteLine( i );

Console.ReadLine();
Console.Clear();

string [] strings =
{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
"nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

var wortlängeasc = strings.OrderBy( x => x.Length );

var längeundalpha = strings.OrderBy( x => x.Length ).ThenByDescending( x => x );

var reversed = strings.Reverse();

Console.WriteLine( "Aufsteigend nach Wortlänge:" );
foreach ( var i in wortlängeasc )
    Console.WriteLine( i );

Console.WriteLine( "\nAufsteigend nach Länge & Absteigend Alphabethisch:" );
foreach ( var i in längeundalpha )
    Console.WriteLine( i );

Console.WriteLine( "\nReversed:" );
foreach ( var i in reversed )
    Console.WriteLine( i );

Console.ReadLine();
Console.Clear();

DirectoryInfo dir = new( @"C:\Windows" );

var filesdesc = dir.GetFiles().OrderByDescending( x => x.Name );

var filesbysize = dir.GetFiles().OrderBy( x => x.Length );

var filesbytime = dir.GetFiles().OrderBy( x => x.LastAccessTime );

Console.WriteLine( "Files Absteigend:" );
foreach ( var i in filesdesc )
    Console.WriteLine( i.Name.ToString() );

Console.WriteLine( "\nFiles nach Größe Aufsteigend:" );
foreach ( var i in filesbysize )
    Console.WriteLine( $"\t{i.Length} Bytes" );

Console.WriteLine( "\nFiles nach letztem Zugriff aufsteigend:" );
foreach ( var i in filesbytime )
    Console.WriteLine( $"{i.LastAccessTime,-30}" );

Console.ReadLine();
Console.Clear();

var first5 = numbers.Take( 5 );
var last5 = numbers.TakeLast( 5 );

var allbutfirst3andlast3 = numbers.Skip( 3 ).SkipLast( 3 );

var allfromfirstgreater0 = numbers.Where( i => i > 0 );

var allafter12 =