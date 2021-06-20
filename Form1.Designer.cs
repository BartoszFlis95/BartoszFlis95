
namespace Zadanie5YT
{
    partial class Cos_Form
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
            this.User_Label = new System.Windows.Forms.Label();
            this.User1_TextBox = new System.Windows.Forms.TextBox();
            this.Haslo_Label = new System.Windows.Forms.Label();
            this.Haslo_TextBox = new System.Windows.Forms.TextBox();
            this.Rejestracja_Button = new System.Windows.Forms.Button();
            this.PowtorzHaslo_Label = new System.Windows.Forms.Label();
            this.PowtorzHaslo_TextBox = new System.Windows.Forms.TextBox();
            this.Wyjscie_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Location = new System.Drawing.Point(12, 18);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(142, 15);
            this.User_Label.TabIndex = 0;
            this.User_Label.Text = "Podaj nazwe uzytkownika";
            // 
            // User1_TextBox
            // 
            this.User1_TextBox.Location = new System.Drawing.Point(12, 36);
            this.User1_TextBox.Multiline = true;
            this.User1_TextBox.Name = "User1_TextBox";
            this.User1_TextBox.Size = new System.Drawing.Size(142, 23);
            this.User1_TextBox.TabIndex = 1;
            // 
            // Haslo_Label
            // 
            this.Haslo_Label.AutoSize = true;
            this.Haslo_Label.Location = new System.Drawing.Point(13, 77);
            this.Haslo_Label.Name = "Haslo_Label";
            this.Haslo_Label.Size = new System.Drawing.Size(70, 15);
            this.Haslo_Label.TabIndex = 2;
            this.Haslo_Label.Text = "Podaj Haslo";
            // 
            // Haslo_TextBox
            // 
            this.Haslo_TextBox.Location = new System.Drawing.Point(12, 95);
            this.Haslo_TextBox.Name = "Haslo_TextBox";
            this.Haslo_TextBox.Size = new System.Drawing.Size(142, 23);
            this.Haslo_TextBox.TabIndex = 3;
            this.Haslo_TextBox.UseSystemPasswordChar = true;
            // 
            // Rejestracja_Button
            // 
            this.Rejestracja_Button.Location = new System.Drawing.Point(12, 198);
            this.Rejestracja_Button.Name = "Rejestracja_Button";
            this.Rejestracja_Button.Size = new System.Drawing.Size(141, 28);
            this.Rejestracja_Button.TabIndex = 4;
            this.Rejestracja_Button.Text = "Zarejestruj";
            this.Rejestracja_Button.UseVisualStyleBackColor = true;
            this.Rejestracja_Button.Click += new System.EventHandler(this.Rejestracja_Button_Click);
            // 
            // PowtorzHaslo_Label
            // 
            this.PowtorzHaslo_Label.AutoSize = true;
            this.PowtorzHaslo_Label.Location = new System.Drawing.Point(13, 131);
            this.PowtorzHaslo_Label.Name = "PowtorzHaslo_Label";
            this.PowtorzHaslo_Label.Size = new System.Drawing.Size(83, 15);
            this.PowtorzHaslo_Label.TabIndex = 5;
            this.PowtorzHaslo_Label.Text = "Powtorz Haslo";
            // 
            // PowtorzHaslo_TextBox
            // 
            this.PowtorzHaslo_TextBox.Location = new System.Drawing.Point(13, 160);
            this.PowtorzHaslo_TextBox.Name = "PowtorzHaslo_TextBox";
            this.PowtorzHaslo_TextBox.Size = new System.Drawing.Size(141, 23);
            this.PowtorzHaslo_TextBox.TabIndex = 6;
            this.PowtorzHaslo_TextBox.UseSystemPasswordChar = true;
            // 
            // Wyjscie_Button
            // 
            this.Wyjscie_Button.Location = new System.Drawing.Point(12, 241);
            this.Wyjscie_Button.Name = "Wyjscie_Button";
            this.Wyjscie_Button.Size = new System.Drawing.Size(141, 28);
            this.Wyjscie_Button.TabIndex = 7;
            this.Wyjscie_Button.Text = "Wyjscie";
            this.Wyjscie_Button.UseVisualStyleBackColor = true;
            this.Wyjscie_Button.Click += new System.EventHandler(this.Wyjscie_Button_Click);
            // 
            // Cos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 346);
            this.Controls.Add(this.Wyjscie_Button);
            this.Controls.Add(this.PowtorzHaslo_TextBox);
            this.Controls.Add(this.PowtorzHaslo_Label);
            this.Controls.Add(this.Rejestracja_Button);
            this.Controls.Add(this.Haslo_TextBox);
            this.Controls.Add(this.Haslo_Label);
            this.Controls.Add(this.User1_TextBox);
            this.Controls.Add(this.User_Label);
            this.Name = "Cos_Form";
            this.Text = "Cos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.TextBox User1_TextBox;
        private System.Windows.Forms.Label Haslo_Label;
        private System.Windows.Forms.TextBox Haslo_TextBox;
        private System.Windows.Forms.Button Rejestracja_Button;
        private System.Windows.Forms.Label PowtorzHaslo_Label;
        private System.Windows.Forms.TextBox PowtorzHaslo_TextBox;
        private System.Windows.Forms.Button Wyjscie_Button;
    }
}

