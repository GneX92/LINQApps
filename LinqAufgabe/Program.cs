int [] numbers = { 5 , 4 , 1 , 3 , 9 , 8 , 6 , 7 , 2 , 0 , 22 , 12 , 16 , 18 , 11 , 19 , 13 };

var kleiner7 = numbers.Where( x => x < 7 );

var gerade = numbers.Where( x => x % 2 == 0 );

var einstUngerade = numbers.Where( x => x % 2 != 0 && x < 10 );

var geradeab6 = numbers.Skip( 5 ).Where( x => x % 2 == 0 );

#region Ausgabe Augabe 1 ----------------------------------------------------------------------------

Console.WriteLine( "Nummern kleiner als 7:" );

foreach ( int i in kleiner7 )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "Gerade Zahlen:" );

foreach ( int i in gerade )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "Einstellige ungerade Zahlen:" );

foreach ( int i in einstUngerade )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "Gerade Zahlen ab 6. Index (index 5):" );

foreach ( int i in geradeab6 )
    Console.WriteLine( i );

Console.ReadLine();

Console.Clear();

#endregion Ausgabe Augabe 1 ----------------------------------------------------------------------------

string [] strings =
{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
"nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

var dreizeichen = strings.Where( x => x.Length == 3 );

var hato = strings.Where( x => x.Contains( 'o' ) );

var endonteen = strings.Where( x => x.EndsWith( "teen" ) );

var endonteenupper = strings.Where( x => x.EndsWith( "teen" ) )
                                            .Select( s => s.ToUpper() );

var containsfour = strings.Where( x => x.Contains( "four" ) );

#region Ausgabe Aufgabe 2 ----------------------------------------------------------------------------

Console.WriteLine( "Zahlen mit 3 Zeichen:" );
foreach ( string i in dreizeichen )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "Zahlen die 'o' enthalten" );
foreach ( string i in hato )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "Zahlen die auf 'teen' enden:" );
foreach ( string i in endonteen )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "Zahlen die auf 'teen' enden als Uppercase:" );
foreach ( string i in endonteenupper )
    Console.WriteLine( i );

Console.ReadLine();

Console.WriteLine( "zahlen die four enthalten:" );
foreach ( string i in containsfour )
    Console.WriteLine( i );

Console.ReadLine();

#endregion Ausgabe Aufgabe 2 ----------------------------------------------------------------------------