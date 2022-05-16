using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Operación_matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero1, numero2, opcion;
            int correctas = 0;
            int incorrectas = 0;
            double resultado;
            for (int i = 0; i < 7; i++)
            {
                numero1 = random.Next(10);
                numero2 = random.Next(10);
                opcion = random.Next(4) + 1;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Resuelva: ");
                        Console.WriteLine("{0} + {1}", numero1, numero2);
                        resultado = Convert.ToDouble(Console.ReadLine());
                        if (resultado == (numero1 + numero2))
                        {
                            Console.WriteLine("Respueta correcta");
                            correctas += 1;
                            break;
                        }
                        if (resultado != (numero1 + numero2))
                        {
                            Console.WriteLine("Respuesta incorrecta");
                            incorrectas += 1; 
                            break;
                        }
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Resuelva: ");
                        Console.WriteLine("{0} - {1}", numero1, numero2);
                        resultado = Convert.ToDouble(Console.ReadLine());
                        if (resultado == (numero1 - numero2))
                        {
                            Console.WriteLine("Respueta correcta");
                            correctas += 1;
                        }
                        if (resultado != (numero1 - numero2))
                        {
                            Console.WriteLine("Respuesta incorrecta");
                            incorrectas += 1;
                            break;
                        }
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Resuelva: ");
                        Console.WriteLine("{0} * {1}", numero1, numero2);
                        resultado = Convert.ToDouble(Console.ReadLine());
                        if (resultado == (numero1 * numero2))
                        {
                            Console.WriteLine("Respueta correcta");
                            correctas += 1;
                        }
                        if (resultado != (numero1 * numero2))
                        {
                            Console.WriteLine("Respuesta incorrecta");
                            incorrectas += 1;
                            break;
                        }
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("Resuelva: ");
                        while (numero2 == 0)
                        {
                            numero2 = random.Next(10);
                        }
                        Console.WriteLine("{0} / {1}", numero1, numero2);
                        resultado = Convert.ToDouble(Console.ReadLine());
                        if (resultado == (numero1 / numero2))
                        {
                            Console.WriteLine("Respueta correcta");
                            correctas += 1;
                        }
                        if (resultado != (numero1 / numero2))
                        {
                            Console.WriteLine("Respuesta incorrecta");
                            incorrectas += 1;
                            break;
                        }
                        Console.WriteLine("");
                        break;
                }
            }
            Console.WriteLine("Respuestas correctas = {0}", correctas);
            Console.WriteLine("Respuestas correctas = {0}", incorrectas);
            Console.ReadKey();
        }
    }
}
