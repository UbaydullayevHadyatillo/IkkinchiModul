using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_dars.models;

public class Student
{
    public Guid StudentId { get; set; }
    public string FristName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}
