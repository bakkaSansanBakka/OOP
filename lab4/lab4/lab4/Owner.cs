using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public partial class List
    {
        // вложенный класс
        public class Owner
        {
            public uint ID { get; set; }
            public string Name { get; set; }
            public string Organisation { get; set; }

            public Owner(uint ownerId, string ownerName, string ownerOrg)
            {
                ID = ownerId;
                Name = ownerName;
                Organisation = ownerOrg;
            }

            public override string ToString()
            {
                return $"ID – {ID}, имя создателя – {Name}, организация создателя – {Organisation}.";
            }
        }
    }
}
