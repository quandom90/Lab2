namespace Lab2
{
    partial class Form1
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
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.lvwEmployee = new System.Windows.Forms.ListView();
            this.colLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEarned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSort = new System.Windows.Forms.Button();
            this.grpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.label1);
            this.grpOption.Controls.Add(this.cboSort);
            this.grpOption.Location = new System.Drawing.Point(503, 12);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(173, 154);
            this.grpOption.TabIndex = 5;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sort By:";
            // 
            // cboSort
            // 
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "1. Last Name Ascending",
            "2. Earned Descending",
            "3. SSN Ascending"});
            this.cboSort.Location = new System.Drawing.Point(9, 47);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(153, 21);
            this.cboSort.TabIndex = 8;
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLast,
            this.colFirst,
            this.colSSN,
            this.colEarned});
            this.lvwEmployee.Location = new System.Drawing.Point(12, 12);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.Size = new System.Drawing.Size(485, 338);
            this.lvwEmployee.TabIndex = 6;
            this.lvwEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee.View = System.Windows.Forms.View.Details;
            // 
            // colLast
            // 
            this.colLast.Text = "Last Name";
            this.colLast.Width = 106;
            // 
            // colFirst
            // 
            this.colFirst.Text = "First Name";
            this.colFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFirst.Width = 113;
            // 
            // colSSN
            // 
            this.colSSN.Text = "Social Security Number";
            this.colSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSSN.Width = 124;
            // 
            // colEarned
            // 
            this.colEarned.Text = "Payment Earned";
            this.colEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEarned.Width = 135;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(520, 238);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(145, 41);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 362);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lvwEmployee);
            this.Controls.Add(this.grpOption);
            this.Name = "Form1";
            this.Text = "Employee List";
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.ListView lvwEmployee;
        private System.Windows.Forms.ColumnHeader colLast;
        private System.Windows.Forms.ColumnHeader colFirst;
        private System.Windows.Forms.ColumnHeader colSSN;
        private System.Windows.Forms.ColumnHeader colEarned;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Label label1;
    }
}

