using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJoinLinq.Models.SearchData
{
    public class StudentDataModel
    {
        public static List<StudentListModel> GetStudentDetail()
        {
            return new List<StudentListModel>
            {
                new StudentListModel
                {
                    StudentId=1,
                    StudentName="Archana",
                    StudentAge=6,
                    StudentClass="4th"
                },
                new StudentListModel
                {
                    StudentId=2,
                    StudentName="Hchana",
                    StudentAge=6,
                    StudentClass="4th"
                },
                new StudentListModel
                {StudentId=3,
                    StudentName="Archana",
                    StudentAge=23,
                    StudentClass="10th"
                },
                new StudentListModel
                {
                   StudentId=4,
                    StudentName="Jrchana",
                    StudentAge=2,
                    StudentClass="4th"
                },
                new StudentListModel
                {
                   StudentId=5,
                    StudentName="Rrchana",
                    StudentAge=20,
                    StudentClass="4th"
                }
            };

        }

        public static List< StudentListModel> GetStudentByName(string name)
        {
            List<StudentListModel> searchList = new List<StudentListModel>();

            searchList = (from s in GetStudentDetail()
                          where s.StudentName.ToLower().Contains(name.ToLower())
                          select s).ToList();
            return searchList;
        }
    }
}
