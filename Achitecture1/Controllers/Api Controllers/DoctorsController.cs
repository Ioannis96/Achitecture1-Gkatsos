using MyDatabase;
using PersistanceGeneric.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Achitecture1.Controllers.Api_Controllers
{
    public class DoctorsController : ApiController
    {
        private ApplicationDbContext db;
        private DoctorRepository doctorService;

        public DoctorsController()
        {
            db = new ApplicationDbContext();
            doctorService = new DoctorRepository(db);
        }

        public IHttpActionResult GetDoctor()
        {
            var doctors = doctorService.GetAll()
                 .Select(d => new
                 {
                     d.FirstName,
                     d.LastName,
                     d.Age
                 });
            return Json(doctors);
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