using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbol
{
    internal class Program
    {
        private const string IngresoNombreEquipo = "Ingrese Nombre Del Equipo ";
        private const int EquipoUno = 1;
        private const int EquipoDos = 2;
        private const int EquipoTres = 3;
        private const string Reglas = "Cada Equipo jugará dos veces. y los puntos se darán: \n 3 por ganar \n 1 por Empate \n 0 por perder";
        private const string EquiposRegistrados = "Los Equipo Registrados Son: ";
        private const string TextParidoUno = "Primer Partido: ";
        private const string TextParidoDos = "Segundo Partido: ";
        private const string TextParidoTres = "Tercer Partido: ";
        private const string Vs = "Vs ";
        private const string TextGolesAnotados = "Inidique los goles anotados por el equipo: ";
        static void Main(string[] args)
        {

            Console.WriteLine(IngresoNombreEquipo + EquipoUno);
            var NombreEquipo1 = Console.ReadLine();
            int PuntajeEquipo1 = 0;
            int golesEquipo1 = 0;

            Console.WriteLine(IngresoNombreEquipo + EquipoDos);
            var NombreEquipo2 = Console.ReadLine();
            int PuntajeEquipo2 = 0;
            int golesEquipo2 = 0;

            Console.WriteLine(IngresoNombreEquipo + EquipoTres);
            var NombreEquipo3 = Console.ReadLine();
            int PuntajeEquipo3 = 0;
            int golesEquipo3 = 0;

            Console.WriteLine(EquiposRegistrados);
            Console.WriteLine(NombreEquipo1);
            Console.WriteLine(NombreEquipo2);
            Console.WriteLine(NombreEquipo3);


            Console.WriteLine(Reglas);

            Console.WriteLine(TextParidoUno + NombreEquipo1 + Vs + NombreEquipo2);
            Console.WriteLine(TextGolesAnotados + NombreEquipo1);
            golesEquipo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TextGolesAnotados + NombreEquipo2);
            golesEquipo2 = Convert.ToInt32(Console.ReadLine());

            if(golesEquipo1 == golesEquipo2)
            {
                PuntajeEquipo1 = +1;
                PuntajeEquipo2 = +1;
            }

            if(golesEquipo1 > golesEquipo2)
            {
                PuntajeEquipo1+= 3;
            }
            else
            {
                PuntajeEquipo2 += 3;
            }

            golesEquipo1 = 0;
            golesEquipo2 = 0;

            Console.WriteLine(TextParidoDos + NombreEquipo1 + Vs + NombreEquipo3);
            Console.WriteLine(TextGolesAnotados + NombreEquipo1);
            golesEquipo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TextGolesAnotados + NombreEquipo3);
            golesEquipo3 = Convert.ToInt32(Console.ReadLine());

            if (golesEquipo1 == golesEquipo3)
            {
                PuntajeEquipo1 = +1;
                PuntajeEquipo3 = +1;
            }

            if (golesEquipo1 > golesEquipo3)
            {
                PuntajeEquipo1 += 3;
            }
            else
            {
                PuntajeEquipo3 += 3;
            }

            golesEquipo1 = 0;
            golesEquipo3 = 0;

            Console.WriteLine(TextParidoTres + NombreEquipo2 + Vs + NombreEquipo3);
            Console.WriteLine(TextGolesAnotados + NombreEquipo2);
            golesEquipo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TextGolesAnotados + NombreEquipo3);
            golesEquipo3 = Convert.ToInt32(Console.ReadLine());

            if (golesEquipo2 == golesEquipo3)
            {
                PuntajeEquipo2 = +1;
                PuntajeEquipo3 = +1;
            }

            if (golesEquipo2 > golesEquipo3)
            {
                PuntajeEquipo2 += 3;
            }
            else
            {
                PuntajeEquipo3 += 3;
            }

            golesEquipo2 = 0;
            golesEquipo3 = 0;


            if(PuntajeEquipo1 > PuntajeEquipo2 && PuntajeEquipo1 > PuntajeEquipo3)
            {
                Console.WriteLine("Equipo Ganador: " + NombreEquipo1 );
            }
            else
            {
                if(PuntajeEquipo2 > PuntajeEquipo3)
                {
                    Console.WriteLine("Equipo Ganador: " + NombreEquipo2);
                }
                else
                {
                    Console.WriteLine("Equipo Ganador: " + NombreEquipo3);
                }
            }

            Console.ReadLine();
        }
    }
}
