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
                if (employeeList.Exists(x => x.Id == id))
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

        public void AddRemarks(Employee emp)
        {
            if (emp != null)
            {
                emp.remarkObject = new Remarks();
                emp.remarkObject.Date = DateTime.Now;
                emp.remarkObject.Remark = "added a remark";
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
            return employeeList.Find(x => x.Name == Name);
        }

        public Employee GetEmployeeDetails(int id)
        {
             return employeeList.Find(x => x.Id ==id );
        }
       
    }
}



