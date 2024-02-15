using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero para convertir a decimal: ");
        int entero = int.Parse(Console.ReadLine());
        decimal decR = Convert.ToDecimal(entero);
        Console.WriteLine($"Entero a Decimal: {decR}");

        Console.Write("Ingrese un número decimal para convertir a flotante: ");
        decimal decN = decimal.Parse(Console.ReadLine());
        float floatR = Convert.ToSingle(decN);
        Console.WriteLine($"Decimal a Flotante: {floatR}");

        Console.Write("Ingrese un número flotante para convertir a entero: ");
        float flotanteNum = float.Parse(Console.ReadLine());
        int enteroR = Convert.ToInt32(flotanteNum);
        Console.WriteLine($"Flotante a Entero: {enteroR}");

        Console.Write("Ingrese un carácter para convertir a entero: ");
        char caracter = char.Parse(Console.ReadLine());
        int caracterEntero = Convert.ToInt32(caracter);
        Console.WriteLine($"Carácter a Entero: {caracterEntero}");

        Console.Write("Ingrese un número entero para convertir a carácter: ");
        int enteroCaracter = int.Parse(Console.ReadLine());
        char enteroCaracterResultado = Convert.ToChar(enteroCaracter);
        Console.WriteLine($"Entero a Carácter: {enteroCaracterResultado}");




        Console.Write("Ingrese el primer número entero: ");
        int E1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int E2 = Convert.ToInt32(Console.ReadLine());

        int sumaEnteros = E1 + E2;
        Console.WriteLine($"Suma de enteros: {sumaEnteros}");

        Console.Write("Ingrese el primer número decimal: ");
        decimal D1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo número decimal: ");
        decimal D2 = Convert.ToDecimal(Console.ReadLine());

        decimal rD = D1 - D2;
        Console.WriteLine($"Resta de decimales: {rD}");

        Console.Write("Ingrese el primer número flotante: ");
        float nM1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Ingrese el segundo número flotante: ");
        float nM2 = Convert.ToSingle(Console.ReadLine());

        float multiplicacionFlotantes = nM1 * nM2;
        Console.WriteLine($"Multiplicación de flotantes: {multiplicacionFlotantes}");

        Console.Write("Ingrese el primer número entero para la división: ");
        int nDiv = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero divisor: ");
        int nDiv1 = Convert.ToInt32(Console.ReadLine());

        if (nDiv1 != 0)
        {
            int divisionEnteros = nDiv / nDiv1;
            Console.WriteLine($"División de enteros: {divisionEnteros}");
        }
        else
        {
            Console.WriteLine("No es posible dividir entre cero.");
        }

        Console.Write("Ingrese el primer número entero para el módulo: ");
        int nmo1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero divisor para el módulo: ");
        int nmo2 = Convert.ToInt32(Console.ReadLine());

        if (nmo2 != 0)
        {
            int moduloEnteros = nmo1 % nmo2;
            Console.WriteLine($"Módulo de enteros: {moduloEnteros}");
        }
        else
        {
            Console.WriteLine("No es posible calcular el módulo con divisor cero.");
        }


        Console.Write("Ingrese una cadena de texto: ");
        string CadT = Console.ReadLine();

        Console.WriteLine($"Cadena en mayúsculas: {CadT.ToUpper()}");

        Console.WriteLine($"Cadena en minúsculas: {CadT.ToLower()}");

        char[] caracteresReversa = CadT.ToCharArray();
        Array.Reverse(caracteresReversa);
        string cadenaReversa = new string(caracteresReversa);
        Console.WriteLine($"Cadena al revés: {cadenaReversa}");

        Console.Write("Ingrese una palabra a buscar: ");
        string palabraBuscar = Console.ReadLine();
        bool contienePalabra = CadT.Contains(palabraBuscar, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"La cadena {(contienePalabra ? "sí" : "no")} contiene la palabra '{palabraBuscar}'.");

        int contadorVocales = 0;
        foreach (char caracter1 in CadT.ToLower())
        {
            if ("aeiou".Contains(caracter1))
            {
                contadorVocales++;
            }
        }
        Console.WriteLine($"Número de vocales en la cadena: {contadorVocales}");



        Console.WriteLine("1. Calcular el área de un triángulo.");
        Console.Write("Ingrese la base del triángulo: ");
        double baseT = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del triángulo: ");
        double AlturaT = Convert.ToDouble(Console.ReadLine());
        double AreaT = CalcularAreaTriangulo(baseT, AlturaT);
        Console.WriteLine($"El área del triángulo es: {AreaT}");

        Console.WriteLine("\n2. Calcular el volumen de una esfera.");
        Console.Write("Ingrese el radio de la esfera: ");
        double raD = Convert.ToDouble(Console.ReadLine());
        double volE = CalcularVolumenEsfera(raD);
        Console.WriteLine($"El volumen de la esfera es: {volE}");

        Console.WriteLine("\n3. Calcular la distancia entre dos puntos.");
        Console.Write("Ingrese la coordenada x del primer punto: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la coordenada y del primer punto: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la coordenada x del segundo punto: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la coordenada y del segundo punto: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        double distancia = CalcularDistanciaEntreDosPuntos(x1, y1, x2, y2);
        Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

        Console.WriteLine("\n4. Convertir temperatura de Celsius a Fahrenheit.");
        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = ConvertirCelsiusAFahrenheit(celsius);
        Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}°F");

        Console.WriteLine("\n5. Convertir temperatura de Fahrenheit a Celsius.");
        Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
        double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
        double celsius2 = ConvertirFahrenheitACelsius(fahrenheit2);
        Console.WriteLine($"La temperatura en grados Celsius es: {celsius2}°C");
    }

    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        return 0.5 * baseTriangulo * alturaTriangulo;
    }

    static double CalcularVolumenEsfera(double radioEsfera)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
    }

    static double CalcularDistanciaEntreDosPuntos(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double ConvertirCelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double ConvertirFahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}