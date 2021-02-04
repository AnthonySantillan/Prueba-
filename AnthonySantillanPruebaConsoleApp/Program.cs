using System;
using System.Linq;
using System.Threading;

namespace AnthonySantillanPruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola en el edicio tenemos los siguientes departamentos con un numero de personas ");
            //12 pisos 8 departamentos por piso en cada departamento vive 1 a seis personas 


            Thread piso1 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 1:");
            piso1.Start();

            Thread piso2 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 2:");
            piso2.Start();

            Thread piso3 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 3:");
            piso3.Start();

            Thread piso4 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 4:");
            piso4.Start();

            Thread piso5 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 5:");
            piso5.Start();

            Thread piso6 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 6:");
            piso6.Start();

            Thread piso7 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 7:");
            piso7.Start();

            Thread piso8 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 8:");
            piso8.Start();

            Thread piso9 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 9:");
            piso9.Start();

            Thread piso10 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 10:");
            piso10.Start();

            Thread piso11 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 11:");
            piso11.Start();

            Thread piso12 = new Thread(NumeroPersonas);
            Console.WriteLine("piso 12:");
            piso12.Start();

            piso1.Join();
            piso2.Join();
            piso3.Join();
            piso4.Join();
            piso5.Join();
            piso6.Join();
            piso7.Join();
            piso8.Join();
            piso9.Join();
            piso10.Join();
            piso11.Join();
            piso12.Join();

        }
        public static void NumeroPersonas()
        {
            var departamento = 0;

            for (int i = 0; i <= 11; i++)
            {
                var randomDepartamento = new Random();
                if (departamento <= 7)
                {
                    departamento++;
                }


                var random = new Random();
                var value = random.Next(1, 6);

                Console.WriteLine($"piso {i} - departamento {departamento} - numero de personas {value}");
            }
        }
    }
}
