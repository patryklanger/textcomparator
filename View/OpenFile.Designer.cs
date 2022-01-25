
namespace TextComparatorGUI
{
    partial class OpenFile
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
            this.firstFileLabel = new System.Windows.Forms.Label();
            this.firstFileTextBox = new System.Windows.Forms.TextBox();
            this.secondFileTextBox = new System.Windows.Forms.TextBox();
            this.secondFileLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.firstFileButton = new System.Windows.Forms.Button();
            this.compareButton = new System.Windows.Forms.Button();
            this.secondFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // firstFileLabel
            // 
            this.firstFileLabel.AutoSize = true;
            this.firstFileLabel.Location = new System.Drawing.Point(12, 38);
            this.firstFileLabel.Name = "firstFileLabel";
            this.firstFileLabel.Size = new System.Drawing.Size(61, 20);
            this.firstFileLabel.TabIndex = 0;
            this.firstFileLabel.Text = "First file";
            // 
            // firstFileTextBox
            // 
            this.firstFileTextBox.Location = new System.Drawing.Point(101, 35);
            this.firstFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstFileTextBox.Name = "firstFileTextBox";
            this.firstFileTextBox.ReadOnly = true;
            this.firstFileTextBox.Size = new System.Drawing.Size(214, 27);
            this.firstFileTextBox.TabIndex = 1;
            // 
            // secondFileTextBox
            // 
            this.secondFileTextBox.Location = new System.Drawing.Point(101, 75);
            this.secondFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondFileTextBox.Name = "secondFileTextBox";
            this.secondFileTextBox.ReadOnly = true;
            this.secondFileTextBox.Size = new System.Drawing.Size(214, 27);
            this.secondFileTextBox.TabIndex = 2;
            // 
            // secondFileLabel
            // 
            this.secondFileLabel.AutoSize = true;
            this.secondFileLabel.Location = new System.Drawing.Point(12, 78);
            this.secondFileLabel.Name = "secondFileLabel";
            this.secondFileLabel.Size = new System.Drawing.Size(83, 20);
            this.secondFileLabel.TabIndex = 3;
            this.secondFileLabel.Text = "Second file";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(174, 20);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Choose texts to compare";
            // 
            // firstFileButton
            // 
            this.firstFileButton.Location = new System.Drawing.Point(321, 34);
            this.firstFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstFileButton.Name = "firstFileButton";
            this.firstFileButton.Size = new System.Drawing.Size(94, 29);
            this.firstFileButton.TabIndex = 5;
            this.firstFileButton.Text = "Open FIle";
            this.firstFileButton.UseVisualStyleBackColor = true;
            this.firstFileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // compareButton
            // 
            this.compareButton.Enabled = false;
            this.compareButton.Location = new System.Drawing.Point(158, 120);
            this.compareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(94, 29);
            this.compareButton.TabIndex = 6;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // secondFileButton
            // 
            this.secondFileButton.Location = new System.Drawing.Point(321, 74);
            this.secondFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondFileButton.Name = "secondFileButton";
            this.secondFileButton.Size = new System.Drawing.Size(94, 29);
            this.secondFileButton.TabIndex = 7;
            this.secondFileButton.Text = "Open file";
            this.secondFileButton.UseVisualStyleBackColor = true;
            this.secondFileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 182);
            this.Controls.Add(this.secondFileButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.firstFileButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.secondFileLabel);
            this.Controls.Add(this.secondFileTextBox);
            this.Controls.Add(this.firstFileTextBox);
            this.Controls.Add(this.firstFileLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OpenFile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstFileLabel;
        private System.Windows.Forms.TextBox firstFileTextBox;
        private System.Windows.Forms.TextBox secondFileTextBox;
        private System.Windows.Forms.Label secondFileLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button firstFileButton;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button secondFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

