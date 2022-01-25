
namespace TextComparatorGUI
{
    partial class Result
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileSave = new System.Windows.Forms.Button();
            this.fileCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(80, 15);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(569, 442);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // fileSave
            // 
            this.fileSave.Location = new System.Drawing.Point(264, 484);
            this.fileSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(95, 36);
            this.fileSave.TabIndex = 1;
            this.fileSave.Text = "Save";
            this.fileSave.UseVisualStyleBackColor = true;
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileCancel
            // 
            this.fileCancel.Location = new System.Drawing.Point(380, 484);
            this.fileCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileCancel.Name = "fileCancel";
            this.fileCancel.Size = new System.Drawing.Size(95, 36);
            this.fileCancel.TabIndex = 2;
            this.fileCancel.Text = "Cancel";
            this.fileCancel.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 559);
            this.Controls.Add(this.fileCancel);
            this.Controls.Add(this.fileSave);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Result";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button fileSave;
        private System.Windows.Forms.Button fileCancel;
    }
}