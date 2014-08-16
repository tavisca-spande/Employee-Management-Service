using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
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

        public void AddRemarks(int id, string remarkcontent)
        {
            if (employeeList.Exists(x => x.Id == id))
            { 
                Employee e = GetEmployeeDetails(id);
                e.remarkObject = new Remarks();
                e.remarkObject.Date = DateTime.Now;
                e.remarkObject.Remark = remarkcontent;
            }
            else
            {
                   throw FaultException.CreateFault(
                    MessageFault.CreateFault(
                        new FaultCode("101"), "Employee Not in the Database"));
            }
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



