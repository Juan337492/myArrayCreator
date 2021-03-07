
namespace MyArray
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
            this.addValueTxtBox = new System.Windows.Forms.TextBox();
            this.displayValuesBtn = new System.Windows.Forms.Button();
            this.addValueBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addValueTxtBox
            // 
            this.addValueTxtBox.ForeColor = System.Drawing.Color.Black;
            this.addValueTxtBox.Location = new System.Drawing.Point(267, 133);
            this.addValueTxtBox.Name = "addValueTxtBox";
            this.addValueTxtBox.Size = new System.Drawing.Size(205, 20);
            this.addValueTxtBox.TabIndex = 0;
            this.addValueTxtBox.Text = "enter  number";
            // 
            // displayValuesBtn
            // 
            this.displayValuesBtn.Location = new System.Drawing.Point(312, 233);
            this.displayValuesBtn.Name = "displayValuesBtn";
            this.displayValuesBtn.Size = new System.Drawing.Size(145, 42);
            this.displayValuesBtn.TabIndex = 1;
            this.displayValuesBtn.Text = "Display Values";
            this.displayValuesBtn.UseVisualStyleBackColor = true;
            this.displayValuesBtn.Click += new System.EventHandler(this.displayValuesBtn_Click);
            // 
            // addValueBtn
            // 
            this.addValueBtn.Location = new System.Drawing.Point(126, 233);
            this.addValueBtn.Name = "addValueBtn";
            this.addValueBtn.Size = new System.Drawing.Size(145, 42);
            this.addValueBtn.TabIndex = 2;
            this.addValueBtn.Text = "Add Value";
            this.addValueBtn.UseVisualStyleBackColor = true;
            this.addValueBtn.Click += new System.EventHandler(this.addValueBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(494, 233);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 42);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addValueBtn);
            this.Controls.Add(this.displayValuesBtn);
            this.Controls.Add(this.addValueTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addValueTxtBox;
        private System.Windows.Forms.Button displayValuesBtn;
        private System.Windows.Forms.Button addValueBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

