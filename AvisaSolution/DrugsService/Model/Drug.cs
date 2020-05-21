using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsService.Model
{
    public class Drug
    {
        public long ID
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
