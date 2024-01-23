using BasicsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model.DTOs
{
    public class ReqEmployeeDTO
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
    }
}
