using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workaround.Business.Abstract;
using Workaround.Entities.Concrete;

namespace Workaround.Business.Concrete
{
    public class PttManager : ISupplierService
    {

        private IPersonService _personService;
       

        // constructor new yapıldığında çalışır.
        public PttManager(IPersonService personService)
        {
            _personService = personService;
        }

        // PTT maskeyi dağıtan kuruluş GiveMask kullan

        public void GiveMask(Person person)
        {
            if (_personService.CheckPerson(person) == true)
            {
                Console.WriteLine("Mask was given to " + person.FirstName + " " + person.LastName);
            }
            else { Console.WriteLine("Mask could not be given "); }

        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
