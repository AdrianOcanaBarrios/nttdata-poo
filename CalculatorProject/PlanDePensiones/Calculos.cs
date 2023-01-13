using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    public class Calculos
    {
        public static float Calculo(Datos datos) {

            
            var porcentajeIRPF=0.0f;

          

            if (datos.BaseImponible >= 0 && datos.BaseImponible < 12499f) {
                porcentajeIRPF = 0.19f;
            }
            else if (datos.BaseImponible >= 12450f && datos.BaseImponible < 20199f)
            {
                porcentajeIRPF = 0.24f;
            }
            else if (datos.BaseImponible >= 20200f && datos.BaseImponible < 35199f)
            {
                porcentajeIRPF = 0.30f;

            }
            else if (datos.BaseImponible >= 35200f && datos.BaseImponible < 59999f)
            {
                porcentajeIRPF = 0.37f;
            }
            else if (datos.BaseImponible >= 60000f && datos.BaseImponible < 299999f)
            {
                porcentajeIRPF = 0.45f;
            }

            else if (datos.BaseImponible > 300000f)
            {
                porcentajeIRPF = 0.47f;
            }
            return (float)((datos.AportacionPersona + datos.AportacionEmpresa) * porcentajeIRPF);
        }   
    }
}
