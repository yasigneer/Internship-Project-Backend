using System;
using System.Linq;
using Entities.Concrete;
using System.Linq.Expressions;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager(new PersonDal());
            Person person = new Person();
            //foreach (var item in personManager.GetAllList().Data)
            //{
            //    Console.WriteLine(item.FirstName+" "+item.LastName);

            //}
            person.Id = 23;
            person.FirstName = "updated";
            personManager.Update(person);
            Console.ReadLine();
        }
    }
}
