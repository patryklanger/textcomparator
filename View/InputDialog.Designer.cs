
namespace TextComparatorGUI
{
    partial class InputDialog
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(79, 64);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 23);
            this.textBox.TabIndex = 0;
            this.textBox.UseWaitCursor = true;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(21, 21);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(38, 15);
            this.contentLabel.TabIndex = 1;
            this.contentLabel.Text = "label1";
            this.contentLabel.Click += new System.EventHandler(this.contentLabel_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(90, 123);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Accept";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 191);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(271, 230);
            this.MinimumSize = new System.Drawing.Size(271, 230);
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InputDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button okButton;
    }
}