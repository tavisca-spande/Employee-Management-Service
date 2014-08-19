using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementServiceFixture.EmployeeManagementService;
using System.ServiceModel;

namespace EmployeeManagementServiceFixture
{
    [TestClass]
    public class EmployeeMS
    {
        private TestContext _testContextInstance;
        public TestContext TestContext
        {
            get { return _testContextInstance; }
            set { _testContextInstance = value; }
        }

        CreateEmployeeAndAddRemarksClient client = new CreateEmployeeAndAddRemarksClient();
        RetrieveClient clientForRetrievingData = new RetrieveClient();

        int id;
        String name;
        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "AddEmployee",DataAccessMethod.Sequential)]
        public void AddEmployeeWithSameId()
        {
            try
            {
                client.ClearList();
                id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                name = _testContextInstance.DataRow["Name"].ToString();
                client.CreateNewEmployee(id, name);
                id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                name = _testContextInstance.DataRow["Name"].ToString();
                client.CreateNewEmployee(id, name);
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
            int _id = 100;
            client.ClearList();
            try
            {
                client.AddRemarks(_id,"Added some remark");
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Valid Input");
            }
            client.Close();
        }

        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "AddEmployee",
         DataAccessMethod.Sequential)]
        public void AddingEmployeeDetails()
        {
            client.ClearList();
            int id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            string name = _testContextInstance.DataRow["Name"].ToString();
            Employee emp = new Employee();
            client.CreateNewEmployee(id, name);
            emp = clientForRetrievingData.SearchById(20);         
            Assert.AreEqual(emp.Id, 20);
        }

        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "AddEmployee",
         DataAccessMethod.Sequential)]
        public void GettingListOfAllEmployees()
        {
            client.ClearList();
            id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(id,name);
            var _list = clientForRetrievingData.GetAllEmployeeList();
            Assert.AreEqual(_list.Length, 1);
        }

        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "AddRemarks",
         DataAccessMethod.Sequential)]
        public void GetEmployeesWithRemarks()
        {
            client.ClearList();
            
            client.CreateNewEmployee(1001, "abc");
            client.CreateNewEmployee(1002, "xyz");
            id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            string remarkContent = _testContextInstance.DataRow["RemarkContent"].ToString();
            client.AddRemarks(id,remarkContent);
            var list = clientForRetrievingData.GetAllEmployeesWithRemarks();
            Assert.AreEqual(list.Length, 1);
        }

        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "AddEmployee",
         DataAccessMethod.Sequential)]
        public void GetNonExistingEmployeeDetails()
        {
            client.ClearList();
            id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(id, name);
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

        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "NegativeID",
         DataAccessMethod.Sequential)]
        public void AddingEmployeeDetailsWithNegativeID()
        {
            client.ClearList();
            try
            {
                id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(id,name);
            }
            catch(FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "ID Negative");
            }    
        }

        [TestMethod]
        [DeploymentItem(@"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"D:\Webservice-employee management\Employee-Management-Service\EmployeeManagementService\EmployeeManagementService\EmployeeData.xml",
            "NameSpecialCharacters",
         DataAccessMethod.Sequential)]
        public void AddingEmployeeDetailsWithNameHavingSpecialCharacters()
        {
            client.ClearList();
            try
            {
                id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                name = _testContextInstance.DataRow["Name"].ToString();
                client.CreateNewEmployee(id,name); 
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Name with Special characters");
            }

        }
    }
}
