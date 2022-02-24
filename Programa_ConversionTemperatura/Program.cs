Console.WriteLine("Saludos, favor digitar una temperatura en Fahrenheit");
var input = Console.ReadLine();

// We need to confirm that it is a number
var validNumber = decimal.TryParse(input, out var value);

// We need a way to end this loop
if (validNumber == false)
{
    Console.WriteLine("Favor entrar una temperatura valida! \n");
}
else
{
    //Here we start doing all the calculations required
    Console.Clear();

    //From Fahrenheit to Celsius
    var Celsius = Math.Round((value - 32) * 5 / 9, 2);
    Console.WriteLine($"La temperatura en Fahrenheit es de {value}F, su equivalente en Celsius en de {Celsius}C");

    //From Celius to Fahrenheit
    Console.WriteLine($"La temperatura en Celsius es de {Celsius}C, su equivalente en Celsius en de {value}F");

    //Prevent the console from closing the moment the program is done
    Console.Write($"{Environment.NewLine} Presione cualquier tecla para salir");
    Console.ReadKey(true);
}
