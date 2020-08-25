using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoloMisterioTest
{
    [TestClass]
    public class LibraryMisteriosaTests
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            double[] v = { 3, 4, 5, 9 };
            double s = ClasseMistero.Library_Misteriosa.CalcoloMisterioso(v);
            double s_aspettata = 21;
            Assert.AreEqual(s_aspettata, s);
        }
        [TestMethod]
        public void TestSomma0()
        {
            double[] v = { 0 };
            double s = ClasseMistero.Library_Misteriosa.CalcoloMisterioso(v);
            double s_asp = 0;
            Assert.AreEqual(s_asp, s);
        }
        [TestMethod]
        public void TestArrayVuoto()
        {
            double[] v = { };
            double s = ClasseMistero.Library_Misteriosa.CalcoloMisterioso(v);
            double s_asp = double.NaN;
            Assert.AreEqual(s_asp, s);
        }
    }
}
