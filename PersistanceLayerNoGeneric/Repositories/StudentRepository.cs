using Entities.School;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceLayerNoGeneric.Repositories
{
    public class StudentRepository
    {
        protected readonly ApplicationDbContext Context;

        public StudentRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return Context.Students.ToList();
        }

        public Student Get(int id)
        {
            var student = Context.Students.Find(id);
            return student;
        }

        public IEnumerable<Student> Find(Expression<Func<Student, bool>> predicate)
        {
            return Context.Students.Where(predicate);
        }

        public Student SingleOrDefault(Expression<Func<Student,bool>> predicate)
        {
            return Context.Students.SingleOrDefault(predicate);
        }

        public IEnumerable<IGrouping<ICollection<Project>,Student>> GetByProjectTitle()
        {
            var students = from st in Context.Students
                           group st by st.Projects into g
                           select g;

            return students.ToList();
        }

        public void Add(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();            
        }

        public void AddRange(IEnumerable<Student> students)
        {
            Context.Students.AddRange(students);
            Context.SaveChanges();
        }

        public void Remove(Student student)
        {
            Context.Students.Remove(student);
            Context.SaveChanges();
        }
        public void Remove(int id)
        {
            var stu = Context.Students.Find(id);
            if(stu == null)
            {
                throw new ArgumentException("Student does not exist");
            }

            Context.Students.Remove(stu);
            Context.SaveChanges();
        }

        public void Edit(Student student)
        {
            var stu = Context.Students.Find(student.StudentId);
            if (stu == null)
            {
                throw new ArgumentException("Student does not exist");
            }

            Context.Entry(stu).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void AssignProjectToStudent(Project project,Student student)
        {
            throw new NotImplementedException("O mpampis tha tin ftiaksei opou nanai");
        }



    }
}
