using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Course course1 =new Course();
        course1._courseCode="CSE 210";
        course1._courseName="Prog with classes";
        course1._creditHours=2;
        course1._color="green";
        course1.Display();        
    }
}