using System.ComponentModel.DataAnnotations.Schema;
using Repository.Base;

namespace Repository.Entities
{
    [Table("Test")]
    public class TestEntity:EntityBase
    {
        public string Name {get;set;}
    }
}