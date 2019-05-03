namespace WinFormsDemoApp
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
            this.singleButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.checkboxLabel = new System.Windows.Forms.Label();
            this.subtractButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singleButton
            // 
            this.singleButton.Location = new System.Drawing.Point(15, 67);
            this.singleButton.Name = "singleButton";
            this.singleButton.Size = new System.Drawing.Size(75, 23);
            this.singleButton.TabIndex = 0;
            this.singleButton.Text = "Button";
            this.singleButton.UseVisualStyleBackColor = true;
            this.singleButton.Click += new System.EventHandler(this.singleButton_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(230, 71);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(78, 17);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Check Box";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonLabel
            // 
            this.buttonLabel.AutoSize = true;
            this.buttonLabel.Location = new System.Drawing.Point(12, 9);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(34, 13);
            this.buttonLabel.TabIndex = 2;
            this.buttonLabel.Text = "Tekst";
            // 
            // checkboxLabel
            // 
            this.checkboxLabel.AutoSize = true;
            this.checkboxLabel.Location = new System.Drawing.Point(227, 9);
            this.checkboxLabel.Name = "checkboxLabel";
            this.checkboxLabel.Size = new System.Drawing.Size(37, 13);
            this.checkboxLabel.TabIndex = 3;
            this.checkboxLabel.Text = "Status";
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(475, 67);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.operationalButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(475, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.operationalButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(506, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(13, 13);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 125);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.checkboxLabel);
            this.Controls.Add(this.buttonLabel);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.singleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singleButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label checkboxLabel;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label numberLabel;
    }
}

