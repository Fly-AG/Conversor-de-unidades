using System.Text;

namespace ConversionDeUnidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("|Conversor de unidades|");
                Console.WriteLine("Menú de conversiones");
                Console.WriteLine("Seleccione el tipo de conversión que desea realizar digitando el número correspondiente");
                Console.WriteLine("1. Temperatura (celsius, fahrenheit, kelvin)");
                Console.WriteLine("2. Distancia (metro, kilometro, centimetro)");
                Console.WriteLine("3. Potencias (binario, decimal, octal)");
                Console.WriteLine("0. Salir");
                char op = Console.ReadKey().KeyChar;

                switch (op)
                {
                    case '1':
                        MenuTemp();
                        break;
                    case '2':
                        MenuDist();
                        break;
                    case '3':
                        MenuPote();
                        break;
                    case '0':
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida. Presione una tecla...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuTemp()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("|Conversor de temperatura|");
                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Fahrenheit a Kelvin");
                Console.WriteLine("3. Kelvin a Celsius");
                Console.WriteLine("0. Atrás");
                char op = Console.ReadKey().KeyChar;

                switch (op)
                {
                    case '1':
                        Console.Write("\nIngrese Celsius: ");
                        double c = double.Parse(Console.ReadLine());
                        double f = (c * 9 / 5) + 32;
                        Console.WriteLine($"Resultado: {f} °F");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Write("\nIngrese Fahrenheit: ");
                        f = double.Parse(Console.ReadLine());
                        double k = (f - 32) * 5 / 9 + 273.15;
                        Console.WriteLine($"Resultado: {k} K");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Write("\nIngrese Kelvin: ");
                        k = double.Parse(Console.ReadLine());
                        c = k - 273.15;
                        Console.WriteLine($"Resultado: {c} °C");
                        Console.ReadKey();
                        break;
                    case '0':
                        back = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuDist()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("|Conversor de distancia|");
                Console.WriteLine("1. Metros a Kilómetros");
                Console.WriteLine("2. Metros a Centímetros");
                Console.WriteLine("3. Kilómetros a Metros");
                Console.WriteLine("0. Atrás");
                char op = Console.ReadKey().KeyChar;

                switch (op)
                {
                    case '1':
                        Console.Write("\nIngrese metros: ");
                        double m = double.Parse(Console.ReadLine());
                        double km = m / 1000;
                        Console.WriteLine($"Resultado: {km} km");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Write("\nIngrese metros: ");
                        m = double.Parse(Console.ReadLine());
                        double cm = m * 100;
                        Console.WriteLine($"Resultado: {cm} cm");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Write("\nIngrese kilómetros: ");
                        km = double.Parse(Console.ReadLine());
                        m = km * 1000;
                        Console.WriteLine($"Resultado: {m} m");
                        Console.ReadKey();
                        break;
                    case '0':
                        back = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuPote()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("|Conversor de potencias|");
                Console.WriteLine("1. Decimal a Binario");
                Console.WriteLine("2. Binario a Octal");
                Console.WriteLine("3. Octal a Decimal");
                Console.WriteLine("0. Atrás");
                char op = Console.ReadKey().KeyChar;

                switch (op)
                {
                    case '1':
                        Console.Write("\nIngrese número decimal: ");
                        int dec = int.Parse(Console.ReadLine());
                        string bin = Convert.ToString(dec, 2);
                        Console.WriteLine($"Resultado: {bin} (binario)");
                        Console.ReadKey();
                        break;

                    case '2':
                        Console.Write("\nIngrese número binario: ");
                        string binario = Console.ReadLine();
                        int decFromBin = Convert.ToInt32(binario, 2);
                        string octFromBin = Convert.ToString(decFromBin, 8);
                        Console.WriteLine($"Resultado: {octFromBin} (octal)");
                        Console.ReadKey();
                        break;

                    case '3':
                        Console.Write("\nIngrese número octal: ");
                        string octal = Console.ReadLine();
                        int decFromOct = Convert.ToInt32(octal, 8);
                        Console.WriteLine($"Resultado: {decFromOct} (decimal)");
                        Console.ReadKey();
                        break;

                    case '0':
                        back = true;
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}