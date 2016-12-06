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
            this.character = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserDetail
            // 
            this.btnUserDetail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetail.Location = new System.Drawing.Point(12, 12);
            this.btnUserDetail.Name = "btnUserDetail";
            this.btnUserDetail.Size = new System.Drawing.Size(162, 67);
            this.btnUserDetail.TabIndex = 0;
            this.btnUserDetail.Text = "View Account Detail";
            this.btnUserDetail.UseVisualStyleBackColor = true;
            this.btnUserDetail.Click += new System.EventHandler(this.btnUserDetail_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(763, 12);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(109, 52);
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Black;
            this.character.Location = new System.Drawing.Point(30, 494);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(29, 59);
            this.character.TabIndex = 2;
            this.character.TabStop = false;
            // 
            // formGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 565);
            this.Controls.Add(this.character);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnUserDetail);
            this.Name = "formGameScreen";
            this.Text = "Mario Craft - Game Screen";
            this.Load += new System.EventHandler(this.formGameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserDetail;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.PictureBox character;
    }
}