using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal class UpdateEntityHealthEventArgs : EventArgs
    {
        int health;
        int entityID;
        bool isDead = false;

        public UpdateEntityHealthEventArgs(int health, int entityID, bool isDead)
        {
            this.health = health;
            this.entityID = entityID;
            this.isDead = isDead;
        }

        public int Health { get => health; set => health = value; }
        public int EntityID { get => entityID; set => entityID = value; }
        public bool IsDead { get => isDead; set => isDead = value; }
    }
}
