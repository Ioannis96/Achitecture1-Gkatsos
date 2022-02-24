using MyDatabase;
using PersistanceGeneric.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Achitecture1.Controllers.Api_Controllers
{
    public class CourseController : ApiController
    {
        private ApplicationDbContext db;
        private CourseRepository courseService;
        public CourseController()
        {
            db = new ApplicationDbContext();
            courseService = new CourseRepository(db);
        }
        // GET: api/Projects
        public IHttpActionResult GetCourses()
        {
            var courses = courseService.GetAll();

            return Json(courses);
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