using Practice05_03_2024_SearchMethod.Helpers.Responses;
using Practice05_03_2024_SearchMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice05_03_2024_SearchMethod.Services.Interfaces
{
    internal interface IEmployyeeService
    {
        public interface IEmployyeService
        {
            Employyee[] GetAll();

            EmployyeeResponse GetById(Employyee[] employyees, int? id);

            Employyee[] Search(Employyee[] employyees, string searchText);
        }
    }
}
