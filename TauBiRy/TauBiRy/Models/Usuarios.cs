﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TauBiRy.Models
{
    [SQLite.Table("Usuarios")]
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), Unique]
        public string Nome { get; set; }
        public string Senha { get; set; } //não pode ser nullo
        public string Email { get; set; } //não pode ser nulo
        public string Telefone { get; set; }

    }
}
