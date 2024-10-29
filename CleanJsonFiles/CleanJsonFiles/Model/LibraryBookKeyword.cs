using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibDump.Model
{
    public class LibraryBookKeyword
    {
        // Methods
        public LibraryBookKeyword()
        {
            this.Author = new List<string>();
            this.CountryOfPublicationCode = new List<string>();
            this.General = new List<string>();
            this.ISBN = new List<string>();
            this.ISSN = new List<string>();
            this.LanguageCode = new List<string>();
            this.LocalDesignationCode = new List<string>();
            this.Notes = new List<string>();
            this.PhysicalDescription = new List<string>();
            this.PlacePublisherDateOfPublication = new List<string>();
            this.Series = new List<string>();
            this.Subjects = new List<string>();
            this.Titles = new List<string>();
        }


        // Properties
        public List<string> Author { get; set; }

        public List<string> CountryOfPublicationCode { get; set; }

        public List<string> General { get; set; }

        public List<string> ISBN { get; set; }

        public List<string> ISSN { get; set; }

        public List<string> LanguageCode { get; set; }

        public List<string> LocalDesignationCode { get; set; }

        public List<string> Notes { get; set; }

        public List<string> PhysicalDescription { get; set; }

        public List<string> PlacePublisherDateOfPublication { get; set; }

        public List<string> Series { get; set; }

        public List<string> Subjects { get; set; }

        public List<string> Titles { get; set; }

        public string ShortTitle { get; set; }

        public string BibNumber { get; set; }

        public string OCLCMasterNumber { get; set; }
    }

}
