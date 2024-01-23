using AutoMapper;
using BasicsAPI.Models;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicsAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public DataController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<DataController>
        [HttpGet("Employee/GetAll")]
        [ProducesResponseType(typeof(List<ReqEmployeeDTO>), 200)]
        public IActionResult Get()
        {
            var employees = _context.Employees.ToList();
            var newEmployees = _mapper.Map<List<ReqEmployeeDTO>>(employees);

            return Ok(newEmployees);
        }




        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }



        // PUT api/<DataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            var employeeUpDate = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employeeUpDate == null || id == 0 )
            {

            }
            else {
            employeeUpDate.Name = employee.Name;
            employeeUpDate.Address = employee.Address;
            _context.SaveChanges();
            }
        }

        // DELETE api/<DataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var employeeToDelete = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
            }
        }
    }
}
