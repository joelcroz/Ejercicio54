using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    class Program
    {
        static void Main(string[] args)
        {
			double alturaPersona;
			bool alturaNoValida;

			var personaMasAlta="";
            var personaMasBaja="";

            //double sumaDeAlturas=0;
            double promedioDeAltura = 0;

            double menorAltura = 231;
            double mayorAltura = 0;
            for (int contadorPersonas = 1; contadorPersonas <= 7; contadorPersonas++)
            {
				Console.Write($"Ingrese el nombre de la persona nro {contadorPersonas}:");
				string nombrePersona = Console.ReadLine();
				alturaNoValida = true;
                do
                {
					Console.Write("Ingrese la altura de la persona:");
					alturaPersona = Convert.ToDouble(Console.ReadLine());
                    if (alturaPersona>=1 && alturaPersona<=230)
                    {
						alturaNoValida = false;
                    }
                    else
                    {
						Console.WriteLine("Altura no valida, debe ingresar entre 1 y 230");	
                    }

                } while (alturaNoValida);

                if (alturaPersona>mayorAltura)
                {
					mayorAltura = alturaPersona;
					personaMasAlta = nombrePersona;
                }

                if (alturaPersona<menorAltura)
                {
					menorAltura = alturaPersona;
					personaMasBaja = nombrePersona;
                }

                promedioDeAltura += alturaPersona;
            }

            promedioDeAltura /=7;//Es igual a promedioDeAltura=promedioDEAltura/7
            Console.WriteLine($"La persona màs alta es {personaMasAlta} con {mayorAltura} cms");
			Console.WriteLine($"La persona màs baja es {personaMasBaja} con {menorAltura} cms");
			Console.WriteLine($"El promedio de altura es {promedioDeAltura}");
            Console.ReadLine();
		}
    }
}
