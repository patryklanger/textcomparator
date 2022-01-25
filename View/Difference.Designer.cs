
namespace TextComparatorGUI
{
    partial class Difference
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
            this.firstTextBox = new System.Windows.Forms.RichTextBox();
            this.secondTextBox = new System.Windows.Forms.RichTextBox();
            this.diffPrev = new System.Windows.Forms.Button();
            this.diffNext = new System.Windows.Forms.Button();
            this.diffConst = new System.Windows.Forms.Label();
            this.diffCount = new System.Windows.Forms.Label();
            this.diffJump = new System.Windows.Forms.Button();
            this.diffFirst = new System.Windows.Forms.Button();
            this.diffSecond = new System.Windows.Forms.Button();
            this.diffDelete = new System.Windows.Forms.Button();
            this.diffFirstRest = new System.Windows.Forms.Button();
            this.diffSecondRest = new System.Windows.Forms.Button();
            this.diffDeleteRest = new System.Windows.Forms.Button();
            this.diffDone = new System.Windows.Forms.Button();
            this.backToOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(10, 26);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.ReadOnly = true;
            this.firstTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.firstTextBox.Size = new System.Drawing.Size(341, 488);
            this.firstTextBox.TabIndex = 0;
            this.firstTextBox.Text = "";
            this.firstTextBox.UseWaitCursor = true;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(525, 26);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.ReadOnly = true;
            this.secondTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.secondTextBox.Size = new System.Drawing.Size(368, 488);
            this.secondTextBox.TabIndex = 1;
            this.secondTextBox.Text = "";
            this.secondTextBox.UseWaitCursor = true;
            // 
            // diffPrev
            // 
            this.diffPrev.Location = new System.Drawing.Point(396, 140);
            this.diffPrev.Name = "diffPrev";
            this.diffPrev.Size = new System.Drawing.Size(75, 26);
            this.diffPrev.TabIndex = 2;
            this.diffPrev.Text = "Previous";
            this.diffPrev.UseVisualStyleBackColor = true;
            this.diffPrev.UseWaitCursor = true;
            this.diffPrev.Click += new System.EventHandler(this.diffPrev_Click);
            // 
            // diffNext
            // 
            this.diffNext.Location = new System.Drawing.Point(396, 238);
            this.diffNext.Name = "diffNext";
            this.diffNext.Size = new System.Drawing.Size(75, 26);
            this.diffNext.TabIndex = 3;
            this.diffNext.Text = "Next";
            this.diffNext.UseVisualStyleBackColor = true;
            this.diffNext.UseWaitCursor = true;
            this.diffNext.Click += new System.EventHandler(this.diffNext_Click);
            // 
            // diffConst
            // 
            this.diffConst.AutoSize = true;
            this.diffConst.Location = new System.Drawing.Point(384, 193);
            this.diffConst.Name = "diffConst";
            this.diffConst.Size = new System.Drawing.Size(64, 15);
            this.diffConst.TabIndex = 4;
            this.diffConst.Text = "Difference:";
            this.diffConst.UseWaitCursor = true;
            // 
            // diffCount
            // 
            this.diffCount.AutoSize = true;
            this.diffCount.Location = new System.Drawing.Point(457, 193);
            this.diffCount.Name = "diffCount";
            this.diffCount.Size = new System.Drawing.Size(24, 15);
            this.diffCount.TabIndex = 5;
            this.diffCount.Text = "x/y";
            this.diffCount.UseWaitCursor = true;
            // 
            // diffJump
            // 
            this.diffJump.Location = new System.Drawing.Point(396, 295);
            this.diffJump.Name = "diffJump";
            this.diffJump.Size = new System.Drawing.Size(75, 26);
            this.diffJump.TabIndex = 6;
            this.diffJump.Text = "Jump to";
            this.diffJump.UseVisualStyleBackColor = true;
            this.diffJump.UseWaitCursor = true;
            this.diffJump.Click += new System.EventHandler(this.diffJump_Click);
            // 
            // diffFirst
            // 
            this.diffFirst.Location = new System.Drawing.Point(360, 350);
            this.diffFirst.Name = "diffFirst";
            this.diffFirst.Size = new System.Drawing.Size(35, 26);
            this.diffFirst.TabIndex = 7;
            this.diffFirst.Text = "<-";
            this.diffFirst.UseVisualStyleBackColor = true;
            this.diffFirst.UseWaitCursor = true;
            // 
            // diffSecond
            // 
            this.diffSecond.Location = new System.Drawing.Point(468, 350);
            this.diffSecond.Name = "diffSecond";
            this.diffSecond.Size = new System.Drawing.Size(35, 26);
            this.diffSecond.TabIndex = 8;
            this.diffSecond.Text = "->";
            this.diffSecond.UseVisualStyleBackColor = true;
            this.diffSecond.UseWaitCursor = true;
            // 
            // diffDelete
            // 
            this.diffDelete.Location = new System.Drawing.Point(416, 350);
            this.diffDelete.Name = "diffDelete";
            this.diffDelete.Size = new System.Drawing.Size(35, 26);
            this.diffDelete.TabIndex = 9;
            this.diffDelete.Text = "X";
            this.diffDelete.UseVisualStyleBackColor = true;
            this.diffDelete.UseWaitCursor = true;
            // 
            // diffFirstRest
            // 
            this.diffFirstRest.Location = new System.Drawing.Point(360, 392);
            this.diffFirstRest.Name = "diffFirstRest";
            this.diffFirstRest.Size = new System.Drawing.Size(35, 26);
            this.diffFirstRest.TabIndex = 10;
            this.diffFirstRest.Text = "<<-";
            this.diffFirstRest.UseVisualStyleBackColor = true;
            this.diffFirstRest.UseWaitCursor = true;
            // 
            // diffSecondRest
            // 
            this.diffSecondRest.Location = new System.Drawing.Point(468, 392);
            this.diffSecondRest.Name = "diffSecondRest";
            this.diffSecondRest.Size = new System.Drawing.Size(35, 26);
            this.diffSecondRest.TabIndex = 11;
            this.diffSecondRest.Text = "->>";
            this.diffSecondRest.UseVisualStyleBackColor = true;
            this.diffSecondRest.UseWaitCursor = true;
            // 
            // diffDeleteRest
            // 
            this.diffDeleteRest.Location = new System.Drawing.Point(416, 392);
            this.diffDeleteRest.Name = "diffDeleteRest";
            this.diffDeleteRest.Size = new System.Drawing.Size(35, 26);
            this.diffDeleteRest.TabIndex = 12;
            this.diffDeleteRest.Text = "(X)";
            this.diffDeleteRest.UseVisualStyleBackColor = true;
            this.diffDeleteRest.UseWaitCursor = true;
            // 
            // diffDone
            // 
            this.diffDone.Location = new System.Drawing.Point(396, 445);
            this.diffDone.Name = "diffDone";
            this.diffDone.Size = new System.Drawing.Size(75, 26);
            this.diffDone.TabIndex = 13;
            this.diffDone.Text = "Done";
            this.diffDone.UseVisualStyleBackColor = true;
            this.diffDone.UseWaitCursor = true;
            this.diffDone.Click += new System.EventHandler(this.diffDone_Click);
            // 
            // backToOpenFile
            // 
            this.backToOpenFile.Location = new System.Drawing.Point(392, 499);
            this.backToOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backToOpenFile.Name = "backToOpenFile";
            this.backToOpenFile.Size = new System.Drawing.Size(82, 22);
            this.backToOpenFile.TabIndex = 14;
            this.backToOpenFile.Text = "Back";
            this.backToOpenFile.UseVisualStyleBackColor = true;
            this.backToOpenFile.UseWaitCursor = true;
            this.backToOpenFile.Click += new System.EventHandler(this.backToOpenFile_Click);
            // 
            // Difference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 577);
            this.Controls.Add(this.backToOpenFile);
            this.Controls.Add(this.diffDone);
            this.Controls.Add(this.diffDeleteRest);
            this.Controls.Add(this.diffSecondRest);
            this.Controls.Add(this.diffFirstRest);
            this.Controls.Add(this.diffDelete);
            this.Controls.Add(this.diffSecond);
            this.Controls.Add(this.diffFirst);
            this.Controls.Add(this.diffJump);
            this.Controls.Add(this.diffCount);
            this.Controls.Add(this.diffConst);
            this.Controls.Add(this.diffNext);
            this.Controls.Add(this.diffPrev);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Enabled = false;
            this.Name = "Difference";
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Difference_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox firstTextBox;
        private System.Windows.Forms.RichTextBox secondTextBox;
        private System.Windows.Forms.Button diffPrev;
        private System.Windows.Forms.Button diffNext;
        private System.Windows.Forms.Label diffConst;
        private System.Windows.Forms.Label diffCount;
        private System.Windows.Forms.Button diffJump;
        private System.Windows.Forms.Button diffFirst;
        private System.Windows.Forms.Button diffSecond;
        private System.Windows.Forms.Button diffDelete;
        private System.Windows.Forms.Button diffFirstRest;
        private System.Windows.Forms.Button diffSecondRest;
        private System.Windows.Forms.Button diffDeleteRest;
        private System.Windows.Forms.Button diffDone;
        private System.Windows.Forms.Button backToOpenFile;
    }
}