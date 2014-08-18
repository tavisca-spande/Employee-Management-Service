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
                client.CreateNewEmployee(111, "Swapnil");
                client.CreateNewEmployee(111, "Anuj");
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
                
                client.AddRemarks(id);
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Valid Input");
            }
        }

        [TestMethod]
        public void AddingEmployeeDetails()
        {
            client.ClearList();
            int id = 101;
            string name = "Swapnil";
            Employee e = new Employee();
            client.CreateNewEmployee(id, name);
            e = rclient.SearchById(101);         
            Assert.AreEqual(e.Id, 101);
        }

        [TestMethod]
        public void GettingListOfAllEmployees()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            var list = rclient.GetAllEmployeeList();
            Assert.AreEqual(list.Length, 1);
        }

        [TestMethod]
        public void GetEmployeesWithRemarks()
        {
            client.ClearList();
            client.CreateNewEmployee(1001, "abc");
            client.CreateNewEmployee(1002, "xyz");
         
            client.AddRemarks(1001);
            var list = rclient.GetAllEmployeesWithRemarks();
            Assert.AreEqual(list.Length, 1);
        }

        [TestMethod]
        public void GetNonExistingEmployeeDetails()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            var emp = rclient.SearchById(102);
            Assert.AreEqual(emp, null);
        }

        [TestMethod]
        public void SearchEmployeeDetailsById()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            client.CreateNewEmployee(110, "swapnil");
            var emp = rclient.SearchById(101);
            Assert.AreEqual(emp.Name, "swap");
        }
       
    }
}
