namespace CopyrightFM
{
    partial class frmBrowse
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
            this.lvFound = new System.Windows.Forms.ListView();
            this.clmLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFirst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAssociate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFound
            // 
            this.lvFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmLast,
            this.clmFirst,
            this.clmOrderID,
            this.clmDate,
            this.clmAssociate,
            this.clmRelease});
            this.lvFound.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFound.FullRowSelect = true;
            this.lvFound.GridLines = true;
            this.lvFound.Location = new System.Drawing.Point(12, 28);
            this.lvFound.Name = "lvFound";
            this.lvFound.Size = new System.Drawing.Size(696, 375);
            this.lvFound.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvFound.TabIndex = 1;
            this.lvFound.UseCompatibleStateImageBehavior = false;
            this.lvFound.View = System.Windows.Forms.View.Details;
            // 
            // clmLast
            // 
            this.clmLast.Text = "Last Name";
            this.clmLast.Width = 116;
            // 
            // clmFirst
            // 
            this.clmFirst.Text = "First Name";
            this.clmFirst.Width = 102;
            // 
            // clmOrderID
            // 
            this.clmOrderID.Text = "Order ID";
            this.clmOrderID.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 82;
            // 
            // clmAssociate
            // 
            this.clmAssociate.Text = "Associate";
            this.clmAssociate.Width = 80;
            // 
            // clmRelease
            // 
            this.clmRelease.Text = "Release";
            this.clmRelease.Width = 80;
            // 
            // frmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 414);
            this.Controls.Add(this.lvFound);
            this.Name = "frmBrowse";
            this.Text = "frmBrowse";
            this.Load += new System.EventHandler(this.frmBrowse_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvFound;
        private System.Windows.Forms.ColumnHeader clmLast;
        private System.Windows.Forms.ColumnHeader clmFirst;
        private System.Windows.Forms.ColumnHeader clmOrderID;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmAssociate;
        private System.Windows.Forms.ColumnHeader clmRelease;
    }
}