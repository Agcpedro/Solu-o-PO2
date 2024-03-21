using Atividade_PO2;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomaNumero()
        {
            int metro = 10;
            MeToMi conversao = new MeToMi();

            int resultado = (int)conversao.ConverterMetroParaMilimetro(metro);

            Assert.AreEqual(10000, resultado);
        }
    }
}