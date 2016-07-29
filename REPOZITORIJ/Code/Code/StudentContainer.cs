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

        public int SortStudents()
        {
            StudentList = StudentList.OrderBy(students => students.Surname).ToList();

            StudentIdGenerator generator = StudentIdGenerator.Making();

            foreach (Student graduate in StudentList)
            {
                graduate.Id = generator.Id();
            }

            return StudentList.Count();
        }

        public Student RetriveStudent(int number)
        {
            number = number - 1;
            return StudentList[number];
        }
    }
}
