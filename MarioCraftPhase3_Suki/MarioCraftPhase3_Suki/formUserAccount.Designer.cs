namespace MarioCraftPhase3_Suki
{
    partial class formUserAccount
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gAMEUSERDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MarioCraftPhase3_Suki.DataSet1();
            this.grpAmend = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gAMEUSERDETAILSTableAdapter = new MarioCraftPhase3_Suki.DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter();
            this.uSEREMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.grpAmend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
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
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Super Mario 286", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(592, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(127, 48);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
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
            // grpAmend
            // 
            this.grpAmend.Controls.Add(this.btnUpdate);
            this.grpAmend.Controls.Add(this.lblPassword);
            this.grpAmend.Controls.Add(this.lblUserEmail);
            this.grpAmend.Controls.Add(this.lblUserID);
            this.grpAmend.Controls.Add(this.txtPassword);
            this.grpAmend.Controls.Add(this.txtEmail);
            this.grpAmend.Controls.Add(this.txtID);
            this.grpAmend.Font = new System.Drawing.Font("Super Mario 286", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAmend.Location = new System.Drawing.Point(12, 194);
            this.grpAmend.Name = "grpAmend";
            this.grpAmend.Size = new System.Drawing.Size(707, 287);
            this.grpAmend.TabIndex = 12;
            this.grpAmend.TabStop = false;
            this.grpAmend.Text = "Amend Details";
            this.grpAmend.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 31);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(28, 124);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(173, 31);
            this.lblUserEmail.TabIndex = 4;
            this.lblUserEmail.Text = "Email Address";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(28, 77);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(98, 31);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(267, 174);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 28);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(267, 124);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 28);
            this.txtEmail.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(267, 77);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(66, 28);
            this.txtID.TabIndex = 0;
            // 
            // gAMEUSERDETAILSTableAdapter
            // 
            this.gAMEUSERDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // uSEREMAILDataGridViewTextBoxColumn
            // 
            this.uSEREMAILDataGridViewTextBoxColumn.DataPropertyName = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.HeaderText = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.Name = "uSEREMAILDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // grdDetails
            // 
            this.grdDetails.AutoGenerateColumns = false;
            this.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.uSEREMAILDataGridViewTextBoxColumn});
            this.grdDetails.DataSource = this.gAMEUSERDETAILSBindingSource;
            this.grdDetails.Location = new System.Drawing.Point(12, 73);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.RowTemplate.Height = 24;
            this.grdDetails.Size = new System.Drawing.Size(260, 79);
            this.grdDetails.TabIndex = 10;
            this.grdDetails.Visible = false;
            this.grdDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetails_CellClick);
            // 
            // formUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 497);
            this.Controls.Add(this.grpAmend);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUserDetail);
            this.Name = "formUserAccount";
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.formGameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.grpAmend.ResumeLayout(false);
            this.grpAmend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserDetail;
        private System.Windows.Forms.Button btnLogOut;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource;
        private DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter gAMEUSERDETAILSTableAdapter;
        private System.Windows.Forms.GroupBox grpAmend;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEREMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView grdDetails;
    }
}