using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAllList();
        IDataResult<List<Person>> Favorites();

        IDataResult<List<Person>> Blockeds();
        IDataResult<Person> GetbyName(string name);
        IDataResult<Person> GetbyPhoneNumber(string number);
        IDataResult<Person> GetbyPhoto(string photoPath);
        IResult Update(Person person);
        IResult Add(Person person);
        IResult Delete(int id);
    }
}
