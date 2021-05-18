using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1Resteau1.Resteau
{
    [Table("PlatGastronomique")]
    public class Plat
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), Unique]
        public string Nom { get; set; }
    }
}
