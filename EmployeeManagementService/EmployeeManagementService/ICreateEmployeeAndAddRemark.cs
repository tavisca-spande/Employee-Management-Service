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
    }
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set;}
        [DataMember]
        public Remark remarkObject;
    }

     [DataContract]
    public class Remark
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
          git config --global user.name "Your Name"

          [OperationContract(Name = "SearchById")]
        Employee GetEmployeeDetails(int Id);
        public string RemarkContent { get; set; }
    }


}
