using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibDump.Model
{
    public class LibraryBook
    {
        // Methods
        public LibraryBook()
        {
            AddedEntries = new List<string>();
            Bio = new List<string>();
            CopyrightStatus = new List<string>();
            Description = new List<string>();
            Edition = new List<string>();
            Exhibitions = new List<string>();
            FindingAids = new List<string>();
            FormGenres = new List<string>();
            HostItems = new List<string>();
            ISBN = new List<string>();
            ISSN = new List<string>();
            Keywords = new LibraryBookKeyword();
            Links = new List<LibraryLink>();
            Notes = new List<string>();
            Publication = new List<string>();
            Restrictions = new List<string>();
            Series = new List<string>();
            Subjects = new List<string>();
            Summary = new List<string>();
            Forms = new List<Form>();
            TitlesAddedEntries = new List<string>();
            Holdings = new List<Holding>();
        }

        // Properties
        //[JsonIgnore]
        [IgnoreDataMember]
        public string ControlNumber { get; set; }
        public List<string> AddedEntries { get; set; }

        public List<string> Bio { get; set; }

        public List<string> Series { get; set; }

        public List<string> CopyrightStatus { get; set; }

        public List<string> Description { get; set; }

        public List<string> Edition { get; set; }

        public List<string> Exhibitions { get; set; }

        public List<string> FindingAids { get; set; }

        public List<string> FormGenres { get; set; }

        public List<Form> Forms { get; set; }

        public List<string> HostItems { get; set; }

        public List<string> ISBN { get; set; }

        public List<string> ISSN { get; set; }

        public LibraryBookKeyword Keywords { get; set; }

        public List<LibraryLink> Links { get; set; }

        public string MainEntry { get; set; }

        public List<string> Notes { get; set; }

        public List<string> Publication { get; set; }

        public List<string> Restrictions { get; set; }

        public List<string> Subjects { get; set; }

        public List<string> Summary { get; set; }

        public string Title { get; set; }

        public List<string> TitlesAddedEntries { get; set; }

        public List<Holding> Holdings { get; set; }

        public string BibID { get; set; }

        public string ImgUrl { get; set; }

    }
}
