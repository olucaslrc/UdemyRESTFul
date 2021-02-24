using System.Collections.Generic;
using RestWithASPNET.Models;

namespace RestWithASPNET.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}