using EmployeeDb.BussinessLayer;
using EmployeeDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeDb.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/EmployeeDb")]
        public List<EmployeeModel> GetEmployeedata()
        {
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            return employeeBussinessLayer.GetEmployeedata();

        }
        [HttpPost]
        [Route("api/SaveEmployeeDb")]

        public string SaveEmployeeData(EmployeeModel employee)
        {
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            return employeeBussinessLayer.SaveEmployeeData(employee);

        }
        [HttpPut]
        [Route("api/UpdateEmployeeDb")]

        public string UpdateEmployeeData(EmployeeModel employee)
        {
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            return employeeBussinessLayer.UpdateEmployeeData(employee);
        }

        [HttpDelete]
        [Route("api/DeleteEmployeeDb")]
        public string DeleteEmployeeData(int Id)
        {
            EmployeeBussinessLayer employeeBussinessLayer = new EmployeeBussinessLayer();
            return employeeBussinessLayer.DeleteEmployeeData(Id);

        }




    }
}
