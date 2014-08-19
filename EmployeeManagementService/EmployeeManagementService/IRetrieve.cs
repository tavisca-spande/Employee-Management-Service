using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace EmployeeManagementService
{
    [ServiceContract]
    public interface IRetrieve
    {
        [OperationContract]
        List<Employee> GetAllEmployeeList();
        [OperationContract(Name = "SearchByName")]
        List<Employee> GetEmployeeDetails(String Name);

        [OperationContract(Name = "SearchById")]
        Employee GetEmployeeDetails(int Id);
        [OperationContract]
        List<Employee> GetAllEmployeesWithRemarks();
    }
}
