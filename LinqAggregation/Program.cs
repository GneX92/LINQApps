int [] numbers = { 5 , 4 , 1 , 3 , 9 , 8 , 6 , 7 , 2 , 0 , 22 , 12 , 16 , 18 , 11 , 19 , 13 };

var sum = numbers.Sum();

var min = numbers.Min();

var max = numbers.Max();

var avg = numbers.Average();

var mingerade = numbers.Where( x => x % 2 == 0 ).Min();

var maxungerade = numbers.Where( x => x % 2 != 0 ).Max();

var sumvongerade = numbers.Where( x => x % 2 == 0 ).Sum();

var avgungerade = numbers.Where( x => x % 2 != 0 ).Average();

Console.WriteLine( "Summe: " + sum );
Console.WriteLine( "Min: " + min );
Console.WriteLine( "Max: " + max );
Console.WriteLine( $"Average: {avg:F2}" );
Console.WriteLine( "Kleinste Gerade: " + mingerade );
Console.WriteLine( "Größte Ungerade: " + maxungerade );
Console.WriteLine( "Summe von Geraden: " + sumvongerade );
Console.WriteLine( $"Average von Ungeraden: {avgungerade:F2}" );

Console.ReadLine();