namespace bmi1
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
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_bmi = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(263, 174);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(141, 20);
            this.textBox_weight.TabIndex = 0;
            this.textBox_weight.TextChanged += new System.EventHandler(this.bmi_chishuv);
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(163, 181);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(44, 13);
            this.label_weight.TabIndex = 1;
            this.label_weight.Text = "Weight:";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(163, 264);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(39, 13);
            this.label_height.TabIndex = 2;
            this.label_height.Text = "height:";
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(263, 257);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(141, 20);
            this.textBox_height.TabIndex = 3;
            this.textBox_height.TextChanged += new System.EventHandler(this.bmi_chishuv);
            // 
            // label_bmi
            // 
            this.label_bmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_bmi.Location = new System.Drawing.Point(217, 356);
            this.label_bmi.Name = "label_bmi";
            this.label_bmi.Size = new System.Drawing.Size(201, 30);
            this.label_bmi.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(145, 373);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 13);
            this.label.TabIndex = 5;
            this.label.Text = "BMI result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 468);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label_bmi);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.textBox_weight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label_bmi;
        private System.Windows.Forms.Label label;
    }
}

