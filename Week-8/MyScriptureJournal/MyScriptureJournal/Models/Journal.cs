using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Journal
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 1)]
        public string Scripture { get; set; }

        [Display(Name = "Insert Date"), DataType(DataType.DateTime)]
        public DateTime InsertDate { get; set; }

        [Required, StringLength(30)]
        public string Book { get; set; }

        [StringLength(5000)]
        public string Notes { get; set; }
    }
}