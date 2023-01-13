using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    public class PrintPensiones
    {
        public static void RecogerDatos()
        {
            Datos datos = new Datos();
            Console.WriteLine("¿Cual es tu base imponible?");
            datos.BaseImponible = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cual es la aportacion a tu plan de pensiones de persona fisica?");
            datos.AportacionPersona = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cual es la aportacioin a tu plan de empresa?");
            datos.AportacionEmpresa = float.Parse(Console.ReadLine()); ;
        }
    }
}
