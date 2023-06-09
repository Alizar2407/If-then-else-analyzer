namespace Analyzer
{
    partial class MainForm
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
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.syntaxErrorsTextBox = new System.Windows.Forms.TextBox();
            this.semanticsErrorsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextbox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextbox.Location = new System.Drawing.Point(50, 50);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(700, 29);
            this.inputTextbox.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.Location = new System.Drawing.Point(50, 393);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(700, 30);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // syntaxErrorsTextBox
            // 
            this.syntaxErrorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.syntaxErrorsTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntaxErrorsTextBox.Location = new System.Drawing.Point(50, 120);
            this.syntaxErrorsTextBox.Multiline = true;
            this.syntaxErrorsTextBox.Name = "syntaxErrorsTextBox";
            this.syntaxErrorsTextBox.ReadOnly = true;
            this.syntaxErrorsTextBox.Size = new System.Drawing.Size(300, 220);
            this.syntaxErrorsTextBox.TabIndex = 2;
            // 
            // semanticsErrorsTextBox
            // 
            this.semanticsErrorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.semanticsErrorsTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.semanticsErrorsTextBox.Location = new System.Drawing.Point(450, 120);
            this.semanticsErrorsTextBox.Multiline = true;
            this.semanticsErrorsTextBox.Name = "semanticsErrorsTextBox";
            this.semanticsErrorsTextBox.ReadOnly = true;
            this.semanticsErrorsTextBox.Size = new System.Drawing.Size(300, 220);
            this.semanticsErrorsTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semanticsErrorsTextBox);
            this.Controls.Add(this.syntaxErrorsTextBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.inputTextbox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox syntaxErrorsTextBox;
        private System.Windows.Forms.TextBox semanticsErrorsTextBox;
    }
}

