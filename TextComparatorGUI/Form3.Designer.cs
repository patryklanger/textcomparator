
namespace TextComparatorGUI
{
    partial class Form3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSave = new System.Windows.Forms.Button();
            this.fileCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(80, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(569, 354);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // fileSave
            // 
            this.fileSave.Location = new System.Drawing.Point(264, 387);
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(95, 29);
            this.fileSave.TabIndex = 1;
            this.fileSave.Text = "Save";
            this.fileSave.UseVisualStyleBackColor = true;
            // 
            // fileCancel
            // 
            this.fileCancel.Location = new System.Drawing.Point(380, 387);
            this.fileCancel.Name = "fileCancel";
            this.fileCancel.Size = new System.Drawing.Size(95, 29);
            this.fileCancel.TabIndex = 2;
            this.fileCancel.Text = "Cancel";
            this.fileCancel.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 447);
            this.Controls.Add(this.fileCancel);
            this.Controls.Add(this.fileSave);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button fileSave;
        private System.Windows.Forms.Button fileCancel;
    }
}