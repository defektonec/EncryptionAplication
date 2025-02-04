namespace EncryptionAplication
{
    partial class Playfair
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
            groupBox1 = new GroupBox();
            decryptionOutput = new TextBox();
            keyInput = new TextBox();
            groupEncryption = new GroupBox();
            encryptedOutput = new TextBox();
            messageInput = new TextBox();
            btnGoBack = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupEncryption.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(decryptionOutput);
            groupBox1.Location = new Point(367, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 134);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decryption";
            // 
            // decryptionOutput
            // 
            decryptionOutput.BackColor = SystemColors.ScrollBar;
            decryptionOutput.ForeColor = SystemColors.WindowText;
            decryptionOutput.Location = new Point(11, 22);
            decryptionOutput.Multiline = true;
            decryptionOutput.Name = "decryptionOutput";
            decryptionOutput.PlaceholderText = "Here will be decrypted text ...";
            decryptionOutput.ReadOnly = true;
            decryptionOutput.Size = new Size(316, 93);
            decryptionOutput.TabIndex = 5;
            // 
            // keyInput
            // 
            keyInput.BackColor = SystemColors.ButtonHighlight;
            keyInput.ForeColor = SystemColors.WindowText;
            keyInput.Location = new Point(367, 138);
            keyInput.Multiline = true;
            keyInput.Name = "keyInput";
            keyInput.PlaceholderText = "Input key ...";
            keyInput.Size = new Size(327, 43);
            keyInput.TabIndex = 28;
            keyInput.TextChanged += keyInput_TextChanged;
            // 
            // groupEncryption
            // 
            groupEncryption.Controls.Add(encryptedOutput);
            groupEncryption.Location = new Point(-1, 187);
            groupEncryption.Name = "groupEncryption";
            groupEncryption.Size = new Size(342, 134);
            groupEncryption.TabIndex = 31;
            groupEncryption.TabStop = false;
            groupEncryption.Text = "Encryption";
            // 
            // encryptedOutput
            // 
            encryptedOutput.BackColor = SystemColors.ScrollBar;
            encryptedOutput.ForeColor = SystemColors.WindowText;
            encryptedOutput.Location = new Point(11, 22);
            encryptedOutput.Multiline = true;
            encryptedOutput.Name = "encryptedOutput";
            encryptedOutput.PlaceholderText = "Here will be encrypted text ...";
            encryptedOutput.ReadOnly = true;
            encryptedOutput.Size = new Size(316, 93);
            encryptedOutput.TabIndex = 6;
            // 
            // messageInput
            // 
            messageInput.BackColor = SystemColors.ButtonHighlight;
            messageInput.ForeColor = SystemColors.WindowText;
            messageInput.Location = new Point(12, 61);
            messageInput.Multiline = true;
            messageInput.Name = "messageInput";
            messageInput.PlaceholderText = "Insert text for encryption or decryption ...";
            messageInput.Size = new Size(316, 120);
            messageInput.TabIndex = 29;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(12, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(683, 31);
            btnGoBack.TabIndex = 30;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(367, 92);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(327, 25);
            btnDecrypt.TabIndex = 26;
            btnDecrypt.Text = "Decrypt Text";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(367, 61);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(328, 25);
            btnEncrypt.TabIndex = 27;
            btnEncrypt.Text = "Encrypt Text";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 120);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 24;
            label2.Text = "Key:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 25;
            label1.Text = "Input data:";
            // 
            // Playfair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 339);
            Controls.Add(groupBox1);
            Controls.Add(keyInput);
            Controls.Add(groupEncryption);
            Controls.Add(messageInput);
            Controls.Add(btnGoBack);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Playfair";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Playfair";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupEncryption.ResumeLayout(false);
            groupEncryption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox decryptionOutput;
        private TextBox keyInput;
        private GroupBox groupEncryption;
        private TextBox encryptedOutput;
        private TextBox messageInput;
        private Button btnGoBack;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Label label2;
        private Label label1;
    }
}