namespace _13__Form_Pengaturan_Warna
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
            this.labelInputData = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(13, 13);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(75, 17);
            this.labelInputData.TabIndex = 0;
            this.labelInputData.Text = "Input data:";
            this.labelInputData.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 34);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(306, 22);
            this.textBox.TabIndex = 1;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 84);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Proses";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 128);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 29);
            this.label.TabIndex = 3;
            this.label.Text = "[EMPTY]";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelInputData);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Nama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;
    }
}

