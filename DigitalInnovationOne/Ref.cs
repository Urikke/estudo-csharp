namespace DigitalInnovationOne
{
    public class Ref
    {
        static void Inverter(ref int a, ref int b)
        {
            int temp = a;

            a = b;
            b = temp;
        }

        public void Inverter()
        {
            int i = 1, j = 3;

            Inverter(ref i, ref j);
            System.Console.WriteLine($"Valor de i: {i} - Valor de j: {j}");

        }
    }
}