namespace Lab2
{
    partial class Form2
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
            this.lvwEmployee = new System.Windows.Forms.ListView();
            this.Broker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Broker,
            this.Stock,
            this.Value,
            this.Change});
            this.lvwEmployee.Location = new System.Drawing.Point(12, 12);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.Size = new System.Drawing.Size(505, 430);
            this.lvwEmployee.TabIndex = 0;
            this.lvwEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee.View = System.Windows.Forms.View.Details;
            // 
            // Broker
            // 
            this.Broker.Text = "Broker";
            this.Broker.Width = 101;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 118;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 142;
            // 
            // Change
            // 
            this.Change.Text = "Change";
            this.Change.Width = 139;
            // 
            // cboOption
            // 
            this.cboOption.AllowDrop = true;
            this.cboOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Items.AddRange(new object[] {
            "1. Last Name Ascending",
            "2. Earned Descending",
            "3. SSN Ascending"});
            this.cboOption.Location = new System.Drawing.Point(562, 76);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(170, 21);
            this.cboOption.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(584, 245);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(127, 57);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 454);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cboOption);
            this.Controls.Add(this.lvwEmployee);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwEmployee;
        private System.Windows.Forms.ColumnHeader Broker;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Change;
        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.Button btnSort;
    }
}