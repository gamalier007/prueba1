namespace DeterminarEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edad de la persona");
            Console.WriteLine();

            int edad;

            Console.Write("Introduzca la edad de la persona: ");
            edad=Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("ES mayor de edad.");
            }
            else {
                Console.WriteLine("Es menor de edad.");
            }

        }
    }
}
