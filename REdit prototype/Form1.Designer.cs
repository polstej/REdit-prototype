namespace REdit_prototype
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
            this.lblWord = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGrammar = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDisplayWords = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtGrammar = new System.Windows.Forms.TextBox();
            this.rtbDisplayWords = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(35, 40);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(60, 25);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(35, 116);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 25);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Count";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 193);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(136, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DateLastUsed";
            // 
            // lblGrammar
            // 
            this.lblGrammar.AutoSize = true;
            this.lblGrammar.Location = new System.Drawing.Point(35, 274);
            this.lblGrammar.Name = "lblGrammar";
            this.lblGrammar.Size = new System.Drawing.Size(135, 25);
            this.lblGrammar.TabIndex = 3;
            this.lblGrammar.Text = "Grammar type";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(177, 335);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(114, 66);
            this.btnAddWord.TabIndex = 4;
            this.btnAddWord.Text = "Add Word Object";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 115);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send List of Word Objects to File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDisplayWords
            // 
            this.btnDisplayWords.Location = new System.Drawing.Point(554, 597);
            this.btnDisplayWords.Name = "btnDisplayWords";
            this.btnDisplayWords.Size = new System.Drawing.Size(165, 115);
            this.btnDisplayWords.TabIndex = 6;
            this.btnDisplayWords.Text = "Display list of word objects";
            this.btnDisplayWords.UseVisualStyleBackColor = true;
            this.btnDisplayWords.Click += new System.EventHandler(this.btnDisplayWords_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(191, 40);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 29);
            this.txtWord.TabIndex = 7;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(191, 112);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 29);
            this.txtCount.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(191, 189);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 29);
            this.txtDate.TabIndex = 9;
            // 
            // txtGrammar
            // 
            this.txtGrammar.Location = new System.Drawing.Point(191, 270);
            this.txtGrammar.Name = "txtGrammar";
            this.txtGrammar.Size = new System.Drawing.Size(100, 29);
            this.txtGrammar.TabIndex = 10;
            // 
            // rtbDisplayWords
            // 
            this.rtbDisplayWords.Location = new System.Drawing.Point(403, 37);
            this.rtbDisplayWords.Name = "rtbDisplayWords";
            this.rtbDisplayWords.Size = new System.Drawing.Size(633, 523);
            this.rtbDisplayWords.TabIndex = 0;
            this.rtbDisplayWords.Text = "";
            this.rtbDisplayWords.TextChanged += new System.EventHandler(this.rtbDisplayWords_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 724);
            this.Controls.Add(this.rtbDisplayWords);
            this.Controls.Add(this.txtGrammar);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnDisplayWords);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.lblGrammar);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGrammar;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDisplayWords;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtGrammar;
        private System.Windows.Forms.RichTextBox rtbDisplayWords;
    }
}

