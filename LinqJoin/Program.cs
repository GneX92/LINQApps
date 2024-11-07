using System.Text.Json;
using LinqJoin;
using Spectre.Console;
using Spectre.Console.Json;

// Desktop-Path: C:\Users\ITA5-TN05\Desktop
Console.OutputEncoding = System.Text.Encoding.UTF8;

var options = new JsonSerializerOptions()
{
    WriteIndented = true ,
    PropertyNameCaseInsensitive = true ,
};

string artikeljson = File.ReadAllText( @"C:\Users\ITA5-TN05\Desktop\alleArtikel.json" );
string bestellungenjson = File.ReadAllText( @"C:\Users\ITA5-TN05\Desktop\bestellung.json" );

List<Artikel> products = JsonSerializer.Deserialize<List<Artikel>>( artikeljson , options );

Bestellung order = JsonSerializer.Deserialize<Bestellung>( bestellungenjson , options );

var result =
    order.AllePositionen?
    .Join( products , entry => entry.Artikelnummer ,
          artikel => artikel.Artikelnummer , ( en1 , ar1 ) =>
           new
           {
               Nr = ar1.Artikelnummer ,
               ar1.Name ,
               en1.Anzahl ,
               Summe = en1.Anzahl * ar1.Preis
           } )
    .OrderBy( x => x.Nr );

//foreach ( var item in result )
//    Console.WriteLine( item );

var table = new Table();
table.AddColumn( "Nr" );
table.AddColumn( "Name" );
table.AddColumn( new TableColumn( "Anzahl" ) );
table.AddColumn( new TableColumn( "Summe" ).Footer( result.Sum( x => x.Summe ).ToString( "C" ) ) );

table.Border( TableBorder.Rounded );
table.BorderColor( Color.Yellow );

foreach ( var item in result )
{
    table.AddRow( item.Nr.ToString() , item.Name.ToString() , item.Anzahl.ToString() , item.Summe.ToString( "C" ) );
}

AnsiConsole.Write( table );
//var panel = new Panel( "Gesamtpreis: " + result.Sum( x => x.Summe ).ToString( "C" ) );
//AnsiConsole.Write( panel );
//Console.WriteLine( "Gesamtpreis: " + result.Sum( x => x.Summe ).ToString( "C" ) );

Console.ReadLine();