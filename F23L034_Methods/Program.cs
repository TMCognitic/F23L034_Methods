namespace F23L034_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius;
            celsius.Temperature = 30;
            Fahrenheit fahrenheit = celsius.Convert();
            Console.WriteLine(fahrenheit.Temperature);
            celsius = fahrenheit.Convert();
            Console.WriteLine(celsius.Temperature);


            EQ2D eq1;
            eq1.A = 1;
            eq1.B = 1;
            eq1.C = -2;

            if(eq1.Resoudre(out double? x1, out double? x2))
            {
                Logger.Log(x1, x2);
            }
            else
            {
                Logger.Log("Pas de resultat");
            }

            EQ2D eq2;
            eq2.A = 4;
            eq2.B = 4;
            eq2.C = 1;

            if (eq2.Resoudre(out x1, out  x2))
            {
                Logger.Log(x1, x2);
            }
            else
            {
                Logger.Log("Pas de resultat");
            }
        }

        
    }
}