using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal class SelectHeroActionEventArgs : EventArgs
    {
        string actionType;
        string heroName;
        string target;

        public SelectHeroActionEventArgs(string heroName)
        {
            this.actionType = null;
            this.heroName = heroName;
            this.target = null;
        }

        public SelectHeroActionEventArgs(string actionType, string heroName)
        {
            this.actionType = actionType;
            this.heroName = heroName;
            this.target = null;
        }

        public SelectHeroActionEventArgs(string actionType, string heroName, string target)
        {
            this.actionType = actionType;
            this.heroName = heroName;
            this.target = target;
        }

        public string ActionType { get => actionType; set => actionType = value; }
        public string HeroName { get => heroName; set => heroName = value; }
        public string Target { get => target; set => target = value; }
    }
}
