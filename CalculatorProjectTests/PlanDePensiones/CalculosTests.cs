using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PlanDePensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones.Tests
{
    [TestClass()]
    public class CalculosTests
    {
        
        [DataRow(12000f,1500f,2000f, 665f)]
        [DataRow(18000f, 1500f, 2000f,840f)]
        [DataRow(22000f, 1500f, 2000f,1050f)]
        [DataRow(36000f, 1500f, 2000f, 1295f)]
        [DataRow(62000f, 1500f, 2000f,1575f)]
        [DataRow(312000f, 1500f, 2000f,1645f)]
        [DataTestMethod()]
        public void CalculosTest(float numero1, float numero2, float numero3,float result)
        {
            var datos = new Datos(numero1, numero2, numero3);

            Assert.IsTrue(Calculos.Calculo(datos)==result);
        }
    }
}