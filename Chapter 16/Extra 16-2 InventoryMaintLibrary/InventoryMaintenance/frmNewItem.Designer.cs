namespace InventoryMaintenance
{
    partial class frmNewItem
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
            label1 = new System.Windows.Forms.Label();
            txtItemNo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Blue;
            label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(141, 72);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 38);
            label1.TabIndex = 5;
            label1.Text = "Item no:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemNo
            // 
            txtItemNo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            txtItemNo.Location = new System.Drawing.Point(361, 73);
            txtItemNo.Margin = new System.Windows.Forms.Padding(2);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new System.Drawing.Size(334, 38);
            txtItemNo.TabIndex = 0;
            txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Blue;
            label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(141, 177);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 38);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            txtDescription.Location = new System.Drawing.Point(361, 177);
            txtDescription.Margin = new System.Windows.Forms.Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(334, 38);
            txtDescription.TabIndex = 1;
            txtDescription.Tag = "Description";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Blue;
            label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(141, 281);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(179, 38);
            label3.TabIndex = 7;
            label3.Text = "Price:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            txtPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            txtPrice.Location = new System.Drawing.Point(361, 281);
            txtPrice.Margin = new System.Windows.Forms.Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(334, 38);
            txtPrice.TabIndex = 2;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(229, 363);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(143, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            btnCancel.Location = new System.Drawing.Point(457, 363);
            btnCancel.Margin = new System.Windows.Forms.Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(143, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(779, 451);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}