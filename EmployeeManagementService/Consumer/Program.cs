using Consumer.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateEmployeeAndAddRemarksClient client = new CreateEmployeeAndAddRemarksClient();
            int id = 1001;
            String name = "Swapnil";
            client.CreateNewEmployee(id,name);

            RetrieveClient rclient = new RetrieveClient();
            var r = rclient.SearchById(1001);
            
        }
    }
}
