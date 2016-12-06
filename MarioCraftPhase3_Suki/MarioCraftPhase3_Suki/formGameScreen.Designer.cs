namespace MarioCraftPhase3_Suki
{
    partial class formGameScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserDetail = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserDetail
            // 
            this.btnUserDetail.Font = new System.Drawing.Font("Super Mario 286", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetail.Location = new System.Drawing.Point(12, 12);
            this.btnUserDetail.Name = "btnUserDetail";
            this.btnUserDetail.Size = new System.Drawing.Size(260, 37);
            this.btnUserDetail.TabIndex = 0;
            this.btnUserDetail.Text = "View Account Detail";
            this.btnUserDetail.UseVisualStyleBackColor = true;
            this.btnUserDetail.Click += new System.EventHandler(this.btnUserDetail_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Super Mario 286", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(617, 12);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(255, 37);
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Super Mario 286", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.Location = new System.Drawing.Point(81, 428);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(72, 26);
            this.player.TabIndex = 3;
            this.player.Text = "player";
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(149, 577);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(123, 23);
            this.playerHealthBar.TabIndex = 4;
            this.playerHealthBar.Value = 100;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Super Mario 286", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.Location = new System.Drawing.Point(7, 577);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(136, 26);
            this.lblPlayerHealth.TabIndex = 6;
            this.lblPlayerHealth.Text = "Player Health";
            // 
            // formGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 612);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnUserDetail);
            this.Name = "formGameScreen";
            this.Text = "Mario Craft - Game Screen";
            this.Load += new System.EventHandler(this.formGameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGameScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserDetail;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.Label lblPlayerHealth;
    }
}