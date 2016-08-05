using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class StudentContainer
    {
        private List<Student> StudentList = new List<Student>();

        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }

        public List<Student> SortStudents()
        {
            StudentList = StudentList.OrderBy(students => students.Surname).ToList();
            return StudentList;
        }

        public Student RetriveStudent(int number)
        {
            number = number - 1;
            return StudentList[number];
        }
    }
}
