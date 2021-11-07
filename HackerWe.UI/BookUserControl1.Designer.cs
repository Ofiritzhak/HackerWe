namespace HackerWe.UI
{
    partial class BookUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNumOfBorrowed = new System.Windows.Forms.TextBox();
            this.txtNumOfCopies = new System.Windows.Forms.TextBox();
            this.txtNumOfPage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(302, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 27);
            this.txtID.TabIndex = 0;
            // 
            // txtNumOfBorrowed
            // 
            this.txtNumOfBorrowed.Location = new System.Drawing.Point(302, 299);
            this.txtNumOfBorrowed.Name = "txtNumOfBorrowed";
            this.txtNumOfBorrowed.Size = new System.Drawing.Size(204, 27);
            this.txtNumOfBorrowed.TabIndex = 1;
            // 
            // txtNumOfCopies
            // 
            this.txtNumOfCopies.Location = new System.Drawing.Point(302, 251);
            this.txtNumOfCopies.Name = "txtNumOfCopies";
            this.txtNumOfCopies.Size = new System.Drawing.Size(204, 27);
            this.txtNumOfCopies.TabIndex = 2;
            // 
            // txtNumOfPage
            // 
            this.txtNumOfPage.Location = new System.Drawing.Point(302, 203);
            this.txtNumOfPage.Name = "txtNumOfPage";
            this.txtNumOfPage.Size = new System.Drawing.Size(204, 27);
            this.txtNumOfPage.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(302, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(302, 102);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(204, 27);
            this.txtAuthor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number Of Pages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number Of Copies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number Of Borrowed Out";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Published";
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Location = new System.Drawing.Point(302, 343);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(204, 27);
            this.dtpDatePublished.TabIndex = 13;
            // 
            // BookUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumOfPage);
            this.Controls.Add(this.txtNumOfCopies);
            this.Controls.Add(this.txtNumOfBorrowed);
            this.Controls.Add(this.txtID);
            this.Name = "BookUserControl1";
            this.Size = new System.Drawing.Size(779, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNumOfBorrowed;
        private System.Windows.Forms.TextBox txtNumOfCopies;
        private System.Windows.Forms.TextBox txtNumOfPage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
    }
}
