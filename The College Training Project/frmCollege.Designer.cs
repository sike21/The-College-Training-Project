namespace The_College_Training_Project
{
    partial class frmCollege
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
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.lblCollegeAddress = new System.Windows.Forms.Label();
            this.txtBoxCollegAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCollegeName = new System.Windows.Forms.TextBox();
            this.dataGridVCollege = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearchCollege = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.CollegeIDlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVCollege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.AutoSize = true;
            this.lblCollegeName.BackColor = System.Drawing.Color.Transparent;
            this.lblCollegeName.Location = new System.Drawing.Point(34, 181);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(73, 13);
            this.lblCollegeName.TabIndex = 0;
            this.lblCollegeName.Text = "College Name";
            // 
            // lblCollegeAddress
            // 
            this.lblCollegeAddress.AutoSize = true;
            this.lblCollegeAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblCollegeAddress.Location = new System.Drawing.Point(34, 261);
            this.lblCollegeAddress.Name = "lblCollegeAddress";
            this.lblCollegeAddress.Size = new System.Drawing.Size(83, 13);
            this.lblCollegeAddress.TabIndex = 1;
            this.lblCollegeAddress.Text = "College Address";
            // 
            // txtBoxCollegAddress
            // 
            this.txtBoxCollegAddress.Location = new System.Drawing.Point(155, 258);
            this.txtBoxCollegAddress.Name = "txtBoxCollegAddress";
            this.txtBoxCollegAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCollegAddress.TabIndex = 2;
            // 
            // txtBoxCollegeName
            // 
            this.txtBoxCollegeName.Location = new System.Drawing.Point(155, 181);
            this.txtBoxCollegeName.Name = "txtBoxCollegeName";
            this.txtBoxCollegeName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCollegeName.TabIndex = 3;
            // 
            // dataGridVCollege
            // 
            this.dataGridVCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVCollege.Location = new System.Drawing.Point(304, 80);
            this.dataGridVCollege.Name = "dataGridVCollege";
            this.dataGridVCollege.Size = new System.Drawing.Size(450, 210);
            this.dataGridVCollege.TabIndex = 4;
            this.dataGridVCollege.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridVCollege_RowHeaderMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(367, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(496, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(625, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearchCollege
            // 
            this.lblSearchCollege.AutoSize = true;
            this.lblSearchCollege.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCollege.Location = new System.Drawing.Point(301, 52);
            this.lblSearchCollege.Name = "lblSearchCollege";
            this.lblSearchCollege.Size = new System.Drawing.Size(0, 13);
            this.lblSearchCollege.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_College_Training_Project.Properties.Resources.close_window;
            this.pictureBox1.Location = new System.Drawing.Point(759, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(34, 104);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // CollegeIDlabel
            // 
            this.CollegeIDlabel.AutoSize = true;
            this.CollegeIDlabel.Location = new System.Drawing.Point(189, 104);
            this.CollegeIDlabel.Name = "CollegeIDlabel";
            this.CollegeIDlabel.Size = new System.Drawing.Size(34, 13);
            this.CollegeIDlabel.TabIndex = 12;
            this.CollegeIDlabel.Text = "ID_lbl";
            // 
            // frmCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CollegeIDlabel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearchCollege);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridVCollege);
            this.Controls.Add(this.txtBoxCollegeName);
            this.Controls.Add(this.txtBoxCollegAddress);
            this.Controls.Add(this.lblCollegeAddress);
            this.Controls.Add(this.lblCollegeName);
            this.Name = "frmCollege";
            this.Text = "College";
            this.Load += new System.EventHandler(this.frmCollege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVCollege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.Label lblCollegeAddress;
        private System.Windows.Forms.TextBox txtBoxCollegAddress;
        private System.Windows.Forms.TextBox txtBoxCollegeName;
        private System.Windows.Forms.DataGridView dataGridVCollege;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearchCollege;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label CollegeIDlabel;
    }
}