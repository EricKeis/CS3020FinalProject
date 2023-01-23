using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekeisFinalProject
{
    public partial class EntityUI : UserControl
    {
        int entityID;

        public EntityUI(int x, int y, int maxHealth, string entityName, int entityID)
        {
            InitializeComponent();

            this.entityID = entityID;

            this.Location = new Point(x, y);

            this.characterName.Text = entityName;
            this.entitySprite.Tag = entityName;
            entityHP.Maximum = maxHealth;
            entityHP.Value = maxHealth;
            this.entitySprite.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(entityName);
        }

        public int EntityID { get => entityID; set => entityID = value; }
    }
}
