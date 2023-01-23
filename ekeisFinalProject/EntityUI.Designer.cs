namespace ekeisFinalProject
{
    partial class EntityUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entitySprite = new System.Windows.Forms.PictureBox();
            this.entityHP = new System.Windows.Forms.ProgressBar();
            this.entityInfo = new System.Windows.Forms.Panel();
            this.characterName = new System.Windows.Forms.Label();
            this.characterHp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entitySprite)).BeginInit();
            this.entityInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // entitySprite
            // 
            this.entitySprite.BackgroundImage = global::ekeisFinalProject.Properties.Resources.Bandit;
            this.entitySprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entitySprite.Location = new System.Drawing.Point(15, 0);
            this.entitySprite.Name = "entitySprite";
            this.entitySprite.Size = new System.Drawing.Size(90, 90);
            this.entitySprite.TabIndex = 0;
            this.entitySprite.TabStop = false;
            // 
            // entityHP
            // 
            this.entityHP.Location = new System.Drawing.Point(30, 108);
            this.entityHP.Name = "entityHP";
            this.entityHP.Size = new System.Drawing.Size(85, 8);
            this.entityHP.Step = 1;
            this.entityHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.entityHP.TabIndex = 1;
            // 
            // entityInfo
            // 
            this.entityInfo.BackColor = System.Drawing.SystemColors.Info;
            this.entityInfo.Controls.Add(this.characterName);
            this.entityInfo.Controls.Add(this.characterHp);
            this.entityInfo.Location = new System.Drawing.Point(0, 90);
            this.entityInfo.Name = "entityInfo";
            this.entityInfo.Size = new System.Drawing.Size(120, 30);
            this.entityInfo.TabIndex = 2;
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.characterName.Location = new System.Drawing.Point(0, 0);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(97, 15);
            this.characterName.TabIndex = 0;
            this.characterName.Text = "Character Name";
            // 
            // characterHp
            // 
            this.characterHp.AutoSize = true;
            this.characterHp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.characterHp.ForeColor = System.Drawing.Color.Black;
            this.characterHp.Location = new System.Drawing.Point(3, 15);
            this.characterHp.Name = "characterHp";
            this.characterHp.Size = new System.Drawing.Size(23, 15);
            this.characterHp.TabIndex = 1;
            this.characterHp.Text = "HP";
            // 
            // EntityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.entityHP);
            this.Controls.Add(this.entityInfo);
            this.Controls.Add(this.entitySprite);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EntityUI";
            this.Size = new System.Drawing.Size(120, 120);
            ((System.ComponentModel.ISupportInitialize)(this.entitySprite)).EndInit();
            this.entityInfo.ResumeLayout(false);
            this.entityInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel entityInfo;
        private Label characterHp;
        internal PictureBox entitySprite;
        internal Label characterName;
        internal ProgressBar entityHP;
    }
}
