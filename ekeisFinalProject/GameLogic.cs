using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    /// <summary>
    /// default constructor
    /// </summary>
    internal class GameLogic
    {
        List<IEntity> entities;

        // Events
        internal event EventHandler<AddEntityToBoardEventArgs> AddEntityToBoard;
        internal event EventHandler<UpdateEntityHealthEventArgs> UpdateEntityHealth;

        public GameLogic()
        {
            entities = new List<IEntity>();
        }

        internal void AddEntitiesToBoard()
        {
            createEntity(50, 1, 30, 50, 10, "Hero", "Warrior", 1);
            //createEntity(1, 50, 60, 70, 5, "Hero", "Mage", 2);
            //createEntity(1, 1, 50, 100, 3, "Hero", "Cleric", 3);

            createEntity(20, 1, 10, 30, 7, "Enemy", "Bandit", 4);
            //createEntity(30, 1, 70, 60, 4, "Enemy", "Ogre", 5);
            //createEntity(50, 50, 50, 200, 2, "Enemy", "Dragon", 6);
        }

        /// <summary>
        /// handle turns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void HandlePlayTurn(object sender, EventArgs e)
        {
            foreach (var entity in entities)
            {
                if (entity is Hero)
                {
                    if ((entity as Hero).ActionType.Equals("Attack"))
                    {
                        IEntity target = entities.Find(target => target.EntityName.Equals((entity as Hero).Target));

                        target.Hitpoints -= (int)(entity.Strength * (1.0 - target.Defense / 100.0));

                        bool isDead = target.Hitpoints <= 0 ? true : false;
                        OnUpdateEntityHealth(new UpdateEntityHealthEventArgs(target.Hitpoints, target.Id, isDead));

                    }
                }
                else if (entity is Enemy)
                {
                    IEntity target = entities.Find(target => target.EntityName.Equals("Warrior"));

                    int defenseStat = target.Defense;
                    if ((target as Hero).ActionType.Equals("Defend"))
                    {
                        defenseStat *= 2;
                    }
                    target.Hitpoints -= (int)(entity.Strength * (1.0 - defenseStat / 100.0));
                    bool isDead = target.Hitpoints <= 0 ? true : false;
                    OnUpdateEntityHealth(new UpdateEntityHealthEventArgs(target.Hitpoints, target.Id, isDead));
                }
            }
        }

        void createEntity(int strength, int intelligence, int defense, int hitpoints, int speed, string entityType, string entityName, int entityID)
        {
            IEntity entity;
            if (entityType.Equals("Hero"))
            {
                entity = new Hero(strength, intelligence, defense, hitpoints, speed, entityName, entityID);
            }
            else
            {
                entity = new Enemy(strength, intelligence, defense, hitpoints, speed, entityName, entityID);
            }
            entities.Add(entity);
            OnAddEntityToBoard(new AddEntityToBoardEventArgs(entity.GetType().Name, entity.Hitpoints, entityName, entityID));
        }


        // Events
        protected virtual void OnAddEntityToBoard(AddEntityToBoardEventArgs e)
        {
            EventHandler<AddEntityToBoardEventArgs> addEntity = AddEntityToBoard;

            addEntity?.Invoke(this, e);
        }

        protected virtual void OnUpdateEntityHealth(UpdateEntityHealthEventArgs e)
        {
            EventHandler<UpdateEntityHealthEventArgs> updateEntity = UpdateEntityHealth;

            updateEntity?.Invoke(this, e);
        }

        internal void HandleUpdateEntityAction(object sender, SelectHeroActionEventArgs e)
        {
            IEntity entity = entities.Find(entity => entity.EntityName.Equals(e.HeroName.ToString()));
            (entity as Hero).ActionType = e.ActionType;

            if (e.ActionType.Equals("Attack"))
            {
                (entity as Hero).Target = e.Target;
            }
        }
    }
}
