using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    public class Datos
    {
        public float BaseImponible { get; set; }
        public float AportacionPersona { get; set; }
        public float AportacionEmpresa { get; set; }
        

        public Datos() { }

        public Datos(float baseImponible,float aportacionPersona,float aportacionEmpresa) {
        
            BaseImponible= baseImponible;
            AportacionPersona= aportacionPersona;   
            AportacionEmpresa= aportacionEmpresa;
        
        }
    }
}
