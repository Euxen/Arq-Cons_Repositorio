Console.WriteLine("Saludos, favor digitar un numero");
var input = Console.ReadLine();

// We need to confirm that it is a number
var validNumber = int.TryParse(input, out var value);

// We need a way to end this loop
if (validNumber == false)
{
    Console.WriteLine("Favor entrar un numero valido! \n");
}
else
{
    //Here we start doing all the calculations required
    Console.Clear();
    Console.WriteLine("Nota: Los siguentes valores seran redondeados a numeros enteros.\n");

    //First is the absolute value of the input
    Console.WriteLine($"El valor absoluto de {input} es {Math.Abs(value)} \n");
    //Second is the 2nd power of the input
    Console.WriteLine($"La potencia quadrada de {input} es { Math.Pow(value, 2)}\n");
    //Third is the square root of the input
    Console.WriteLine($"La raiz quadrada de {input} es {Math.Round(Math.Sqrt(value)), 2}\n");
    //Fourth is the sine value of the input
    Console.WriteLine($"El valor seno de {input} es {Math.Round(Math.Sin(value)), 2}\n");
    //Fifth is the cosine value of the input
    Console.WriteLine($"El valor coseno de {input} es {Math.Round(Math.Cos(value)), 2} \n");

    //Esto nos ayuda prevenir que la consola se cierre cuando se termine las calculaciones
    Console.Write($"{Environment.NewLine} Presione cualquier tecla para salir");
    Console.ReadKey(true);
}


