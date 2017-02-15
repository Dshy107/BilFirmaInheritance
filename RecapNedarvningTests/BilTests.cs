using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning.Tests
{
    [TestClass()]
    public class BilTests
    {

        [TestMethod()]
        public void beregnAfgiftDiesel_80500_Test()
        {
            Dieselbil bil = new Dieselbil(80500, 2014, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(80500);
            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_80500_Test()
        {
            BenzinBil bil = new BenzinBil(80500, 2014, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(80500);
            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_80499_Test()
        {
            Dieselbil bil = new Dieselbil(80499, 2014, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(80499);
            Assert.AreEqual(84523, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_80499_Test()
        {
            BenzinBil bil = new BenzinBil(80499, 2014, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(80499);
            Assert.AreEqual(84523, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_81700_Test()
        {
            Dieselbil bil = new Dieselbil(81700, 2015, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(81700);
            Assert.AreEqual(85785, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_81700_Test()
        {
            BenzinBil bil = new BenzinBil(81700, 2015, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(81700);
            Assert.AreEqual(85785, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_81699_Test()
        {
            Dieselbil bil = new Dieselbil(81699, 2015, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(81699);
            Assert.AreEqual(85783, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_81699_Test()
        {
            BenzinBil bil = new BenzinBil(81699, 2015, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(81699);
            Assert.AreEqual(85783, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_81701_Test()
        {
            Dieselbil bil = new Dieselbil(81701, 2015, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(81701);
            Assert.AreEqual(85786, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_81701_Test()
        {
            BenzinBil bil = new BenzinBil(81701, 2015, "BMW", "xx99999", 50, 500);
            int afgift = bil.beregnAfgift(81701);
            Assert.AreEqual(85786, afgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_true_Test()
        {
            Dieselbil dBil = new Dieselbil(81700, 2015, "BMW", "xx99999", 50, 500, true);
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(350, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_false_Test()
        {
            Dieselbil dBil = new Dieselbil(81700, 2015, "BMW", "xx99999", 50, 500, false);
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(850, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzinTest()
        {
            BenzinBil bBil = new BenzinBil(81700, 2015, "BMW", "xx99999", 50, 500);
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(320, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin2Test()
        {
            BenzinBil bBil = new BenzinBil(81700, 2015, "BMW", "xx99999", 19, 500);
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(1200, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin3Test()
        {
            BenzinBil bBil = new BenzinBil(81700, 2015, "BMW", "xx99999", 25, 500);
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(600, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftElTest()
        {
            ElBil eBil = new ElBil(81700, 2015, "BMW", "xx99999", 25, 500);
            int ejeAfgift = eBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(0, ejeAfgift);
        }





        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_true_2014_Test()
        {
            Dieselbil dBil = new Dieselbil(80500, 2014, "BMW", "xx99999", 50, 500, true);
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(350, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_false_2014_Test()
        {
            Dieselbil dBil = new Dieselbil(80500, 2014, "BMW", "xx99999", 50, 500, false);
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(850, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin_2014_Test()
        {
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 50, 500);
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(320, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin2_2014_Test()
        {
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 19, 500);
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(1200, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin3_2014_Test()
        {
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 25, 500);
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(600, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftEl_2014_Test()
        {
            ElBil eBil = new ElBil(80500, 2014, "BMW", "xx99999", 25, 500);
            int ejeAfgift = eBil.HalvÅrligEjerAfgift();
            Assert.AreEqual(0, ejeAfgift);
        }


        [TestMethod()]
        public void RækkeViddeDieselTest()
        {
            Dieselbil dBil = new Dieselbil(80500, 2014, "BMW", "xx99999", 15, 85);
            int rækkeVidde = dBil.RækkeVidde();
            Assert.AreEqual(1275, rækkeVidde);
        }

        [TestMethod()]
        public void RækkeViddeBenzinTest()
        {
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 12, 85);
            int rækkeVidde = bBil.RækkeVidde();
            Assert.AreEqual(1020, rækkeVidde);
        }

        [TestMethod()]
        public void RækkeViddeElTest()
        {
            ElBil eBil = new ElBil(80500, 2014, "BMW", "xx99999", 60, 515);
            int rækkeVidde = eBil.RækkeVidde();
            Assert.AreEqual(30900, rækkeVidde);
        }

    }
}