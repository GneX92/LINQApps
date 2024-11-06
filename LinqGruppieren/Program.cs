using System.Diagnostics;

Process [] processes = Process.GetProcesses();

string [] numbers =
{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
"nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

var firstletter = numbers.GroupBy( x => x [ 0 ] );

foreach ( var gruppe in firstletter )
{
    Console.WriteLine( $"'{gruppe.Key}':" );
    foreach ( var wort in gruppe )
    {
        Console.WriteLine( $"{wort}" );
    }

    Console.WriteLine();
}

Console.ReadLine();
Console.Clear();

var length = numbers.GroupBy( x => x.Length );

foreach ( var gruppe in length )
{
    Console.WriteLine( $"'{gruppe.Key}':" );
    foreach ( var wort in gruppe )
    {
        Console.WriteLine( $"{wort}" );
    }

    Console.WriteLine();
}

Console.ReadLine();
Console.Clear();

var lengthandfirst = numbers.GroupBy( w => new { FirstLetter = w [ 0 ] , Length = w.Length } );

foreach ( var gruppe in lengthandfirst )
{
    Console.WriteLine( $"'{gruppe.Key.FirstLetter}' & '{gruppe.Key.Length}':" );
    foreach ( var wort in gruppe )
    {
        Console.WriteLine( $"{wort}" );
    }

    Console.WriteLine();
}

Console.ReadLine();
Console.Clear();

var processesbythreads = processes.GroupBy( p => p.Threads.Count , p => p.ProcessName );

foreach ( var gruppe in processesbythreads )
{
    Console.WriteLine( $"{gruppe.Key} Threads:" );
    foreach ( var process in gruppe )
    {
        Console.WriteLine( $"{process}" );
    }

    Console.WriteLine();
}

Console.ReadLine();
Console.Clear();

var processesbymodules = processes.GroupBy( p => GetModuleCount( p ) , p => p.ProcessName );

foreach ( var gruppe in processesbymodules )
{
    Console.WriteLine( $"'{gruppe.Key} Modules':" );
    foreach ( var process in gruppe )
    {
        Console.WriteLine( $"{process}" );
    }

    Console.WriteLine();
}

Console.ReadLine();
Console.Clear();

var processesbymodulesalphabetically = processes.OrderBy( p => p.ProcessName ).GroupBy( p => GetModuleCount( p ) , p => p.ProcessName );

foreach ( var gruppe in processesbymodulesalphabetically )
{
    Console.WriteLine( $"'{gruppe.Key} Modules':" );
    foreach ( var process in gruppe )
    {
        Console.WriteLine( $"{process}" );
    }

    Console.WriteLine();
}

Console.ReadLine();
Console.Clear();

static int? GetModuleCount( Process process )
{
    try
    {
        return process.Modules.Count;
    }
    catch
    {
        return -1;
    }
}