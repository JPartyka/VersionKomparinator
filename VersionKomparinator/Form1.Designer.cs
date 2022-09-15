namespace VersionKomparinator
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKomparinator = new System.Windows.Forms.Label();
            this.lblResultsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKomparinator
            // 
            this.lblKomparinator.AutoSize = true;
            this.lblKomparinator.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKomparinator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblKomparinator.Location = new System.Drawing.Point(25, 25);
            this.lblKomparinator.Name = "lblKomparinator";
            this.lblKomparinator.Size = new System.Drawing.Size(372, 45);
            this.lblKomparinator.TabIndex = 0;
            this.lblKomparinator.Text = "Version KomPAIRinator";
            // 
            // lblResultsLabel
            // 
            this.lblResultsLabel.AutoSize = true;
            this.lblResultsLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResultsLabel.Location = new System.Drawing.Point(515, 55);
            this.lblResultsLabel.Name = "lblResultsLabel";
            this.lblResultsLabel.Size = new System.Drawing.Size(0, 86);
            this.lblResultsLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(671, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "KomPAIR 2 point 3.14.Five versus 1.2.3.4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(671, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "KomPAIR 5.2 to 19 point seven point 2.53";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(200, 344);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(59, 25);
            this.labelResults.TabIndex = 5;
            this.labelResults.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultsLabel);
            this.Controls.Add(this.lblKomparinator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKomparinator;
        private Label lblResultsLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelResults;
    }
}