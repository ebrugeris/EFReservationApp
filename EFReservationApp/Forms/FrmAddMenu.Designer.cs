namespace EFReservationApp.Forms
{
    partial class FrmAddMenu
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
            txtTitle = new TextBox();
            label5 = new Label();
            txtdescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            dgvCustomers = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(149, 27);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(145, 27);
            txtTitle.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 30);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 2;
            label5.Text = "Title:";
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(149, 72);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(145, 27);
            txtdescription.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 72);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Description:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(149, 115);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(145, 27);
            txtPrice.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 118);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 4;
            label1.Text = "Price:";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(9, 241);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(765, 188);
            dgvCustomers.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(205, 185);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(348, 185);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(488, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmAddMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCustomers);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(txtdescription);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Name = "FrmAddMenu";
            Text = "FrmAddMenu";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label5;
        private TextBox txtdescription;
        private Label label3;
        private TextBox txtPrice;
        private Label label1;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}