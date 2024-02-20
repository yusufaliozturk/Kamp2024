using Kodlamaio.Business.Abstract;
using Kodlamaio.Business.Concrete;
using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.DataAccess.Concrete;
using Kodlamaio.Entities;



CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

InstructorManager instructorManager = new InstructorManager(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

Console.WriteLine("Kategori Adı Kısmı");
for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine("Kurs Kategori adı = " + categories[i].Name);
}

Console.WriteLine("/-/-/-/-/------Bölme------/-/-/-/");
Console.WriteLine("Kurs Adı Kısmı");
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine("Kurs Adı= " + courses[i].CourseName + "--" + "Kurs Kategori Id= " + courses[i].CategoryId); 
}
