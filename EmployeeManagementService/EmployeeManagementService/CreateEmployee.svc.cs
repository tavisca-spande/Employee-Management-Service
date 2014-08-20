using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
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
                    emp.remarkObject = new Remark();
                    employeeList.Add(emp);
                }
            }
            catch (FaultException)
            {
                throw new FaultException(new FaultReason("Given Id already exists!!!"), new FaultCode("Duplicate Id"));
            }
        }

        public void AddRemarks(int id,String text)
        {

            try
            {
                var emp = GetEmployeeDetails(id);
                if (emp != null)
                {
                    if (emp.remarkObject == null)
                    {
                        emp.remarkObject.Date = DateTime.Now;
                        emp.remarkObject.RemarkContent = text;
                    }
                    else
                    {
                        emp.remarkObject.RemarkContent += " " + text;
                        emp.remarkObject.Date = DateTime.Now;
                    }
                }
            }
            catch (FaultException f)
            {
                throw new FaultException(new FaultReason("Given Id already exists!!!"), new FaultCode("Duplicate Id"));         
            }
            

        }

        public List<Employee> GetAllEmployeeList()
        {
            return employeeList;
        }

        public List<Employee> GetEmployeeDetails(string Name)
        {
            return employeeList.FindAll(emp => emp.Name == Name);
        }

        public Employee GetEmployeeDetails(int id)
        {
             return employeeList.Find(emp => emp.Id ==id);
        }

        public void ClearEmployeeList()
        {
            employeeList.Clear();
        }

        public List<Employee> GetAllEmployeesWithRemarks()
        {
            List<Employee> _temp = new List<Employee>();
            foreach (var emp in employeeList)
            {
                if (emp.remarkObject.RemarkContent != null)
                    _temp.Add(emp);
            }
            return _temp;
        }
    }
}



