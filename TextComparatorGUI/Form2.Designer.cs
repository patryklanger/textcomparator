
namespace TextComparatorGUI
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(389, 521);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(600, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(420, 521);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // diffPrev
            // 
            this.diffPrev.Location = new System.Drawing.Point(452, 149);
            this.diffPrev.Name = "diffPrev";
            this.diffPrev.Size = new System.Drawing.Size(86, 28);
            this.diffPrev.TabIndex = 2;
            this.diffPrev.Text = "Previous";
            this.diffPrev.UseVisualStyleBackColor = true;
            // 
            // diffNext
            // 
            this.diffNext.Location = new System.Drawing.Point(452, 254);
            this.diffNext.Name = "diffNext";
            this.diffNext.Size = new System.Drawing.Size(86, 28);
            this.diffNext.TabIndex = 3;
            this.diffNext.Text = "Next";
            this.diffNext.UseVisualStyleBackColor = true;
            // 
            // diffConst
            // 
            this.diffConst.AutoSize = true;
            this.diffConst.Location = new System.Drawing.Point(449, 208);
            this.diffConst.Name = "diffConst";
            this.diffConst.Size = new System.Drawing.Size(77, 17);
            this.diffConst.TabIndex = 4;
            this.diffConst.Text = "Difference:";
            // 
            // diffCount
            // 
            this.diffCount.AutoSize = true;
            this.diffCount.Location = new System.Drawing.Point(532, 208);
            this.diffCount.Name = "diffCount";
            this.diffCount.Size = new System.Drawing.Size(25, 17);
            this.diffCount.TabIndex = 5;
            this.diffCount.Text = "x/y";
            // 
            // diffJump
            // 
            this.diffJump.Location = new System.Drawing.Point(452, 314);
            this.diffJump.Name = "diffJump";
            this.diffJump.Size = new System.Drawing.Size(86, 28);
            this.diffJump.TabIndex = 6;
            this.diffJump.Text = "Jump to";
            this.diffJump.UseVisualStyleBackColor = true;
            // 
            // diffFirst
            // 
            this.diffFirst.Location = new System.Drawing.Point(412, 373);
            this.diffFirst.Name = "diffFirst";
            this.diffFirst.Size = new System.Drawing.Size(40, 28);
            this.diffFirst.TabIndex = 7;
            this.diffFirst.Text = "<-";
            this.diffFirst.UseVisualStyleBackColor = true;
            // 
            // diffSecond
            // 
            this.diffSecond.Location = new System.Drawing.Point(535, 373);
            this.diffSecond.Name = "diffSecond";
            this.diffSecond.Size = new System.Drawing.Size(40, 28);
            this.diffSecond.TabIndex = 8;
            this.diffSecond.Text = "->";
            this.diffSecond.UseVisualStyleBackColor = true;
            // 
            // diffDelete
            // 
            this.diffDelete.Location = new System.Drawing.Point(475, 373);
            this.diffDelete.Name = "diffDelete";
            this.diffDelete.Size = new System.Drawing.Size(40, 28);
            this.diffDelete.TabIndex = 9;
            this.diffDelete.Text = "X";
            this.diffDelete.UseVisualStyleBackColor = true;
            // 
            // diffFirstRest
            // 
            this.diffFirstRest.Location = new System.Drawing.Point(412, 418);
            this.diffFirstRest.Name = "diffFirstRest";
            this.diffFirstRest.Size = new System.Drawing.Size(40, 28);
            this.diffFirstRest.TabIndex = 10;
            this.diffFirstRest.Text = "<<-";
            this.diffFirstRest.UseVisualStyleBackColor = true;
            // 
            // diffSecondRest
            // 
            this.diffSecondRest.Location = new System.Drawing.Point(535, 418);
            this.diffSecondRest.Name = "diffSecondRest";
            this.diffSecondRest.Size = new System.Drawing.Size(40, 28);
            this.diffSecondRest.TabIndex = 11;
            this.diffSecondRest.Text = "->>";
            this.diffSecondRest.UseVisualStyleBackColor = true;
            // 
            // diffDeleteRest
            // 
            this.diffDeleteRest.Location = new System.Drawing.Point(475, 418);
            this.diffDeleteRest.Name = "diffDeleteRest";
            this.diffDeleteRest.Size = new System.Drawing.Size(40, 28);
            this.diffDeleteRest.TabIndex = 12;
            this.diffDeleteRest.Text = "(X)";
            this.diffDeleteRest.UseVisualStyleBackColor = true;
            // 
            // diffDone
            // 
            this.diffDone.Location = new System.Drawing.Point(452, 489);
            this.diffDone.Name = "diffDone";
            this.diffDone.Size = new System.Drawing.Size(86, 28);
            this.diffDone.TabIndex = 13;
            this.diffDone.Text = "Done";
            this.diffDone.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 615);
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
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
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
    }
}