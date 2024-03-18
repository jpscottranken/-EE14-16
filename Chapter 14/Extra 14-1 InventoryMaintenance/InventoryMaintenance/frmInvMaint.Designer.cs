namespace InventoryMaintenance
{
    partial class frmInvMaint
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
            lstItems = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 31;
            lstItems.Location = new System.Drawing.Point(33, 11);
            lstItems.Margin = new System.Windows.Forms.Padding(2);
            lstItems.Name = "lstItems";
            lstItems.Size = new System.Drawing.Size(540, 407);
            lstItems.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            btnAdd.Location = new System.Drawing.Point(604, 9);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(151, 52);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            btnDelete.Location = new System.Drawing.Point(604, 182);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(151, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            btnExit.Location = new System.Drawing.Point(604, 366);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(151, 52);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInvMaint
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(779, 451);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmInvMaint";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inventory Maintenance";
            Load += frmInvMaint_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

