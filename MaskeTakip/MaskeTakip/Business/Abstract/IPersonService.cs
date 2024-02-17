using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workaround.Entities.Concrete;

namespace Workaround.Business.Abstract;

public interface IPersonService
{
    void ApplyForMask(Person person);
    public List<Person> GetAll();
    public bool CheckPerson(Person person);
}
