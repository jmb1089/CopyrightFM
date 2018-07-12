namespace CopyrightFM
{
    partial class frmLookup
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLookup = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lvLookup = new System.Windows.Forms.ListView();
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAssociate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLookup
            // 
            this.txtLookup.Location = new System.Drawing.Point(73, 29);
            this.txtLookup.Name = "txtLookup";
            this.txtLookup.Size = new System.Drawing.Size(100, 20);
            this.txtLookup.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 32);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // lvLookup
            // 
            this.lvLookup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmOrderID,
            this.clmDate,
            this.clmAssociate,
            this.clmRelease,
            this.clmPhoneNum});
            this.lvLookup.Location = new System.Drawing.Point(15, 105);
            this.lvLookup.Name = "lvLookup";
            this.lvLookup.Size = new System.Drawing.Size(602, 219);
            this.lvLookup.TabIndex = 3;
            this.lvLookup.UseCompatibleStateImageBehavior = false;
            this.lvLookup.View = System.Windows.Forms.View.Details;
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "First Name";
            this.clmFirstName.Width = 73;
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            this.clmLastName.Width = 79;
            // 
            // clmOrderID
            // 
            this.clmOrderID.Text = "Order ID";
            this.clmOrderID.Width = 121;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            // 
            // clmAssociate
            // 
            this.clmAssociate.Text = "Associate";
            // 
            // clmRelease
            // 
            this.clmRelease.Text = "Release";
            this.clmRelease.Width = 90;
            // 
            // clmPhoneNum
            // 
            this.clmPhoneNum.Text = "Phone Number";
            this.clmPhoneNum.Width = 114;
            // 
            // frmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(643, 336);
            this.Controls.Add(this.lvLookup);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLookup);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmLookup";
            this.Text = "Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLookup;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ListView lvLookup;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmOrderID;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmAssociate;
        private System.Windows.Forms.ColumnHeader clmRelease;
        private System.Windows.Forms.ColumnHeader clmPhoneNum;
    }
}