using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_management
{
    public interface IRoom
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
    }
}
