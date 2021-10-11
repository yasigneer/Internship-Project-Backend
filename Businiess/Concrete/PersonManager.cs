using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private readonly IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IDataResult<List<Person>> GetAllList()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAlList(p=>p.Block==false || p.Block == null));
        }

        public IDataResult<List<Person>> Favorites()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAlList(x => x.Favorite == true));
        }
        public IDataResult<List<Person>> Blockeds()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAlList(x => x.Block == true));
        }

        public IDataResult<Person> GetbyName(string name)
        {
            return new SuccessDataResult<Person>(_personDal.Get(x => x.FirstName == name || x.LastName == name));
        }

        public IDataResult<Person> GetbyPhoneNumber(string number)
        {
            return new SuccessDataResult<Person>(_personDal.Get(x => x.PhoneNumber == number));
        }

        public IDataResult<Person> GetbyPhoto(string photoPath)
        {
            return new SuccessDataResult<Person>(_personDal.Get(x => x.PhotoPath == photoPath));
        }

        public IResult Update(Person person)
        {
            Person updated = new Person();
            updated = _personDal.Get(p => p.Id == person.Id);
            updated = person;
            _personDal.Update(updated);
            return new SuccessResult(Messages.PersonUpdated);
        }

        public IResult Add(Person person)
        {

            _personDal.Add(person);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Delete(int id)
        {
            Person deleted = new Person();
            deleted = _personDal.Get(p => p.Id == id);
            _personDal.Delete(deleted);
            return new SuccessResult(Messages.PersonDeleted);
        }
    }
}
