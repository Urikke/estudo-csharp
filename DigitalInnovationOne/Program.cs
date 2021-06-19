using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using(System.IO.TextWriter t =  System.IO.File.CreateText("TextoTeste.txt"))
            {
                t.WriteLine("Linha 1");
                t.WriteLine("Linha 2");
                t.WriteLine("Linha 3");   
            }

            string teste = System.IO.File.ReadAllText("TextoTeste.txt");

            Console.WriteLine(teste);
        }

        static void TryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();
                
                return x / y;
            }

            try
            {
                if(args.Length != 2)
                    throw new InvalidOperationException("Informe dois números!");

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x,y));
            }
            
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine($"Erro Genérico: {e.Message}");
            }

            finally
            {
                Console.WriteLine("Até breve!");
            }
        }
    }
}
