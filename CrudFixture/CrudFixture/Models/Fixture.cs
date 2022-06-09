using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFixture.Models
{
    public class Fixture
    {
        [Key]
        public int Id  { get; set; }


       
        public int Fecha { get; set; }


       
        public String Local { get; set; }


      
        public String Visitante { get; set; }


     
        public String  Estadio{ get; set; }


        
        public DateTime Dia { get; set; }


      
        public string Resultado { get; set; }
    }
}
