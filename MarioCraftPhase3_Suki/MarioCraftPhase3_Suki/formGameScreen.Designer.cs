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
            this.components = new System.ComponentModel.Container();
            this.btnUserDetail = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.grdRucksack = new System.Windows.Forms.DataGridView();
            this.btnViewRucksack = new System.Windows.Forms.Button();
            this.grdDetails = new System.Windows.Forms.DataGridView();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEREMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEUSERDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MarioCraftPhase3_Suki.DataSet1();
            this.gAMEUSERDETAILSTableAdapter = new MarioCraftPhase3_Suki.DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdRucksack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.btnBackToMainMenu.Location = new System.Drawing.Point(636, 563);
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
            this.player.Location = new System.Drawing.Point(99, 521);
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
            // grdRucksack
            // 
            this.grdRucksack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRucksack.Location = new System.Drawing.Point(301, 65);
            this.grdRucksack.Name = "grdRucksack";
            this.grdRucksack.RowTemplate.Height = 24;
            this.grdRucksack.Size = new System.Drawing.Size(142, 76);
            this.grdRucksack.TabIndex = 8;
            // 
            // btnViewRucksack
            // 
            this.btnViewRucksack.Location = new System.Drawing.Point(301, 12);
            this.btnViewRucksack.Name = "btnViewRucksack";
            this.btnViewRucksack.Size = new System.Drawing.Size(142, 37);
            this.btnViewRucksack.TabIndex = 9;
            this.btnViewRucksack.Text = "View Rucksack";
            this.btnViewRucksack.UseVisualStyleBackColor = true;
            this.btnViewRucksack.Click += new System.EventHandler(this.btnViewRucksack_Click);
            // 
            // grdDetails
            // 
            this.grdDetails.AutoGenerateColumns = false;
            this.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.uSEREMAILDataGridViewTextBoxColumn});
            this.grdDetails.DataSource = this.gAMEUSERDETAILSBindingSource;
            this.grdDetails.Location = new System.Drawing.Point(12, 65);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.RowTemplate.Height = 24;
            this.grdDetails.Size = new System.Drawing.Size(240, 76);
            this.grdDetails.TabIndex = 10;
            this.grdDetails.Visible = false;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // uSEREMAILDataGridViewTextBoxColumn
            // 
            this.uSEREMAILDataGridViewTextBoxColumn.DataPropertyName = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.HeaderText = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.Name = "uSEREMAILDataGridViewTextBoxColumn";
            // 
            // gAMEUSERDETAILSBindingSource
            // 
            this.gAMEUSERDETAILSBindingSource.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMEUSERDETAILSTableAdapter
            // 
            this.gAMEUSERDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // formGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 623);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.btnViewRucksack);
            this.Controls.Add(this.grdRucksack);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnUserDetail);
            this.Name = "formGameScreen";
            this.Text = "Mario Craft - Game Screen";
            this.Load += new System.EventHandler(this.formGameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdRucksack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserDetail;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.DataGridView grdRucksack;
        private System.Windows.Forms.Button btnViewRucksack;
        private System.Windows.Forms.DataGridView grdDetails;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource;
        private DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter gAMEUSERDETAILSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEREMAILDataGridViewTextBoxColumn;
    }
}