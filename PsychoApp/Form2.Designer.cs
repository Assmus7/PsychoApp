namespace PsychoApp
{
    partial class Form2
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
            this.btn2_1 = new System.Windows.Forms.Button();
            this.btn2_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2_1
            // 
            this.btn2_1.Location = new System.Drawing.Point(21, 53);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(94, 38);
            this.btn2_1.TabIndex = 0;
            this.btn2_1.Text = "закрыть";
            this.btn2_1.UseVisualStyleBackColor = true;
            this.btn2_1.Click += new System.EventHandler(this.Btn2_1_Click);
            // 
            // btn2_2
            // 
            this.btn2_2.Location = new System.Drawing.Point(142, 53);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(94, 38);
            this.btn2_2.TabIndex = 1;
            this.btn2_2.Text = "повтор";
            this.btn2_2.UseVisualStyleBackColor = true;
            this.btn2_2.Click += new System.EventHandler(this.Btn2_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(261, 116);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2_2);
            this.Controls.Add(this.btn2_1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2_1;
        private System.Windows.Forms.Button btn2_2;
        private System.Windows.Forms.Label label1;
    }
}