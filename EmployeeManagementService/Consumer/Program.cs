using Consumer.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            Employee emp = new Employee();
           do
            {
                Console.WriteLine("1. Add Employee Record");
                Console.WriteLine("2. Search Employee Details By ID");
                Console.WriteLine("3. Search Employee Details By Name");
                Console.WriteLine("4. Add Remark");
                Console.WriteLine("5. Get the list of all Employees");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose your operation:");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("EmployeeID : ");
                            id = int.Parse(Console.ReadLine());
                            if (IsEmployeePresent(id))
                            {
                                Console.WriteLine("Employee Name : ");
                                name = Console.ReadLine();
                                client.CreateNewEmployee(id, name);
                                break;
                            }
                        } while (true);
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
                        emp = rclient.SearchByName(name);
                        Console.WriteLine(emp.Id);
                        Console.WriteLine(emp.Name+"\n");
                        break;
                    case 4:
                        Console.WriteLine("Enter the Employee-ID : ");
                        id = int.Parse(Console.ReadLine());
                        Employee employee = rclient.SearchById(id);
                        //try
                        //{
                        //    Employee employee = rclient.SearchById(id);
                            
                        //    Console.WriteLine("Add the remark");
                        //    string text = Console.ReadLine();
                        //    client.AddRemarks(id, text);
                        //}
                        //catch (FaultException e)
                        //{
                        //     if (e.Code.Name == "101")
                        //      {
                        //        Console.WriteLine("{0}",e.Reason);
                        //      }
                        //}
                        
                        break;
                    case 5 :
                         var list = rclient.GetAllEmployeeList();
                         foreach (Employee e in list)
                         {
                             Console.WriteLine("Employee Id :"+e.Id);
                             Console.WriteLine("Employee Name :"+e.Name);
                             if (e.remarkObject != null)
                             {
                                 Console.WriteLine("Remark :" + e.remarkObject.Remark);
                                 Console.WriteLine("Date :" + e.remarkObject.Date);
                             }
                             Console.WriteLine("\n");
                         }
                        break;

                }
            }while(choice!=0);
        }

        private static bool IsEmployeePresent(int id)
        {
            Employee emp = new Employee();
            RetrieveClient rclient = new RetrieveClient();
            emp=rclient.SearchById(id);
            if (emp != null)
                return true;
            else
                return false;
        }
     }
    }



/*
 *   [TestMethod]
        public void AddRemarkToTheNonExistingEmployee(int id)
        {
            id = 567;
            try
            {
                Employee employee = rclient.SearchById(id);
                client.AddRemarks(employee);
            }
            catch (FaultException fault)
            {
                Assert.AreEqual(fault.Reason, "Enter valid Id");
            }
        }
        
 * */




