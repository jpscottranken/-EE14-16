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
            cboSizeOrManufacturer = new System.Windows.Forms.ComboBox();
            lblSizeOrManufacturer = new System.Windows.Forms.Label();
            rdoPlant = new System.Windows.Forms.RadioButton();
            rdoSupply = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Yellow;
            label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(141, 116);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 38);
            label1.TabIndex = 8;
            label1.Text = "Item no:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemNo
            // 
            txtItemNo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            txtItemNo.Location = new System.Drawing.Point(337, 116);
            txtItemNo.Margin = new System.Windows.Forms.Padding(2);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new System.Drawing.Size(334, 38);
            txtItemNo.TabIndex = 2;
            txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Yellow;
            label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(141, 168);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 38);
            label2.TabIndex = 9;
            label2.Text = "Description:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            txtDescription.Location = new System.Drawing.Point(337, 168);
            txtDescription.Margin = new System.Windows.Forms.Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(334, 38);
            txtDescription.TabIndex = 3;
            txtDescription.Tag = "Description";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Yellow;
            label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(141, 281);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(179, 38);
            label3.TabIndex = 11;
            label3.Text = "Price:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            txtPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            txtPrice.Location = new System.Drawing.Point(337, 281);
            txtPrice.Margin = new System.Windows.Forms.Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(334, 38);
            txtPrice.TabIndex = 5;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(229, 363);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(143, 48);
            btnSave.TabIndex = 6;
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
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboSizeOrManufacturer
            // 
            cboSizeOrManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSizeOrManufacturer.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            cboSizeOrManufacturer.FormattingEnabled = true;
            cboSizeOrManufacturer.Location = new System.Drawing.Point(337, 225);
            cboSizeOrManufacturer.Margin = new System.Windows.Forms.Padding(2);
            cboSizeOrManufacturer.Name = "cboSizeOrManufacturer";
            cboSizeOrManufacturer.Size = new System.Drawing.Size(334, 39);
            cboSizeOrManufacturer.TabIndex = 4;
            // 
            // lblSizeOrManufacturer
            // 
            lblSizeOrManufacturer.BackColor = System.Drawing.Color.Yellow;
            lblSizeOrManufacturer.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            lblSizeOrManufacturer.Location = new System.Drawing.Point(141, 225);
            lblSizeOrManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSizeOrManufacturer.Name = "lblSizeOrManufacturer";
            lblSizeOrManufacturer.Size = new System.Drawing.Size(179, 38);
            lblSizeOrManufacturer.TabIndex = 10;
            lblSizeOrManufacturer.Text = "Size:";
            lblSizeOrManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoPlant
            // 
            rdoPlant.AutoSize = true;
            rdoPlant.Checked = true;
            rdoPlant.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            rdoPlant.Location = new System.Drawing.Point(337, 46);
            rdoPlant.Margin = new System.Windows.Forms.Padding(2);
            rdoPlant.Name = "rdoPlant";
            rdoPlant.Size = new System.Drawing.Size(86, 35);
            rdoPlant.TabIndex = 0;
            rdoPlant.TabStop = true;
            rdoPlant.Text = "Plant";
            rdoPlant.UseVisualStyleBackColor = true;
            rdoPlant.CheckedChanged += rdoPlant_CheckedChanged;
            // 
            // rdoSupply
            // 
            rdoSupply.AutoSize = true;
            rdoSupply.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            rdoSupply.Location = new System.Drawing.Point(493, 46);
            rdoSupply.Margin = new System.Windows.Forms.Padding(2);
            rdoSupply.Name = "rdoSupply";
            rdoSupply.Size = new System.Drawing.Size(107, 35);
            rdoSupply.TabIndex = 1;
            rdoSupply.TabStop = true;
            rdoSupply.Text = "Supply";
            rdoSupply.UseVisualStyleBackColor = true;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(779, 451);
            ControlBox = false;
            Controls.Add(rdoSupply);
            Controls.Add(rdoPlant);
            Controls.Add(lblSizeOrManufacturer);
            Controls.Add(cboSizeOrManufacturer);
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
        private System.Windows.Forms.ComboBox cboSizeOrManufacturer;
        private System.Windows.Forms.Label lblSizeOrManufacturer;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
    }
}