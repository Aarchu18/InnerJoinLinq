using System.Collections.Generic;

namespace InnerJoinLinq.Models.SearchData
{
    public static class StudentTransactionDataModel
    {
        public static List<StudentTrasactionListModel> GetStudentTrsactionDetail()
        {
            return new List<StudentTrasactionListModel>
            {
                new StudentTrasactionListModel
                {
                    StudentId=1,
                    StudentFees=4000,
                    TrasactionDate="02/03/2013"
                },
                new StudentTrasactionListModel
                {
                    StudentId=2,
                    StudentFees=5000,
                    TrasactionDate="04/03/2013"
                },
                new StudentTrasactionListModel
                {
                    StudentId =3,
                    StudentFees=1000,
                    TrasactionDate="02/03/2014"
                },
                new StudentTrasactionListModel
                {
                    StudentId=4,
                    StudentFees=4000,
                    TrasactionDate="10/03/2018"
                },
                new StudentTrasactionListModel
                {
                    StudentId=5,
                    StudentFees=7000,
                    TrasactionDate="02/09/2009"
                },
                new StudentTrasactionListModel
                {
                    StudentId=6,
                    StudentFees=10000,
                    TrasactionDate="02/03/2014"
                },
                new StudentTrasactionListModel
                {
                    StudentId=7,
                    StudentFees=7000,
                    TrasactionDate="02/03/2002"
                },
                new StudentTrasactionListModel
                {
                     StudentId=8,
                     StudentFees=9000,
                     TrasactionDate="02/03/2004"
                },
                new StudentTrasactionListModel
                {
                     StudentId=9,
                     StudentFees=8000,
                     TrasactionDate="02/03/2005"
                },
                new StudentTrasactionListModel
                {
                     StudentId=10,
                     StudentFees=2600,
                     TrasactionDate="02/03/2017"
                },
            };

        }

       
    }
}
