using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set ; }
        public string Address { get; set; }
        public long CellPhone { get; set; }

        
        public override string ToString()
        {
            return string.Format("Id #: {0}, Name: {1}, Address: {2}, Cell Phone: {3}  ", this.Id, this.Name, this.Address, this.CellPhone);
        }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Control> controls { get; set; }
    }

    public class Control
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string RoleUser { get; set; }
        public override string ToString()
        {
            return string.Format("Id #: {0}, Name: {1}, Password: {2}, Role user: {3}  ", this.Id, this.Name, this.Password, this.RoleUser);
        }

    }

}
