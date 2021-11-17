using System;

namespace HW10.StudentAndTeacher
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}