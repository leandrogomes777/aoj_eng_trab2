using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsService.Model
{
    public class Drug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID
        {
            get;
            set;
        }

        public string DrugName
        {
            get;
            set;
        }

        public string Holder
        {
            get;
            set;
        }

        public string Medicine
        {
            get;
            set;
        }

        public string Record
        {
            get;
            set;
        }

        public string Concentration
        {
            get;
            set;
        }

        public string PharmaceuticalForm
        {
            get;
            set;
        }
    }
}
