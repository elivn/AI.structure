using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AI.structure.Common.Authrization;
using AI.structure.Common.ComModels.Enums;

namespace AI.structure.Common.Tests
{
    [TestClass]
    public class ElementIdTests
    {
        [TestMethod]
        public void ElementIdTest()
        {
            var idTye = ElementIdType.LoanGuid;
            idTye.InitialFromOldLoanOrLoanSheetId("Ins_");
            Assert.IsTrue(idTye==ElementIdType.InstalmentId);
        }
    }
}
