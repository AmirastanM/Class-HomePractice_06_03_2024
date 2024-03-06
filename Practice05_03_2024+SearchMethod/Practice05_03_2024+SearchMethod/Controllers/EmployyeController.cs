
using Practice05_03_2024_SearchMethod.Helpers.Responses;
using Practice05_03_2024_SearchMethod.Models;
using Practice05_03_2024_SearchMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice05_03_2024_SearchMethod.Services.Interfaces.IEmployyeeService;

namespace Practice05_03_2024_SearchMethod.Controllers
{
    public class EmployyeController
    {
        private readonly IEmployyeService _employyeService;

        public EmployyeController()
        {
            _employyeService = new EmployyeeService();
        }

        public void GetAll()
        {
            var employyees = _employyeService.GetAll();
            foreach (var employee in employyees)
            {
                string result = $"{employee.Name} {employee.Surname}" +
                    $" {employee.Address} {employee.Email} {employee.Age} " +
                    $"{employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
        }

        public void GetById()
        {
            int? id = 3;
            var response = _employyeService.GetById(_employyeService.GetAll(), id);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employyee.Name} {response.Employyee.Surname}" +
                $" {response.Employyee.Address} {response.Employyee.Email} {response.Employyee.Age} " +
                    $"{response.Employyee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }

        }

        public void Search()
        {
            Console.WriteLine("Add search text:");
            string searchText = Console.ReadLine();

            var response = _employyeService.Search(_employyeService.GetAll(), searchText);

            if (response.Length == 0)
            {
                Console.WriteLine("Notfound");
                return;
            }
            else
            {
                foreach (var employee in response)
                {
                    string result = $"{employee.Name} {employee.Surname}" +
                        $" {employee.Address} {employee.Email} {employee.Age} " +
                        $"{employee.Birthday.ToString("MM-dd-yyyy")}";
                    Console.WriteLine(result);
                }

            }



        }
    }
}
