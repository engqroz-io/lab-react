using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetomvc.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(9)]
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}