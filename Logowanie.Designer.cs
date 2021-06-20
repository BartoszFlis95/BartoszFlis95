
namespace Zadanie5YT
{
    partial class Logowanie
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
            this.Logowanie_Button = new System.Windows.Forms.Button();
            this.Rejestracja_Button = new System.Windows.Forms.Button();
            this.Login1_Label = new System.Windows.Forms.Label();
            this.Haslo1_Label = new System.Windows.Forms.Label();
            this.Login1_TextBox = new System.Windows.Forms.TextBox();
            this.Haslo1_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Logowanie_Button
            // 
            this.Logowanie_Button.Location = new System.Drawing.Point(46, 207);
            this.Logowanie_Button.Name = "Logowanie_Button";
            this.Logowanie_Button.Size = new System.Drawing.Size(95, 42);
            this.Logowanie_Button.TabIndex = 0;
            this.Logowanie_Button.Text = "ZALOGUJ";
            this.Logowanie_Button.UseVisualStyleBackColor = true;
            this.Logowanie_Button.Click += new System.EventHandler(this.Logowanie_Button_Click);
            // 
            // Rejestracja_Button
            // 
            this.Rejestracja_Button.Location = new System.Drawing.Point(46, 278);
            this.Rejestracja_Button.Name = "Rejestracja_Button";
            this.Rejestracja_Button.Size = new System.Drawing.Size(95, 38);
            this.Rejestracja_Button.TabIndex = 1;
            this.Rejestracja_Button.Text = "REJESTRACJA";
            this.Rejestracja_Button.UseVisualStyleBackColor = true;
            this.Rejestracja_Button.Click += new System.EventHandler(this.Rejestracja_Button_Click);
            // 
            // Login1_Label
            // 
            this.Login1_Label.AutoSize = true;
            this.Login1_Label.Location = new System.Drawing.Point(40, 89);
            this.Login1_Label.Name = "Login1_Label";
            this.Login1_Label.Size = new System.Drawing.Size(42, 15);
            this.Login1_Label.TabIndex = 2;
            this.Login1_Label.Text = "LOGIN";
            // 
            // Haslo1_Label
            // 
            this.Haslo1_Label.AutoSize = true;
            this.Haslo1_Label.Location = new System.Drawing.Point(40, 143);
            this.Haslo1_Label.Name = "Haslo1_Label";
            this.Haslo1_Label.Size = new System.Drawing.Size(45, 15);
            this.Haslo1_Label.TabIndex = 3;
            this.Haslo1_Label.Text = "HASLO";
            // 
            // Login1_TextBox
            // 
            this.Login1_TextBox.Location = new System.Drawing.Point(41, 107);
            this.Login1_TextBox.Name = "Login1_TextBox";
            this.Login1_TextBox.Size = new System.Drawing.Size(100, 23);
            this.Login1_TextBox.TabIndex = 4;
            this.Login1_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Haslo1_textbox
            // 
            this.Haslo1_textbox.Location = new System.Drawing.Point(40, 161);
            this.Haslo1_textbox.Name = "Haslo1_textbox";
            this.Haslo1_textbox.Size = new System.Drawing.Size(101, 23);
            this.Haslo1_textbox.TabIndex = 5;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 352);
            this.Controls.Add(this.Haslo1_textbox);
            this.Controls.Add(this.Login1_TextBox);
            this.Controls.Add(this.Haslo1_Label);
            this.Controls.Add(this.Login1_Label);
            this.Controls.Add(this.Rejestracja_Button);
            this.Controls.Add(this.Logowanie_Button);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logowanie_Button;
        private System.Windows.Forms.Button Rejestracja_Button;
        private System.Windows.Forms.Label Login1_Label;
        private System.Windows.Forms.Label Haslo1_Label;
        private System.Windows.Forms.TextBox Login1_TextBox;
        private System.Windows.Forms.TextBox Haslo1_textbox;
    }
}