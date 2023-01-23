using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal class AddEntityToBoardEventArgs : EventArgs
    {
        string entityType;
        string entityName;
        int entityID;
        int health;

        public AddEntityToBoardEventArgs(string entityType,int health, string entityName, int entityID)
        {
            this.entityType = entityType;
            this.entityName = entityName;
            this.entityID = entityID;
            this.health = health;
        }

        public string EntityType { get => entityType; set => entityType = value; }
        public string EntityName { get => entityName; set => entityName = value; }
        public int EntityID { get => entityID; set => entityID = value; }
        public int Health { get => health; set => health = value; }
    }
}
