using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddUpdateDeleteApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Person.BLL.Contract;
using Person.DatabaseContext.DatabaseContext;
using Person.Models.EntityModels;

namespace AddUpdateDeleteApp.Controllers
{
    public class PersonageController : Controller
    {
        private IPersonageManager _personageManager;

        public PersonageController(IPersonageManager personageManager)
        {
            _personageManager = personageManager;
        }
        public IActionResult PersonageCreate()
        {
            ViewBag.Persons = new SelectList(_personageManager.GetAll());

            return View();
        }
        [HttpPost]
        public IActionResult PersonageCreate(Personage personage)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool isSaved = _personageManager.Add(personage);
                    if (isSaved)
                    {
                        ViewBag.Message = "Personage Saved Successfully";
                    }
                    else
                    {
                        ViewBag.Message = "Personage Saved Failled";
                    }
                }
                catch (Exception e)
                {

                    ViewBag.PersonageExistMessage = e.Message;
                }
               
            }
            return View();
        }

        public IActionResult PersonageList()
        {
            var personage = _personageManager.GetAll();
            return View(personage);
        }
        public IActionResult PersonageDataTable()
        {
            var personage = _personageManager.GetAll();
            return Json(personage);
        }

        //public IActionResult PersonagePartial()
        //{
        //    var persons = _personageManager.GetAll();
        //    if (persons != null)
        //    {
        //        return PartialView("_PersonageDetailListPartial", persons);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public IActionResult PersonageEdit(int id)
        {
            Personage person = _personageManager.GetInfoBy(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult PersonageEdit(Personage personage)
        {

            if (ModelState.IsValid)
            {
                /*bool IsUpdated =*/ _personageManager.Update(personage);
                //if (IsUpdated)
                //{
                //    ViewBag.Message = "Personage Updated Successfuly";
                //}
                ////else
                //{
                //    ViewBag.Message = "Personage Update Failled";
                //}
            }


            return RedirectToRoute("ListRoute");
        }

       
        public IActionResult PersonageRemove(int id)
        {
            Personage person = _personageManager.GetInfoBy(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult PersonageRemove(Personage personage)
        {

            //if (ModelState.IsValid)
            //{
            /*bool isRemoved =*/ _personageManager.Remove(personage);
            //    if (isRemoved)
            //    {
            //        ViewBag.Message = "Personage Removed Successfylly";
            //    }
            //    else
            //    {
            //        ViewBag.Message = "Personage Remove Failled";
            //    }
            //}
            //return View();
            return RedirectToRoute("ListRoute");
        }


        public IActionResult PersonageInfo(int id)
        {
            Personage person = _personageManager.GetInfoBy(id);
            return View(person);
        }


    }
}