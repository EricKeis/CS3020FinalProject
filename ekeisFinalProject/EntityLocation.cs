using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal class EntityLocation
    {
        public EntityLocation(int[] location)
        {
            Location = location;
        }

        internal int[] Location { get; set; }
        internal EntityUI EntityData { get; set; }
    }
}
