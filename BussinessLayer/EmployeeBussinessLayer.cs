using EmployeeDb.Models;
using EmployeeDb.RepositaryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDb.BussinessLayer
{
    public class EmployeeBussinessLayer
    {

        public List<EmployeeModel> GetEmployeedata()
        {
            EmployeeRepositaryLayer employeeRepositaryLayer = new EmployeeRepositaryLayer();
            return employeeRepositaryLayer.GetEmployeeData();
        }
        public  string SaveEmployeeData(EmployeeModel employee)
        {

            EmployeeRepositaryLayer employeeRepositaryLayer = new EmployeeRepositaryLayer();

            return employeeRepositaryLayer.SaveEmployeeData(employee);
        }

        public string UpdateEmployeeData(EmployeeModel employee)
        {
            EmployeeRepositaryLayer employeeRepositaryLayer = new EmployeeRepositaryLayer();

            return employeeRepositaryLayer.UpdateEmployeeData(employee);
        }

        public  string DeleteEmployeeData(int Id)
        {

            EmployeeRepositaryLayer employeeRepositaryLayer = new EmployeeRepositaryLayer();

            return employeeRepositaryLayer.DeleteEmployeeData(Id);

        }

    }

}
