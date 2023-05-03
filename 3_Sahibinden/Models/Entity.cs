using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sahibinden.Models
{
    internal class Entity
    {
        [Key]//primary key,identity(1,1)
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Entity()
        {

        }
        public Entity(string name)
        {
            Name = name;
            
        }
    }
}
