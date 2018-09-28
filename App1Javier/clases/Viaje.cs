using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace App1Javier.clases
{
   public class Viaje
    {
        [PrimaryKey,AutoIncrement]
        public int Id
        {
            get;set;
        }
        [MaxLength(150)]
        public string Nombre
        {
            set;get;
        }
        public DateTime FechaInicio
        {
            get;set;
        }
        public DateTime FechaRegreso

        {
            get; set;
        }

        public override string ToString()
        {
            return $"{Nombre} ({FechaInicio:d}  - {FechaRegreso:d})";
        }
    }
}
