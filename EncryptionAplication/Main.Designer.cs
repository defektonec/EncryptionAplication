namespace EncryptionAplication
{
    partial class Main
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
            groupBox1 = new GroupBox();
            btnPlayFair = new Button();
            button2 = new Button();
            btnVigenere = new Button();
            btnPolybius = new Button();
            btnCaesar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPlayFair);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnVigenere);
            groupBox1.Controls.Add(btnPolybius);
            groupBox1.Controls.Add(btnCaesar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciphers";
            // 
            // btnPlayFair
            // 
            btnPlayFair.Location = new Point(182, 63);
            btnPlayFair.Name = "btnPlayFair";
            btnPlayFair.Size = new Size(170, 35);
            btnPlayFair.TabIndex = 0;
            btnPlayFair.Text = "Cipher PlayFair";
            btnPlayFair.UseVisualStyleBackColor = true;
            btnPlayFair.Click += btnPlayFair_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 104);
            button2.Name = "button2";
            button2.Size = new Size(346, 35);
            button2.TabIndex = 0;
            button2.Text = "Unknown One";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnVigenere
            // 
            btnVigenere.Location = new Point(6, 63);
            btnVigenere.Name = "btnVigenere";
            btnVigenere.Size = new Size(170, 35);
            btnVigenere.TabIndex = 0;
            btnVigenere.Text = "Cipher Vigenere";
            btnVigenere.UseVisualStyleBackColor = true;
            btnVigenere.Click += btnVigenere_Click;
            // 
            // btnPolybius
            // 
            btnPolybius.Location = new Point(182, 22);
            btnPolybius.Name = "btnPolybius";
            btnPolybius.Size = new Size(170, 35);
            btnPolybius.TabIndex = 0;
            btnPolybius.Text = "Polybius Square";
            btnPolybius.UseVisualStyleBackColor = true;
            btnPolybius.Click += btnPolybius_Click;
            // 
            // btnCaesar
            // 
            btnCaesar.Location = new Point(6, 22);
            btnCaesar.Name = "btnCaesar";
            btnCaesar.Size = new Size(170, 35);
            btnCaesar.TabIndex = 0;
            btnCaesar.Text = "Cipher Caesar";
            btnCaesar.UseVisualStyleBackColor = true;
            btnCaesar.Click += btnCaesar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 179);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encryption Application";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPlayFair;
        private Button button2;
        private Button btnVigenere;
        private Button btnPolybius;
        private Button btnCaesar;
    }
}
