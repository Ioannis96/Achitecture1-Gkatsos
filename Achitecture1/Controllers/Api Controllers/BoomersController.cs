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

namespace Achitecture1.Controllers.Api_Controllers
{
    public class BoomersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Boomers
        public IQueryable<Boomer> GetBoomers()
        {
            return db.Boomers;
        }

        // GET: api/Boomers/5
        [ResponseType(typeof(Boomer))]
        public IHttpActionResult GetBoomer(int id)
        {
            Boomer boomer = db.Boomers.Find(id);
            if (boomer == null)
            {
                return NotFound();
            }

            return Ok(boomer);
        }

        // PUT: api/Boomers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBoomer(int id, Boomer boomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != boomer.BoomerId)
            {
                return BadRequest();
            }

            db.Entry(boomer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Boomers
        [ResponseType(typeof(Boomer))]
        public IHttpActionResult PostBoomer(Boomer boomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Boomers.Add(boomer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = boomer.BoomerId }, boomer);
        }

        // DELETE: api/Boomers/5
        [ResponseType(typeof(Boomer))]
        public IHttpActionResult DeleteBoomer(int id)
        {
            Boomer boomer = db.Boomers.Find(id);
            if (boomer == null)
            {
                return NotFound();
            }

            db.Boomers.Remove(boomer);
            db.SaveChanges();

            return Ok(boomer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BoomerExists(int id)
        {
            return db.Boomers.Count(e => e.BoomerId == id) > 0;
        }
    }
}