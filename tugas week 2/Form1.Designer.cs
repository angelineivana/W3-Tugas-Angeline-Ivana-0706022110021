
namespace tugas_week_2
{
    partial class FormPengaturanWarna
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
            this.LabelInput = new System.Windows.Forms.Label();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.BtnProses = new System.Windows.Forms.Button();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(20, 19);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(105, 25);
            this.LabelInput.TabIndex = 0;
            this.LabelInput.Text = "Input Data :";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(24, 47);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(456, 31);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // BtnProses
            // 
            this.BtnProses.Location = new System.Drawing.Point(24, 84);
            this.BtnProses.Name = "BtnProses";
            this.BtnProses.Size = new System.Drawing.Size(112, 34);
            this.BtnProses.TabIndex = 2;
            this.BtnProses.Text = "Proses";
            this.BtnProses.UseVisualStyleBackColor = true;
            this.BtnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelOutput.Location = new System.Drawing.Point(24, 160);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(134, 36);
            this.LabelOutput.TabIndex = 3;
            this.LabelOutput.Text = "[EMPTY]";
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 246);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.BtnProses);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.LabelInput);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button BtnProses;
        private System.Windows.Forms.Label LabelOutput;
    }
}

