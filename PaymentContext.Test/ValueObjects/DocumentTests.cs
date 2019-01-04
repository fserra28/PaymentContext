using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Test
{
    [TestClass]
    public class DocumentTests
    {
        ///Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
            
        }
        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid()
        {
            
           var doc = new Document("12127527000160", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
            
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
         
          var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);

        }
        [TestMethod]
        public void ShouldReturnSucessWhenCPFIsValid()
        {
            
            var doc = new Document("57333214150", EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
            
        }
    }
}