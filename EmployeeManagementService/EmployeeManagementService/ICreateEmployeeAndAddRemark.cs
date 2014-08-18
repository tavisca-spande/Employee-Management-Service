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
    public interface ICreateEmployeeAndAddRemarks
    {
        [OperationContract]
        void CreateNewEmployee(int id,String name);
        [OperationContract]
        void AddRemarks(int id);
        [OperationContract]
        void ClearList();
    }
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set;}
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Remark { get; set; }
    }
    


}
