using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workaround.Business.Abstract;
using Workaround.Entities.Concrete;

namespace Workaround.Business.Concrete
{
    public class ForeignerManager : IPersonService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            // burada yabancı kontrolü yapılıcak 
            return false;
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
