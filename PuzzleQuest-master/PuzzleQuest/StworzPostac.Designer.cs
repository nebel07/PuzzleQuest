namespace PuzzleQuest
{
    partial class Stworz_Postac
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Haslo_Label = new System.Windows.Forms.Label();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.NazwaPostaci = new System.Windows.Forms.TextBox();
            this.NazwaPostaci_Label = new System.Windows.Forms.Label();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.W_Lewo = new System.Windows.Forms.Button();
            this.W_Prawo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wybor_Postaci = new System.Windows.Forms.Label();
            this.Wroc = new System.Windows.Forms.Button();
            this.Wojownik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DarkGray;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(125, 217);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(193, 36);
            this.Login.TabIndex = 0;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.BackColor = System.Drawing.Color.Transparent;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_Label.Location = new System.Drawing.Point(174, 174);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(88, 31);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "Login:";
            // 
            // Haslo_Label
            // 
            this.Haslo_Label.AutoSize = true;
            this.Haslo_Label.BackColor = System.Drawing.Color.Transparent;
            this.Haslo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Haslo_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Haslo_Label.Location = new System.Drawing.Point(174, 256);
            this.Haslo_Label.Name = "Haslo_Label";
            this.Haslo_Label.Size = new System.Drawing.Size(92, 31);
            this.Haslo_Label.TabIndex = 2;
            this.Haslo_Label.Text = "Hasło:";
            // 
            // Haslo
            // 
            this.Haslo.BackColor = System.Drawing.Color.DarkGray;
            this.Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Haslo.Location = new System.Drawing.Point(125, 290);
            this.Haslo.Multiline = true;
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(193, 36);
            this.Haslo.TabIndex = 3;
            // 
            // NazwaPostaci
            // 
            this.NazwaPostaci.BackColor = System.Drawing.Color.DarkGray;
            this.NazwaPostaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaPostaci.Location = new System.Drawing.Point(125, 135);
            this.NazwaPostaci.Multiline = true;
            this.NazwaPostaci.Name = "NazwaPostaci";
            this.NazwaPostaci.Size = new System.Drawing.Size(193, 36);
            this.NazwaPostaci.TabIndex = 4;
            // 
            // NazwaPostaci_Label
            // 
            this.NazwaPostaci_Label.AutoSize = true;
            this.NazwaPostaci_Label.BackColor = System.Drawing.Color.Transparent;
            this.NazwaPostaci_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaPostaci_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.NazwaPostaci_Label.Location = new System.Drawing.Point(119, 84);
            this.NazwaPostaci_Label.Name = "NazwaPostaci_Label";
            this.NazwaPostaci_Label.Size = new System.Drawing.Size(203, 31);
            this.NazwaPostaci_Label.TabIndex = 5;
            this.NazwaPostaci_Label.Text = "Nazwa Postaci:";
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Zatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zatwierdz.Location = new System.Drawing.Point(152, 383);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(141, 37);
            this.Zatwierdz.TabIndex = 6;
            this.Zatwierdz.Text = "Zatwierdź";
            this.Zatwierdz.UseVisualStyleBackColor = false;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // W_Lewo
            // 
            this.W_Lewo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.W_Lewo.BackgroundImage = global::PuzzleQuest.Properties.Resources.wybor_postaci_lewo;
            this.W_Lewo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.W_Lewo.Location = new System.Drawing.Point(501, 383);
            this.W_Lewo.Name = "W_Lewo";
            this.W_Lewo.Size = new System.Drawing.Size(40, 36);
            this.W_Lewo.TabIndex = 8;
            this.W_Lewo.UseVisualStyleBackColor = false;
            this.W_Lewo.Click += new System.EventHandler(this.W_Lewo_Click);
            // 
            // W_Prawo
            // 
            this.W_Prawo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.W_Prawo.BackgroundImage = global::PuzzleQuest.Properties.Resources.wybor_postaci_prawo;
            this.W_Prawo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.W_Prawo.Location = new System.Drawing.Point(557, 383);
            this.W_Prawo.Name = "W_Prawo";
            this.W_Prawo.Size = new System.Drawing.Size(40, 36);
            this.W_Prawo.TabIndex = 9;
            this.W_Prawo.UseVisualStyleBackColor = false;
            this.W_Prawo.Click += new System.EventHandler(this.W_Prawo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuzzleQuest.Properties.Resources.rycerz;
            this.pictureBox1.Location = new System.Drawing.Point(460, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Wybor_Postaci
            // 
            this.Wybor_Postaci.AutoSize = true;
            this.Wybor_Postaci.BackColor = System.Drawing.Color.Transparent;
            this.Wybor_Postaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wybor_Postaci.ForeColor = System.Drawing.SystemColors.Control;
            this.Wybor_Postaci.Location = new System.Drawing.Point(444, 84);
            this.Wybor_Postaci.Name = "Wybor_Postaci";
            this.Wybor_Postaci.Size = new System.Drawing.Size(197, 31);
            this.Wybor_Postaci.TabIndex = 11;
            this.Wybor_Postaci.Text = "Wybor Postaci:";
            // 
            // Wroc
            // 
            this.Wroc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wroc.Location = new System.Drawing.Point(152, 437);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(141, 37);
            this.Wroc.TabIndex = 12;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = false;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // Wojownik
            // 
            this.Wojownik.AutoSize = true;
            this.Wojownik.Location = new System.Drawing.Point(501, 119);
            this.Wojownik.Name = "Wojownik";
            this.Wojownik.Size = new System.Drawing.Size(35, 13);
            this.Wojownik.TabIndex = 13;
            this.Wojownik.Text = "label1";
            // 
            // Stworz_Postac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuzzleQuest.Properties.Resources.StworzPostac1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 526);
            this.Controls.Add(this.Wojownik);
            this.Controls.Add(this.Wroc);
            this.Controls.Add(this.Wybor_Postaci);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.W_Prawo);
            this.Controls.Add(this.W_Lewo);
            this.Controls.Add(this.Zatwierdz);
            this.Controls.Add(this.NazwaPostaci_Label);
            this.Controls.Add(this.NazwaPostaci);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Haslo_Label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Login);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Stworz_Postac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tworzenie Postaci";
            this.Load += new System.EventHandler(this.Stworz_Postac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Haslo_Label;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.TextBox NazwaPostaci;
        private System.Windows.Forms.Label NazwaPostaci_Label;
        private System.Windows.Forms.Button Zatwierdz;
        private System.Windows.Forms.Button W_Lewo;
        private System.Windows.Forms.Button W_Prawo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Wybor_Postaci;
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Label Wojownik;
    }
}