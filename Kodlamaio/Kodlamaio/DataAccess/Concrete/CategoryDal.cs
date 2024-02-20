using Kodlamaio.DataAccess.Abstract;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public CategoryDal()
        {
            Category category1= new Category();
            category1.Id = 1;
            category1.Name = "Yazılım-Backend";

            Category category2= new Category();
            category2.Id = 2;
            category2.Name = "Tasarım";

            Category category3= new Category();
            category3.Id = 3;
            category3.Name = "Yazılım-Frontend";


            _categories = new List<Category> { category1, category2, category3 };

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Remove(Category category)
        {
            Category removeToCategory = _categories.SingleOrDefault( c => category.Id == category.Id ); // Linq kullanımı
            if ( removeToCategory != null )
            {
                _categories.Remove( removeToCategory );
            }
        }

        public void Update(Category category)
        {
            Category updateToCategory = _categories.SingleOrDefault(c => category.Id == category.Id );
            if ( updateToCategory != null )
            {
                updateToCategory.Name = category.Name;
            }
        }
    }
}
