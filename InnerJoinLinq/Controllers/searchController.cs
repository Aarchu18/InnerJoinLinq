using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnerJoinLinq.Models.SearchData;
using Microsoft.AspNetCore.Mvc;

namespace InnerJoinLinq.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            var model = SearchDataModel.GetStudentDetail();
            return View(model);
        }
        public IActionResult SearchByName(StudentModel studentName)
        {
            if (studentName.name != null)
            {
                var model = SearchDataModel.GetStudentByName(studentName.name);
                if (model != null)
                {
                    return PartialView("_SingleStudentDetailPartial", model);
                }
            }

            return NotFound();
        }

        //public IActionResult Trsaction()
        //{
        //    var t = SearchTrasactionModel.GetStudentTrsactionDetail();
        //    return View(t);
        //}
        //public IActionResult SearchByOrder(int id)
        //{
        //    var o = SearchTrasactionModel.GetStudentByOrder(int id);
        //    if (model != null)
        //    {
        //        return PartialView("_SingleStudentDetailPartial", o);
        //    }
        //}
    }
}