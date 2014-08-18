using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementServiceFixture.EmployeeManagementService;
using System.ServiceModel;

namespace EmployeeManagementServiceFixture
{
    [TestClass]
    public class EmployeeMS
    {
        CreateEmployeeAndAddRemarksClient client = new CreateEmployeeAndAddRemarksClient();
        RetrieveClient rclient = new RetrieveClient();

        [TestMethod]
        public void AddEmployeeWithSameId()
        {      
            try
            {
                client.CreateNewEmployee(101, "Swapnil");
                client.CreateNewEmployee(101, "Anuj");
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Duplicate Id");
            }
        }

        [TestMethod]
        public void AddRemarksToNonExistingEmployee()
        {
            int id = 100;
            try
            {
                Employee employee = rclient.SearchById(id);
                client.AddRemarks(employee);
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Valid Input");
            }
        }

        [TestMethod]
        public void AddingEmployeeDetails()
        {

            int id = 1012;
            string name = "Swapnil";
            Employee e = new Employee();
            client.CreateNewEmployee(id, name);
            e = rclient.SearchById(1011);         
            Assert.AreEqual(e.Id, 1011);
        }
       
    }
}
