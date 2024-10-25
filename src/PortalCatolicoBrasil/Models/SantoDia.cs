﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalCatolicoBrasil.Models
{
    [Table("santo_do_dia")]
    public class SantoDia
    {
        [Key]
        public DateOnly Data { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
