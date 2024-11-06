int [] numbers = { 5 , 4 , 1 , 3 , 9 , 8 , 6 , 7 , 2 , 0 , 22 , 12 , 16 , 18 , 11 , 19 , 13 };

var asc = numbers.OrderBy( x => x );
var desc = numbers.OrderByDescending( x => x );

var ascgerade = numbers.Where( x => x % 2 == 0 ).OrderBy( x => x );

#region Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.WriteLine( "Aufsteigend:" );
foreach ( var i in asc )
    Console.WriteLine( i );

Console.WriteLine( "\nAbsteigend:" );
foreach ( var i in desc )
    Console.WriteLine( i );

Console.WriteLine( "\nGerade Aufsteigend:" );

foreach ( var i in ascgerade )
    Console.WriteLine( i );

#endregion Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.ReadLine();
Console.Clear();

string [] strings =
{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
"nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

var wortlängeasc = strings.OrderBy( x => x.Length );

var längeundalpha = strings.OrderBy( x => x.Length ).ThenByDescending( x => x );

var reversed = strings.Reverse();

#region Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.WriteLine( "Aufsteigend nach Wortlänge:" );
foreach ( var i in wortlängeasc )
    Console.WriteLine( i );

Console.WriteLine( "\nAufsteigend nach Länge & Absteigend Alphabethisch:" );
foreach ( var i in längeundalpha )
    Console.WriteLine( i );

Console.WriteLine( "\nReversed:" );
foreach ( var i in reversed )
    Console.WriteLine( i );

#endregion Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.ReadLine();
Console.Clear();

DirectoryInfo dir = new( @"C:\Windows" );

var filesdesc = dir.GetFiles().OrderByDescending( x => x.Name );

var filesbysize = dir.GetFiles().OrderBy( x => x.Length );

var filesbytime = dir.GetFiles().OrderBy( x => x.LastAccessTime );

#region Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.WriteLine( "Files Absteigend:" );
foreach ( var i in filesdesc )
    Console.WriteLine( i.Name.ToString() );

Console.WriteLine( "\nFiles nach Größe Aufsteigend:" );
foreach ( var i in filesbysize )
    Console.WriteLine( $"{i.Length,7} Bytes" );

Console.WriteLine( "\nFiles nach letztem Zugriff aufsteigend:" );
foreach ( var i in filesbytime )
    Console.WriteLine( $"{i.LastAccessTime}" );

#endregion Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.ReadLine();
Console.Clear();

var first5 = numbers.Take( 5 );
var last5 = numbers.TakeLast( 5 );

var allbutfirst3andlast3 = numbers.Skip( 3 ).SkipLast( 3 );

var allfromfirstgreater0 = numbers.SkipWhile( i => i <= 0 );

var allafter12 = numbers.SkipWhile( i => i != 12 );

var files5newest = dir.GetFiles().OrderByDescending( x => x.CreationTime ).Take( 5 );

var files5newestsql = ( from x in dir.GetFiles()
                        orderby x.CreationTime descending
                        select x ).Take( 5 );

var test = files5newestsql.Take( 5 );

var filesaspages = dir.GetFiles().Chunk( 5 );

#region Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.WriteLine( "First 5:" );
foreach ( var i in first5 )
    Console.WriteLine( i );

Console.WriteLine( "\nLast 5:" );
foreach ( var i in last5 )
    Console.WriteLine( i );

Console.WriteLine( "\nAll except first and last 3:" );
foreach ( var i in allbutfirst3andlast3 )
    Console.WriteLine( i );

Console.WriteLine( "\nAll starting from first that is greater 0:" );
foreach ( var i in allfromfirstgreater0 )
    Console.WriteLine( i );

Console.WriteLine( "\nAll from first that equals 12:" );
foreach ( var i in allafter12 )
    Console.WriteLine( i );

Console.WriteLine( "\n5 newest files:" );
foreach ( var i in files5newest )
    Console.WriteLine( i.CreationTime );

#endregion Ausgabe ----------------------------------------------------------------------------------------------------------------------

Console.ReadLine();
Console.Clear();

Console.WriteLine( "Files as Pages of 5:" );

int pagecount = 1;
foreach ( var arr in filesaspages )
{
    Console.WriteLine();
    Console.WriteLine( "Page" + pagecount );
    foreach ( var i in arr )
        Console.WriteLine( i );

    pagecount++;
}

Console.ReadLine();
Console.Clear();