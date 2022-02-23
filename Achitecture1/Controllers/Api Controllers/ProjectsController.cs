using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Entities.School;
using MyDatabase;
using PersistanceLayerNoGeneric.Repositories;
using Microsoft.AspNet.Identity;

namespace Achitecture1.Controllers.Api_Controllers
{
    public class ProjectsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ProjectRepository projectService;

        public ProjectsController()
        {
            db = new ApplicationDbContext();
            projectService = new ProjectRepository(db);
        }

        // GET: api/Projects
        public IHttpActionResult GetProjects()
        {
            var projects = projectService.GetAll()
                 .Select(p => new {
                    p.Title,
                    StudentName = p.Student.Name
                 });    
            return Json(projects);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}