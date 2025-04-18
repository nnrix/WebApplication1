using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace WebApplication5
{

    [Table("users")]
    public class User : BaseModel
    { 
        [PrimaryKey]   
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("age")]
        public int Age { get; set; }
    }
}