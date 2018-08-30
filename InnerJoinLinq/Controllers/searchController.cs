using InnerJoinLinq.Models.SearchData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InnerJoinLinq.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {

            List<StudentListModel> studentListModel = StudentDataModel.GetStudentDetail();
            List<StudentTrasactionListModel> studentTrasactionListModel = StudentTransactionDataModel.GetStudentTrsactionDetail();
            List<StudentResult> studentResult = (from studentList in studentListModel
                                                 join studentTrasactionList in studentTrasactionListModel
                                                 on studentList.StudentId equals studentTrasactionList.StudentId
                                                 select new StudentResult
                                                 {
                                                     StudentId = studentList.StudentId,
                                                     StudentName = studentList.StudentName,
                                                     StudentClass = studentList.StudentClass,
                                                     StudentAge = studentList.StudentAge,
                                                     StudentFees = studentTrasactionList.StudentFees,
                                                     TrasactionDate = studentTrasactionList.TrasactionDate
                                                 }
                                                ).ToList();

            StudentViewList studentViewList = new StudentViewList();
            studentViewList.StudentListData = studentResult;
            return View(studentViewList);
        }
        [HttpPost]
        public IActionResult Index(StudentSearchAttribute searchAttributeData)
        {
            Result resultObj = new Result();
            List<StudentResult> studentListData = resultObj.GetResults(searchAttributeData);
            return PartialView("_SingleStudentDetailPartial", studentListData);
        }
       


       
    }
}