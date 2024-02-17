using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];

    public CourseManager(EfCourseDal efCourseDal)
    {
        EfCourseDal = efCourseDal;
    }

    public EfCourseDal EfCourseDal { get; }

    public Course[] GetAll()
    {
        //veri kaynağından gelecektir.
        return courses;
    }
}
