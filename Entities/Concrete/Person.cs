using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete
{
    public class Person : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? PhotoPath { get; set; }
        public string? Description { get; set; }
        public DateTime? ModifiedDate { get; }
        public bool? Favorite { get; set; }
        public bool? Block { get; set; }

        public string? Mail { get; set; }
    }
}
