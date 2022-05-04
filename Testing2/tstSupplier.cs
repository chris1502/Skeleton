using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.Stock = TestData;
            Assert.AreEqual(AnSupplier.Stock, TestData);
        }

        [TestMethod]

        public void DeliveryDatePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DeliveryDate = TestData;
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierId = TestData;
            Assert.AreEqual(AnSupplier.SupplierId, TestData);

        }

        [TestMethod]
        public void SupplierFeedbackPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierFeedback = TestData;
            Assert.AreEqual(AnSupplier.SupplierFeedback, TestData);
        }

        [TestMethod]
        public void SupplierProductPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "Box of sweets";
            AnSupplier.SupplierProduct = TestData;
            Assert.AreEqual(AnSupplier.SupplierProduct, TestData);

        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.Price = TestData;
            Assert.AreEqual(AnSupplier.Price, TestData);
        }



    }


}





