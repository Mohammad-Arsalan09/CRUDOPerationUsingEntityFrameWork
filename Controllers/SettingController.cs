using Microsoft.AspNetCore.Mvc;
using MohaliAssignment.Models;
using MohaliAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MohaliAssignment.Controllers
{
    public class SettingController : Controller
    {
        private readonly SettingContext context;

        public SettingController(SettingContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {

            return View(context.Setting.ToList());
        }

        public IActionResult Create(Settings formdata)
        {
            context.Setting.Add(formdata);
            context.SaveChanges();
            return RedirectToAction("Read");
        }

        public IActionResult Read()
        {
            return View(context.Setting.ToList());
        }

        public IActionResult Details(int id)
        {


            Settings obj = context.Setting.Where(item => item.Id == id).FirstOrDefault();

            return View(obj);
        }
        public IActionResult Delete(int Id)
        {
            Settings Obj1 = context.Setting.Where(item => item.Id == Id).FirstOrDefault();
            context.Setting.Remove(Obj1);
            return RedirectToAction("Read");
        }
        public IActionResult Edit(int id)
        {
            Settings obj2 = context.Setting.Find(id);

            return View(obj2);
        }

        public IActionResult Update(Settings formdata)
        {
            Settings obj3 = context.Setting.Find(formdata.Id);
            obj3.Key = formdata.Key;
            obj3.Value = formdata.Value;
            obj3.Value2 = formdata.Value2;
            obj3.Description = formdata.Description;
            obj3.Created = formdata.Created;
            obj3.LastModified = formdata.LastModified;
            obj3.IsDeleted = formdata.IsDeleted;

            context.SaveChanges();
            return RedirectToAction("Read");
        }
    }
}
