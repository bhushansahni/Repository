using System;
using System.ComponentModel.DataAnnotations;

namespace Repository.Base
{
    public class EntityBase
    {
        [Key]
        public Guid Guid {get;set;}
        public int Version {get;set;}
        public DateTime DateCreated {get;set;}
        public DateTime DateUpdated {get;set;}
    }
}