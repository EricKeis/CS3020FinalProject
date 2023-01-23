namespace ekeisFinalProject
{
    public partial class MainUI : Form
    {
        bool isSelectingTarget = false;
        bool isRoundOver = false;
        List<EntityUI> entities;

        List<EntityLocation> heroLocations;
        List<EntityLocation> enemyLocations;

        // Event args
        internal SelectHeroActionEventArgs action;

        // Events
        internal event EventHandler<SelectHeroActionEventArgs> UpdateEntityAction;
        internal event EventHandler PlayTurn;

        /// <summary>
        /// Initialize ui elements
        /// </summary>
        public MainUI()
        {
            InitializeComponent();

            heroLocations = new List<EntityLocation>();
            enemyLocations = new List<EntityLocation>();

            heroLocations.Add(new EntityLocation(new int[] { 50, 20 }));
            heroLocations.Add(new EntityLocation(new int[] { 100, 170 }));
            heroLocations.Add(new EntityLocation(new int[] { 50, 320 }));

            enemyLocations.Add(new EntityLocation(new int[] { this.Size.Width - 170, 20 }));
            enemyLocations.Add(new EntityLocation(new int[] { this.Size.Width - 220, 170 }));
            enemyLocations.Add(new EntityLocation(new int[] { this.Size.Width - 170, 320 }));

            entities = new List<EntityUI>();

            // events
            attackButton.Click += OnActionButtonClick;
            defendButton.Click += OnActionButtonClick;
            specialButton.Click += OnActionButtonClick;
            playTurn.Click += OnPlayTurnClick;
        }

        /// <summary>
        /// Add guys to board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void HandleAddEntityToBoard(object sender, AddEntityToBoardEventArgs e)
        {
            if (e.EntityType.Equals("Hero"))
            {
                EntityLocation location = heroLocations.Find(loc => loc.EntityData == null);


                EntityUI entity = new EntityUI(location.Location[0], location.Location[1], e.Health, e.EntityName, e.EntityID);
                entity.entitySprite.Click += OnEntityClick;

                heroLocations.Find(loc => loc.EntityData == null).EntityData = entity;

                entities.Add(entity);
                battlefield.Controls.Add(entity);
            }
            else
            {
                EntityLocation location = enemyLocations.Find(loc => loc.EntityData == null);

                EntityUI entity = new EntityUI(location.Location[0], location.Location[1], e.Health, e.EntityName, e.EntityID);
                entity.entitySprite.Click += OnEntityClick;

                enemyLocations.Find(loc => loc.EntityData == null).EntityData = entity;

                entities.Add(entity);
                battlefield.Controls.Add(entity);
            }
        }

        /// <summary>
        /// Update health and determine game over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void HandleUpdateEntityHealth(object sender, UpdateEntityHealthEventArgs e)
        {            
            EntityUI entity = entities.Find(x => x.EntityID == e.EntityID);

            entity.entityHP.Value = e.Health > 0 ? e.Health : 0;

            if (e.IsDead)
            {
                entity.BackColor = Color.OrangeRed;
                entity.characterName.ForeColor = Color.OrangeRed;

                battleLog.AppendText($"{entity.characterName.Text} has died!\r\n");
                isRoundOver = true;
            }
            else
            {
                battleLog.AppendText($"{entity.characterName.Text} has {entity.entityHP.Value} HP remaining!\r\n");
            }

            if (isRoundOver)
            {
                battleLog.AppendText($"Round over!\r\n");
                attackButton.Enabled = false;
                defendButton.Enabled = false;
                specialButton.Enabled = false;
                playTurn.Enabled = false;
            }
        }

        /// <summary>
        /// determine entity click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void OnEntityClick(object sender, EventArgs e)
        {
            if (!isSelectingTarget)
            {
                action = new SelectHeroActionEventArgs((sender as PictureBox).Tag.ToString());
                attackButton.Enabled = true;
                defendButton.Enabled = true;
                specialButton.Enabled = true;
            }
            else if ( isSelectingTarget && (sender as PictureBox).Tag.ToString().Equals("Bandit"))
            {
                action.Target = (sender as PictureBox).Tag.ToString();
                isSelectingTarget = false;
                battleLog.AppendText("Targeting " + action.Target + "\r\n");

                OnUpdateEntityAction(action);
                playTurn.Enabled = true;
            }
        }

        /// <summary>
        /// handle actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void OnActionButtonClick(object sender, EventArgs e)
        {
            action.ActionType = (sender as Button).Text; 

            if ((sender as Button).Text.Equals("Attack"))
            {
                battleLog.AppendText("Select an enemy to target!\r\n");
                isSelectingTarget = true;
            }
            else
            {
                OnUpdateEntityAction(action);

                playTurn.Enabled = true;
            }
        }

        internal void OnPlayTurnClick(object sender, EventArgs e)
        {
            OnPlayTurn(e);
        }

        protected virtual void OnPlayTurn(EventArgs e)
        {
            EventHandler playTurn = PlayTurn;

            playTurn?.Invoke(this, e);
        }

        // figure out why protected modifier doesnt work
        internal virtual void OnUpdateEntityAction(SelectHeroActionEventArgs e)
        {
            EventHandler<SelectHeroActionEventArgs> updateEntityAction = UpdateEntityAction;

            updateEntityAction?.Invoke(this, e);
        }
    }
}