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
        RetrieveClient clientForRetrievingData = new RetrieveClient();

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
            finally
            {
                client.Close();
            }
        }

        [TestMethod]
        public void AddRemarksToNonExistingEmployee()
        {
            int id = 100;
            client.ClearList();
            try
            {
       
                client.AddRemarks(id,"Added some remark");
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Valid Input");
            }
            client.Close();
        }

        [TestMethod]
        public void AddingEmployeeDetails()
        {
            client.ClearList();
            int id = 101;
            string name = "Swapnil";
            Employee e = new Employee();
            client.CreateNewEmployee(id, name);
            e = clientForRetrievingData.SearchById(101);         
            Assert.AreEqual(e.Id, 101);
        }

        [TestMethod]
        public void GettingListOfAllEmployees()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            var list = clientForRetrievingData.GetAllEmployeeList();
            Assert.AreEqual(list.Length, 1);
        }

        [TestMethod]
        public void GetEmployeesWithRemarks()
        {
            client.ClearList();
            client.CreateNewEmployee(1001, "abc");
            client.CreateNewEmployee(1002, "xyz");
         
            client.AddRemarks(1001,"Added some remark");
            var list = clientForRetrievingData.GetAllEmployeesWithRemarks();
            Assert.AreEqual(list.Length, 1);
        }

        [TestMethod]
        public void GetNonExistingEmployeeDetails()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            var emp = clientForRetrievingData.SearchById(102);
            Assert.AreEqual(emp, null);
        }

        [TestMethod]
        public void GetEmployeeDetailsById()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            client.CreateNewEmployee(110, "swapnil");
            var emp = clientForRetrievingData.SearchById(101);
            Assert.AreEqual(emp.Name, "swap");
        }
        [TestMethod]
        public void GetEmployeeDetailsByName()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swap");
            client.CreateNewEmployee(110, "swapnil");
            var empList = clientForRetrievingData.SearchByName("swapnil");
            Assert.AreEqual(empList.Length,1);
        }


        [TestMethod]
        public void SearchNonExistingEmployeeByName()
        {
            client.ClearList();
            client.CreateNewEmployee(101, "swapnil");
            client.CreateNewEmployee(110, "swapnil");
            var empList = clientForRetrievingData.SearchByName("swap");
            Assert.AreEqual(empList.Length, 0);
        }
    }
}
