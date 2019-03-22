using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAFiddes
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Credits { get; set; }
        public string EmergencyPhoneNumber { get; set; }

        public Student(int studentid,
            string name, double credits,
            string emergencyphonenumber)
        {
            StudentID = studentid;
            Name = name;
            Credits = Credits;
            EmergencyPhoneNumber = emergencyphonenumber;
        }
    }
}