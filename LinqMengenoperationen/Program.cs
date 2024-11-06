int [] factorsOf300 = { 2 , 2 , 3 , 5 , 5 };
int [] numbersA = { 0 , 2 , 4 , 5 , 6 , 8 , 9 };
int [] numbersB = { 1 , 3 , 5 , 7 , 8 };

var distincts = factorsOf300.Distinct();

Console.WriteLine( "Distinct:" );

foreach ( int i in distincts )
    Console.Write( i + " " );

Console.WriteLine();
Console.WriteLine();

var union = numbersA.Union( numbersB );

Console.WriteLine( "Union:" );

foreach ( int i in union )
    Console.Write( i + " " );

Console.WriteLine();
Console.WriteLine();

var intersect = numbersA.Intersect( numbersB );

Console.WriteLine( "Intersect:" );

foreach ( int i in intersect )
    Console.Write( i + " " );

Console.WriteLine();
Console.WriteLine();

var except = numbersB.Except( numbersA );

Console.WriteLine( "Only occurs in B:" );

foreach ( int i in except )
    Console.Write( i + " " );

Console.ReadLine();