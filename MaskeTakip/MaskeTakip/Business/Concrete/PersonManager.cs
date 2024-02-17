using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workaround.Business.Abstract;
using Workaround.Entities.Concrete;

namespace Workaround.Business.Concrete;

public class PersonManager : IPersonService
{
    public void ApplyForMask(Person person)
    {
        person.DateOfBirthYear = "2000";
    }

    public bool CheckPerson(Person person)
    {
        if (person.DateOfBirthYear == "2000" &&
               person.FirstName == "Ahmet" &&
               person.LastName == "Fidan" &&
               person.NationalIdentity == "1245789" &&
               person.Id == 1)
        {
            return true;
        }

        return false;
    }

    public List<Person> GetAll()
    {
        return null;
    }
}


