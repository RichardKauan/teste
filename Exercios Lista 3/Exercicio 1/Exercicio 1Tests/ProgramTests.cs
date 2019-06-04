using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcularFatorialTest()
        {            
            int fatorado = 5;
            int retorno;

            retorno = Program.CalcularFatorial(fatorado);
            Assert.AreEqual(120, retorno);
        }
    }
}