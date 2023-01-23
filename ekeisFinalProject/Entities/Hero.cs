using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal class Hero : IEntity
    {
        public Hero(int strength, int intelligence, int defense, int hitpoints, int speed, string entityName, int id)
        {
            Strength = strength;
            Intelligence = intelligence;
            Defense = defense;
            Hitpoints = hitpoints;
            Speed = speed;
            EntityName = entityName;
            Id = id;
        }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Hitpoints { get; set; }
        public int Speed { get; set; }
        public string EntityName { get; set; }
        public bool HasActionselected { get; set; }
        public string ActionType { get; set; }
        public string Target { get; set; }
        public int Id { get; set; }
    }
}
