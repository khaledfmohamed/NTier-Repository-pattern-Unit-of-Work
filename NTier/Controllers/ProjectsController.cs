using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NTierBLL.IBLL;
using Unity;

using NTierModel;

namespace NTier.Controllers
{
    public class ProjectsController : Controller
    {

       
        
       
        
        
        public IBussinseContext BussinseContext { get; set; }
        // GET: Projects

        public ProjectsController()
        {
           
            BussinseContext = UnityConfig.Container.Resolve<IBussinseContext>();

        }

        public ActionResult Index()
        {
           
           return View(BussinseContext.Project.GetAll());
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            

            Project project = BussinseContext.Project.Search("").First();
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            //ViewBag.ScrumTeamId = new SelectList(BussinseContext.ScrumTeam.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,StartString,ReleaseCount,Description,Notes,ScrumTeamId,IterationTimeBox")] Project project)
        {
            if (ModelState.IsValid)
            {
              //  UnitOfWork.Project.Add(project);
                //UnitOfWork.Complete();
                return RedirectToAction("Index");
            }

        //    ViewBag.ScrumTeamId = new SelectList(UnitOfWork.ScrumTeam.GetAll(), "Id", "Name", project.ScrumTeamId);
            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            /*  if (id == null)
              {
                  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
              }
             Project project = UnitOfWork.Project.Find(p=> p.Id == id.Value).First();
              if (project == null)
              {
                  return HttpNotFound();
              }
           ViewBag.ScrumTeamId = new SelectList(UnitOfWork.ScrumTeam.GetAll(), "Id", "Name", project.ScrumTeamId);
              return View(project); */
            return null;
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Start,ReleaseCount,Description,Notes,ScrumTeamId,IterationTimeBox")] Project project)
        {
            /* if (ModelState.IsValid)
             {
                 UnitOfWork.Project.Update( project);
                 UnitOfWork.Complete();
                 return RedirectToAction("Index");
             }
             ViewBag.ScrumTeamId = new SelectList(UnitOfWork.ScrumTeam.GetAll(), "Id", "Name", project.ScrumTeamId);
             return View(project);*/
            return null;
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            /*  if (id == null)
              {
                  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
              }
              Project project = UnitOfWork.Project.Find(p=> p.Id == id.Value).First();
              if (project == null)
              {
                  return HttpNotFound();
              }
              return View(project);
              */
            return null;
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Project project;
            project = BussinseContext.Project.Delete(id);
            if (ViewBag.MessagesList != null)
                return View(project);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                BussinseContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
