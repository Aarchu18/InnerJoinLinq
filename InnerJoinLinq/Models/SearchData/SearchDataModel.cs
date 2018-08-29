using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerJoinLinq.Models.SearchData
{
    public class SearchDataModel
    {
        public static List<SearchListModel> GetStudentDetail()
        {
            return new List<SearchListModel>
            {
                new SearchListModel
                {
                    StudentId=1,
                    StudentName="Archana",
                    StudentAge=6,
                    StudentClass="4th"
                },
                new SearchListModel
                {
                    StudentId=2,
                    StudentName="Hchana",
                    StudentAge=6,
                    StudentClass="4th"
                },
                new SearchListModel
                {StudentId=3,
                    StudentName="Archana",
                    StudentAge=23,
                    StudentClass="10th"
                },
                new SearchListModel
                {
                   StudentId=4,
                    StudentName="Jrchana",
                    StudentAge=2,
                    StudentClass="4th"
                },
                new SearchListModel
                {
                   StudentId=5,
                    StudentName="Rrchana",
                    StudentAge=20,
                    StudentClass="4th"
                }
            };

        }

        public static List< SearchListModel> GetStudentByName(string name)
        {
            List<SearchListModel> searchList = new List<SearchListModel>();

            searchList = (from s in GetStudentDetail()
                          where s.StudentName.ToLower().Contains(name.ToLower())
                          select s).ToList();
            return searchList;
        }
    }
}
