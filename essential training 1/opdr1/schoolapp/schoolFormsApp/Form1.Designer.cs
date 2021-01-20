namespace schoolFormsApp
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.btnpushtotest = new System.Windows.Forms.Button();
            this.btntesteacher = new System.Windows.Forms.Button();
            this.btnteststudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Name";
            this.label1.Text = "School Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // addres
            // 
            this.addres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addres.Location = new System.Drawing.Point(36, 60);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(120, 20);
            this.addres.TabIndex = 2;
            this.addres.Text = "Addres";
            this.addres.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(36, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(36, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(36, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(36, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Twitter";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(162, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTwitter.Location = new System.Drawing.Point(162, 217);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(120, 26);
            this.txtTwitter.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumber.Location = new System.Drawing.Point(162, 185);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 26);
            this.txtNumber.TabIndex = 10;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZip.Location = new System.Drawing.Point(162, 153);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(120, 26);
            this.txtZip.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtState.Location = new System.Drawing.Point(162, 121);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(120, 26);
            this.txtState.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCity.Location = new System.Drawing.Point(162, 89);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 26);
            this.txtCity.TabIndex = 13;
            // 
            // txtAddres
            // 
            this.txtAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddres.Location = new System.Drawing.Point(162, 57);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(120, 26);
            this.txtAddres.TabIndex = 14;
            // 
            // btnpushtotest
            // 
            this.btnpushtotest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnpushtotest.Location = new System.Drawing.Point(37, 260);
            this.btnpushtotest.Name = "btnpushtotest";
            this.btnpushtotest.Size = new System.Drawing.Size(261, 70);
            this.btnpushtotest.TabIndex = 15;
            this.btnpushtotest.Text = "push to test";
            this.btnpushtotest.UseVisualStyleBackColor = true;
            this.btnpushtotest.Click += new System.EventHandler(this.btnpushtotest_Click);
            // 
            // btntesteacher
            // 
            this.btntesteacher.Location = new System.Drawing.Point(401, 55);
            this.btntesteacher.Name = "btntesteacher";
            this.btntesteacher.Size = new System.Drawing.Size(289, 88);
            this.btntesteacher.TabIndex = 16;
            this.btntesteacher.Text = "test teacher";
            this.btntesteacher.UseVisualStyleBackColor = true;
            this.btntesteacher.Click += new System.EventHandler(this.btntesteacher_Click);
            // 
            // btnteststudent
            // 
            this.btnteststudent.Location = new System.Drawing.Point(407, 186);
            this.btnteststudent.Name = "btnteststudent";
            this.btnteststudent.Size = new System.Drawing.Size(343, 132);
            this.btnteststudent.TabIndex = 17;
            this.btnteststudent.Text = "test student";
            this.btnteststudent.UseVisualStyleBackColor = true;
            this.btnteststudent.Click += new System.EventHandler(this.btnteststudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 490);
            this.Controls.Add(this.btnteststudent);
            this.Controls.Add(this.btntesteacher);
            this.Controls.Add(this.btnpushtotest);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btntesteacher;
        private System.Windows.Forms.Button btnteststudent;

        private System.Windows.Forms.Button btnpushtotest;

        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}