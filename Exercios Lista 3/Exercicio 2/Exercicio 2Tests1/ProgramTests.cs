using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcularDiferencaTest()
        {
            double valor1 = 25;
            double valor2 = 15;
            double retorno;

            retorno = Program.CalcularDiferenca(valor1, valor2);
            Assert.AreEqual(10, retorno);
        }
    }
}