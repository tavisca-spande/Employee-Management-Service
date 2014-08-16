using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class CreateEmployee : ICreateEmployeeAndAddRemarks,IRetrieve
    {
        public List<Employee> employeeList= new List<Employee>();
        
        public void CreateNewEmployee(int id,string name)
        {
            Employee emp = new Employee() { Id = id, Name = name };
            AddEmployee(emp);
        }
        public void AddRemarks(Employee emp)
        {
            emp.remarkObject.Date = DateTime.Now;
            emp.remarkObject.Remark = "Adding remark here";
        }

        public List<Employee> GetAllEmployeeList()
        {
            return employeeList;
        }

        public Employee GetEmployeeDetails(string Name)
        {
            return employeeList.Find(x => x.Name == Name);
        }

        public Employee GetEmployeeDetails(int id)
        {
             return employeeList.Find(x => x.Id ==id );
        }
        public void AddEmployee(Employee emp)
        {
            employeeList.Add(emp);
        }
    }
}



