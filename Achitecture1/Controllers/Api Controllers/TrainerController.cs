using MyDatabase;
using PersistanceGeneric.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Achitecture1.Controllers.Api_Controllers
{
    public class TrainerController : ApiController
    {
        private ApplicationDbContext db;
        private TrainerRepository trainerService;
        public TrainerController()
        {
            db =new ApplicationDbContext();
            trainerService = new TrainerRepository(db);
        }
        public IHttpActionResult GetTrainers()
        {
            var trainers = trainerService.GetAll()
                 .Select(p => new {
                     p.Name
                 });
            return Json(trainers);
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
