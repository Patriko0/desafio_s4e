using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio_S4E.Models
{
    public class EtapaModel
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}