using System.Collections.Generic;

namespace InnerJoinLinq.Models.SearchData
{
    public class StudentTransactionModel
    {
        public static List<SearchTrasactionModel> GetStudentTrsactionDetail()
        {
            return new List<SearchTrasactionModel>
            {
                new SearchTrasactionModel
                {
                    StudentId=1,
                   StudentFees=400,
                    Date="2/3/3"
                },
                new SearchTrasactionModel
                {
                    StudentId=2,
                    StudentFees=400,
                    Date="2/3/3"
                },
                new SearchTrasactionModel
                {StudentId=3,
                     StudentFees=400,
                    Date="2/3/3"
                },
                new SearchTrasactionModel
                {
                   StudentId=4,
                     StudentFees=400,
                    Date="2/3/3"
                },
                new SearchTrasactionModel
                {
                   StudentId=5,
                    StudentFees=400,
                    Date="2/3/3"
                }
            };

        }

        //public static List<SearchTrasactionModel> GetStudentByOrder(int id)
        //{
        //    List<SearchTrasactionModel> searchList = new List<SearchTrasactionModel>();
        //    //var query = from order in workOrders
        //    //            join plan in plans
        //    //                 on order.WorkOrderNumber equals plan.WorkOrderNumber
        //    //            select new
        //    //            {
        //    //                order.WorkOrderNumber,
        //    //                order.Description,
        //    //                plan.ScheduledDate
        //    //            };
        //    searchList = (from s in SearchDataModel
        //                  join p in SearchTransactionModel on s.StudentId equals p.StudentId
        //                  select new
        //                  {
        //                      s.StudentId,
        //                      s.StudentName,
        //                      s.StudentFees,
        //                      s.Date
        //                  });

        //    //searchList = (from s in GetStudentDetail()
        //    //              where s.StudentName.ToLower().Contains(name.ToLower())
        //    //              select s).ToList();
        //    return searchList;
        //    // var result = (from sl in SearchListModel join sf in StudentFee on sl.StudentID equals sf.StudentID orderby sl.StudentID select new { sl.StudentID, sl.StudentName, sf.Fee }).ToList();
        //}
    }
}
