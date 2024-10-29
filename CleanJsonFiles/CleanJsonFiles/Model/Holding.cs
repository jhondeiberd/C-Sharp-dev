using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanLibDump.Model
{
    public class Holding
    {
        public Holding() { }

        public Holding(Holding holding)
        {
            this.Collection = holding.Collection;
            this.CallNo = holding.CallNo;
            this.Copy = holding.Copy;
            this.Notes = holding.Notes;
            this.Location = holding.Location;
            this.Status = holding.Status;
            this.Piece = holding.Piece;
        }
        public string Collection { get; set; }
        public string CallNo { get; set; }
        public string Copy { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Piece { get; set; }

        [JsonIgnore]
        public string base_CallNumber_i { get; set; }
        [JsonIgnore]
        public string ocn { get; set; }
    }
}
