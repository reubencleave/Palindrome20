namespace Palindrome
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
            this.btnarray = new System.Windows.Forms.Button();
            this.textToCheck = new System.Windows.Forms.TextBox();
            this.lbxpalindrome = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnarray
            // 
            this.btnarray.Location = new System.Drawing.Point(122, 125);
            this.btnarray.Name = "btnarray";
            this.btnarray.Size = new System.Drawing.Size(103, 56);
            this.btnarray.TabIndex = 0;
            this.btnarray.Text = "Check";
            this.btnarray.UseVisualStyleBackColor = true;
            this.btnarray.Click += new System.EventHandler(this.btnarray_Click);
            // 
            // textToCheck
            // 
            this.textToCheck.Location = new System.Drawing.Point(105, 78);
            this.textToCheck.Name = "textToCheck";
            this.textToCheck.Size = new System.Drawing.Size(151, 22);
            this.textToCheck.TabIndex = 1;
            // 
            // lbxpalindrome
            // 
            this.lbxpalindrome.FormattingEnabled = true;
            this.lbxpalindrome.ItemHeight = 16;
            this.lbxpalindrome.Location = new System.Drawing.Point(88, 213);
            this.lbxpalindrome.Name = "lbxpalindrome";
            this.lbxpalindrome.Size = new System.Drawing.Size(203, 84);
            this.lbxpalindrome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxpalindrome);
            this.Controls.Add(this.textToCheck);
            this.Controls.Add(this.btnarray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnarray;
        private System.Windows.Forms.TextBox textToCheck;
        private System.Windows.Forms.ListBox lbxpalindrome;
    }
}

