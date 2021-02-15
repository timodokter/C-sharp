
namespace MusicalInstrument
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
            this.TrackVolume = new System.Windows.Forms.TrackBar();
            this.TrackFrequency = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackVolume
            // 
            this.TrackVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackVolume.Location = new System.Drawing.Point(12, 393);
            this.TrackVolume.Maximum = 100;
            this.TrackVolume.Name = "TrackVolume";
            this.TrackVolume.Size = new System.Drawing.Size(776, 45);
            this.TrackVolume.TabIndex = 0;
            // 
            // TrackFrequency
            // 
            this.TrackFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackFrequency.Location = new System.Drawing.Point(743, 12);
            this.TrackFrequency.Maximum = 1000;
            this.TrackFrequency.Minimum = 100;
            this.TrackFrequency.Name = "TrackFrequency";
            this.TrackFrequency.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackFrequency.Size = new System.Drawing.Size(45, 375);
            this.TrackFrequency.TabIndex = 1;
            this.TrackFrequency.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrackFrequency);
            this.Controls.Add(this.TrackVolume);
            this.Name = "Form1";
            this.Text = "Musical Instrument";
            ((System.ComponentModel.ISupportInitialize)(this.TrackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrackVolume;
        private System.Windows.Forms.TrackBar TrackFrequency;
    }
}

