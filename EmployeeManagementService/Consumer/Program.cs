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
            RetrieveClient rclient = new RetrieveClient();
            int id, choice = 0;
            String name;
            while (true)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1. Add Employee Record");
                Console.WriteLine("2. Search Employee Details By ID");
                Console.WriteLine("3. Search Employee Details By Name");
                Console.WriteLine("4. Add Remark");
                Console.WriteLine("5. Get the list of all Employees");
                Console.WriteLine("Choose your operation:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("EmployeeID : ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Employee Name : ");
                        name = Console.ReadLine();
                        client.CreateNewEmployee(id, name);
                        break;
                    case 2:
                         Console.WriteLine("Enter the Employee-ID : ");
                        id = int.Parse(Console.ReadLine());
                        var r = rclient.SearchById(id);
                            Console.WriteLine(r.Id);
                             Console.WriteLine(r.Name+"\n");
                        break;
                    case 3:
                        Console.WriteLine("Enter the Employee-Name : ");
                        name = Console.ReadLine();
                         var emp = rclient.SearchByName(name);
                            Console.WriteLine(emp.Id);
                            Console.WriteLine(emp.Name+"\n");
                        break;
                    case 4:
                        Console.WriteLine("Enter the Employee-ID : ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Add the remark");
                        string text = Console.ReadLine();
                        client.AddRemarks(id, text);
                        break;
                    case 5 :
                         var list = rclient.GetAllEmployeeList();
                         foreach (Employee e in list)
                         {
                             Console.WriteLine("Employee Id :"+e.Id);
                             Console.WriteLine("Employee Name :"+e.Name+"\n");
                             if (e.remarkObject != null)
                             {
                                 Console.WriteLine("Remark" + e.remarkObject.Remark);
                                 Console.WriteLine("Date :" + e.remarkObject.Date);
                             }
                         }
                        break;

                }
            }




        }
        
      
     }

    }



           

            
  