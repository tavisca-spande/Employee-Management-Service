using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementServiceFixture.EmployeeManagementService;
using System.ServiceModel;

namespace EmployeeManagementServiceFixture
{
    [TestClass]
    public class EmployeeMS
    {

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString,
            "AddEmployee",DataAccessMethod.Sequential)]
        public void AddEmployeeWithSameId()
        {
            try
            { 
                _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                _name = _testContextInstance.DataRow["Name"].ToString();
                client.CreateNewEmployee(_id, _name);

                client.CreateNewEmployee(_id, _name);
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
           _id = 100;        
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
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString,
        "AddEmployee",DataAccessMethod.Sequential)]
        public void AddingEmployeeDetails()
        {
            _totalCount = _testContextInstance.DataRow.Table.Rows.Count;
            _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
             _name = _testContextInstance.DataRow["Name"].ToString();
            _currentCount++;
            client.CreateNewEmployee(_id, _name);
            Assert.AreEqual(_currentCount, clientForRetrievingData.GetAllEmployeeList().Length);
        }

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString,
            "AddEmployee",DataAccessMethod.Sequential)]
        public void GettingListOfAllEmployees()
        {     
            _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            _name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(_id,_name);
            var _list = clientForRetrievingData.GetAllEmployeeList();
            Assert.AreEqual(_list.Length, 1);
        }

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString,
            "AddRemarks",DataAccessMethod.Sequential)]
        public void GetEmployeesWithRemarks()
        {
            client.CreateNewEmployee(1001, "abc");
            client.CreateNewEmployee(1002, "xyz");
            _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            string remarkContent = _testContextInstance.DataRow["RemarkContent"].ToString();
            client.AddRemarks(_id,remarkContent);
            var list = clientForRetrievingData.GetAllEmployeesWithRemarks();
            Assert.AreEqual(list.Length, 1);
        }

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString,
         "AddEmployee",DataAccessMethod.Sequential)]
        public void GetNonExistingEmployeeDetails()
        {      
            _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            _name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(_id, _name);
            var emp = clientForRetrievingData.SearchById(102);
            Assert.AreEqual(emp, null);
        }

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", _connectionString,
        "AddEmployee", DataAccessMethod.Sequential)]
        public void GetEmployeeDetailsById()
        {
            _totalCount = _testContextInstance.DataRow.Table.Rows.Count;
            _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            _name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(_id,_name);
            _currentCount++;
            //client.CreateNewEmployee(110, "swapnil");
            var emp = clientForRetrievingData.SearchById(_id);
            Assert.AreEqual(emp.Name,_name);
        }
        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", _connectionString,
        "AddEmployee", DataAccessMethod.Sequential)]
        public void GetEmployeeDetailsByName()
        {
            _totalCount = _testContextInstance.DataRow.Table.Rows.Count;
            _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
            _name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(_id, _name);
            _currentCount++;
            if (_totalCount == _currentCount)
            {
                var emp = clientForRetrievingData.SearchByName("Swapnil");
                Assert.AreEqual(emp.Length, 2);
            }
        }

        [TestMethod]
        public void SearchNonExistingEmployeeByName()
        {
            client.CreateNewEmployee(101, "swapnil");
            client.CreateNewEmployee(110, "swapnil");
            var empList = clientForRetrievingData.SearchByName("swap");
            Assert.AreEqual(empList.Length, 0);
        }

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString,
            "NegativeID",DataAccessMethod.Sequential)]
        public void AddingEmployeeDetailsWithNegativeID()
        {  
            try
            {
                _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                _name = _testContextInstance.DataRow["Name"].ToString();
            client.CreateNewEmployee(_id,_name);
            }
            catch(FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "ID Negative");
            }    
        }

        [TestMethod]
        [DeploymentItem(_connectionString)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",_connectionString, 
            "NameSpecialCharacters",DataAccessMethod.Sequential)]
        public void AddingEmployeeDetailsWithNameHavingSpecialCharacters()
        {    
            try
            {
                _id = Int32.Parse(_testContextInstance.DataRow["Id"].ToString());
                _name = _testContextInstance.DataRow["Name"].ToString();
                client.CreateNewEmployee(_id,_name); 
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Code.Name, "Name with Special characters");
            }

        }
    }
}
