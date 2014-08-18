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
            try
            {
                if (employeeList.Exists(emp => emp.Id == id))
                {
                    throw new FaultException();
                }
                else
                {
                    Employee emp = new Employee() { Id = id, Name = name };
                    employeeList.Add(emp);
                }
            }
            catch (FaultException)
            {
                throw new FaultException(new FaultReason("Given Id already exists!!!"), new FaultCode("Duplicate Id"));
            }
        }

        public void AddRemarks(int id)
        {
            var emp = employeeList.FirstOrDefault(e => e.Id.Equals(id));
            if (emp != null)
            {
                employeeList.Where(employee => employee.Id == id).First().Remark = "some remark";
                employeeList.Where(employee => employee.Id == id).First().Date = DateTime.Now;
            }
            else
            {
                throw FaultException.CreateFault(
                      MessageFault.CreateFault(
                           new FaultCode("Valid Input"), "Enter valid ID"));
            }
        }

        public List<Employee> GetAllEmployeeList()
        {
            return employeeList;
        }

        public Employee GetEmployeeDetails(string Name)
        {
            return employeeList.Find(emp => emp.Name == Name);
        }

        public Employee GetEmployeeDetails(int id)
        {
             return employeeList.Find(emp => emp.Id ==id );
        }

        public void ClearList()
        {
            employeeList.Clear();
        }

        public List<Employee> GetAllEmployeesWithRemarks()
        {
            List<Employee> _temp = new List<Employee>();
            foreach (var emp in employeeList)
            {
                if (emp.Remark != null)
                    _temp.Add(emp);
            }
            return _temp;
        }
       
    }
}



