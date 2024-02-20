using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete
{
    internal class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Ali";
            instructor1.LastName = "Babayiğit";
            instructor1.Email = "ali@kodlama.io";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Veli";
            instructor2.LastName = "Aslan";
            instructor2.Email = "veli@kodlama.io";

            _instructors = new List<Instructor> { instructor1, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Remove(Instructor instructor)
        {
            Instructor instructorToRemove = _instructors.SingleOrDefault(i=> i.Id == instructor.Id);
            if (instructorToRemove != null)
            {
                _instructors.Remove(instructorToRemove);
            }
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.SingleOrDefault(i=> i.Id == instructor.Id);
            if(instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
            }
        }
    }
}
