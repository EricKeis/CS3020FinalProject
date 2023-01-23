using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal interface IEntity
    {
        int Strength { get; set; }
        int Intelligence { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Hitpoints { get; set; }
        int Speed { get; set; }
        int Id { get; set; }
        string EntityName { get; set; }
    }
}