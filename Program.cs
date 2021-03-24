using System;

namespace Triangulo1
{
    class Program
    {

        public int longitud = 0;
        public int inicio = 0, media = 0, fin = 0;
        public int[][] matriz;
        public string respuesta;

        public void Mensaje()
        {
            Console.Clear();
            Console.WriteLine("============================================================================");
            Console.WriteLine("                APLICACION DE FIGURA GEOMETRICA, TRIANGULO 1                ");
            Console.WriteLine("============================================================================");

        }

        public void Respuesta()
        {
            Mensaje();
            Console.WriteLine("¿Quiere continuar la ejecución? Si desea hacerlo, Digite 'SI'");
            Console.WriteLine("Sino presione cualquier tecla para finalizar la ejecucion");
            respuesta = Console.ReadLine();
            while (respuesta.ToUpper() == "SI")
            {
                Filtro();
            }

            Console.Clear();

            Mensaje();
            Console.WriteLine("La ejecucion se cerrara presionando cualquier tecla");

            Console.ReadKey();
            Console.Clear();
        }



        public string Filtro()
        {
            Mensaje();
            Console.WriteLine("Ingrese el numero de elemento que tendra su arreglo");
            Console.WriteLine("Y receurde que debe de ser un numero ' impar '");
            longitud = int.Parse(Console.ReadLine());

            if ((longitud % 2) != 0)
            {
                inicio = 1;
                fin = longitud;

                Mensaje();
                matriz = new int[longitud][];

                for (int i = 1; i <= longitud; i++)
                {
                    for (int j = 1; j <= longitud; j++)
                    {

                        if (j >= inicio && j <= fin)
                        {

                            Console.Write("| * |");
                        }
                        else
                        {
                            Console.Write("|   |");
                        }
                    }
                    fin--;
                    inicio++;
                    Console.WriteLine("");

                }

            }
            else
            {
                Mensaje();
                Console.WriteLine("El numero ingresado no es impar.");

            }

            Console.WriteLine("¿Quiere continuar la ejecución? Si desea hacerlo, Digite 'SI'");
            Console.WriteLine("Sino presione cualquier tecla para finalizar la ejecucion");
            respuesta = Console.ReadLine();
            return respuesta;

        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Mensaje();
            p.Respuesta();
        }
    }
}
