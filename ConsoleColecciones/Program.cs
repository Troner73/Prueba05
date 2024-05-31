// See https://aka.ms/new-console-template for more information

using ConsoleColecciones;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");



{

}
int[] arrayInts = [5,6,7,2,19,100];

var consulta = 
    from entero in arrayInts.Distinct()
    where (entero % 2 == 0 && entero > 4)
    orderby entero descending
    select entero;

arrayInts.Append(8);

foreach (var item in consulta)
{
    Console.WriteLine();
}

List<Tablon> Balsa =

[
    new Tablon() { dureza = 8, madera = "pino" },
    new Tablon() { dureza = 7, madera = "caoba" },
    new Tablon() { dureza = 23, madera = "caoba" }
];

var consulta2 =

    from item in Balsa
    where (item.dureza > 2)
    orderby (item.madera)
    select (item.madera);


var consulta3 = Balsa.
    Where(x => x.dureza > 2).
    OrderBy(x => x.madera).
               Select(x => x.madera);



int[] arrayDeEnteros = [1, 4, 5, 6, 1, 2, 6, 7];

var consulta4 =
    from entero in arrayDeEnteros
    where (entero > 2)
    orderby entero 
    select entero;

var consulta5 =
    from entero in arrayDeEnteros
    where (entero < 5)
    orderby entero
    select entero;
var consulta6 =
    from entero in arrayDeEnteros
    where (entero > 2)
    orderby entero descending 
    select entero;

var consulta8 =
    from entero in arrayDeEnteros
    where (entero % 2 == 0)
    orderby entero 
    select entero;

var consulta9 =
    from entero in arrayDeEnteros
    where (entero % 2 == 0 && entero > 4)
    orderby entero descending 
    select entero;



string[] arrayDeCadenas = ["Alberto", "Jacinto", "Adrian", "Merche", "Eva", "Maria"];

var consulta10 =
    from nombre in arrayDeCadenas.Distinct()
    
    orderby nombre 
    select nombre;


var consulta11 =
    from nombre in arrayDeCadenas.Distinct()

    orderby nombre descending 
    select nombre;

var consulta12 =
    from nombre in arrayDeCadenas.Distinct()

    orderby nombre.Length
    select nombre;

var consulta13 =
    from nombre in arrayDeCadenas.Distinct()
    where (nombre.StartsWith("A") || nombre.EndsWith("o") || nombre.EndsWith("n"))
    orderby nombre
    select nombre;

var consulta14 =
    from nombre in arrayDeCadenas.Distinct()
    where (nombre.Length > 4)
    orderby nombre
    select nombre;



List<Persona> empleadosList =

[
    new Persona() { nombre = "Manolo", fechaNacimiento  = new(1978,06,26), sueldo = 2400 },
    new Persona() { nombre = "Ana", fechaNacimiento = new DateTime(1982,07,27) , sueldo = 3200 },
    new Persona() { nombre = "Felipe", fechaNacimiento = new DateTime(1995,06,29), sueldo = 2100 },
    new Persona() { nombre = "Ambrosio", fechaNacimiento = new DateTime(1994,06,28), sueldo = 2000 },
    new Persona() { nombre = "Raquel", fechaNacimiento = new DateTime(200,05,25), sueldo = 1500 },
    new Persona() { nombre = "Luisa", fechaNacimiento = new DateTime(2002,02,20), sueldo = 1600 },
    new Persona() { nombre = "Ernesto", fechaNacimiento = new DateTime(2010,01,10), sueldo = 600 },
    
];
var consulta15 =
    from item in empleadosList
    
    orderby item.sueldo
    select item.nombre;

  

////////////ff


var consulta16 = from item in empleadosList where (item.fechaNacimiento.Year < (DateTime.Today.Year - 18)) select item.nombre;

var consulta17 =
    from item in empleadosList

    orderby item.fechaNacimiento descending 
    select item.nombre;

var consulta18 =
    from item in empleadosList
    where (item.nombre.StartsWith("A") || item.nombre.StartsWith("E"))
orderby item.fechaNacimiento descending
    select item.nombre;

var consulta19 =
    from item in empleadosList
    where (item.nombre.StartsWith("A") || item.nombre.StartsWith("E"))
    orderby item.fechaNacimiento descending
    select item.nombre;







//////////ff
foreach (var item in consulta18)
{
    Console.WriteLine(item);
}

