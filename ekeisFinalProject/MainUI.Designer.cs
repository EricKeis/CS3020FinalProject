namespace ekeisFinalProject
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.battlefield = new System.Windows.Forms.PictureBox();
            this.actionBox = new System.Windows.Forms.GroupBox();
            this.playTurn = new System.Windows.Forms.Button();
            this.specialButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.TextBox();
            this.battleLogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.battlefield)).BeginInit();
            this.actionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // battlefield
            // 
            this.battlefield.BackgroundImage = global::ekeisFinalProject.Properties.Resources.tpb_bg1;
            this.battlefield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.battlefield.Location = new System.Drawing.Point(12, 12);
            this.battlefield.Name = "battlefield";
            this.battlefield.Size = new System.Drawing.Size(1160, 525);
            this.battlefield.TabIndex = 0;
            this.battlefield.TabStop = false;
            // 
            // actionBox
            // 
            this.actionBox.Controls.Add(this.playTurn);
            this.actionBox.Controls.Add(this.specialButton);
            this.actionBox.Controls.Add(this.defendButton);
            this.actionBox.Controls.Add(this.attackButton);
            this.actionBox.Location = new System.Drawing.Point(12, 553);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(200, 196);
            this.actionBox.TabIndex = 1;
            this.actionBox.TabStop = false;
            this.actionBox.Text = "Actions";
            // 
            // playTurn
            // 
            this.playTurn.Enabled = false;
            this.playTurn.Location = new System.Drawing.Point(6, 167);
            this.playTurn.Name = "playTurn";
            this.playTurn.Size = new System.Drawing.Size(188, 23);
            this.playTurn.TabIndex = 3;
            this.playTurn.Text = "Play Turn";
            this.playTurn.UseVisualStyleBackColor = true;
            // 
            // specialButton
            // 
            this.specialButton.Enabled = false;
            this.specialButton.Location = new System.Drawing.Point(6, 80);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(188, 23);
            this.specialButton.TabIndex = 2;
            this.specialButton.Text = "Special";
            this.specialButton.UseVisualStyleBackColor = true;
            // 
            // defendButton
            // 
            this.defendButton.Enabled = false;
            this.defendButton.Location = new System.Drawing.Point(6, 51);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(188, 23);
            this.defendButton.TabIndex = 1;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = true;
            // 
            // attackButton
            // 
            this.attackButton.Enabled = false;
            this.attackButton.Location = new System.Drawing.Point(6, 22);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(188, 23);
            this.attackButton.TabIndex = 0;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // battleLog
            // 
            this.battleLog.BackColor = System.Drawing.SystemColors.Control;
            this.battleLog.Enabled = false;
            this.battleLog.Location = new System.Drawing.Point(819, 571);
            this.battleLog.Multiline = true;
            this.battleLog.Name = "battleLog";
            this.battleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLog.Size = new System.Drawing.Size(355, 178);
            this.battleLog.TabIndex = 2;
            // 
            // battleLogLabel
            // 
            this.battleLogLabel.AutoSize = true;
            this.battleLogLabel.Location = new System.Drawing.Point(819, 553);
            this.battleLogLabel.Name = "battleLogLabel";
            this.battleLogLabel.Size = new System.Drawing.Size(63, 15);
            this.battleLogLabel.TabIndex = 3;
            this.battleLogLabel.Text = "Battle Log:";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.battleLogLabel);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.battlefield);
            this.Name = "MainUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.battlefield)).EndInit();
            this.actionBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox battlefield;
        private GroupBox actionBox;
        private Button specialButton;
        private Button defendButton;
        private Button attackButton;
        private TextBox battleLog;
        private Label battleLogLabel;
        private Button playTurn;
    }
}