using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public decimal BaseSalary { get; set; }
        public int DepartmentId { get; set; }
    }
}
