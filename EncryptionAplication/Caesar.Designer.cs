namespace EncryptionAplication
{
    partial class Caesar
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
            groupEncryption = new GroupBox();
            encryptedOutput = new TextBox();
            label1 = new Label();
            btnEncrypt = new Button();
            groupBox1 = new GroupBox();
            decryptionOutput = new TextBox();
            btnGoBack = new Button();
            keyInput = new NumericUpDown();
            label2 = new Label();
            btnDecrypt = new Button();
            messageInput = new TextBox();
            groupEncryption.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)keyInput).BeginInit();
            SuspendLayout();
            // 
            // groupEncryption
            // 
            groupEncryption.Controls.Add(encryptedOutput);
            groupEncryption.Location = new Point(12, 198);
            groupEncryption.Name = "groupEncryption";
            groupEncryption.Size = new Size(342, 134);
            groupEncryption.TabIndex = 0;
            groupEncryption.TabStop = false;
            groupEncryption.Text = "Encrypted Text";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Input data:";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(378, 61);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(328, 36);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt Text";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(decryptionOutput);
            groupBox1.Location = new Point(379, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 134);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decrypted Text";
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
            // btnGoBack
            // 
            btnGoBack.Location = new Point(23, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(683, 31);
            btnGoBack.TabIndex = 7;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // keyInput
            // 
            keyInput.Location = new Point(379, 158);
            keyInput.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(327, 23);
            keyInput.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 139);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Key:";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(379, 100);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(327, 36);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt Text";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // messageInput
            // 
            messageInput.BackColor = SystemColors.ButtonHighlight;
            messageInput.ForeColor = SystemColors.WindowText;
            messageInput.Location = new Point(23, 61);
            messageInput.Multiline = true;
            messageInput.Name = "messageInput";
            messageInput.PlaceholderText = "Insert text for encryption or decryption ...";
            messageInput.Size = new Size(316, 120);
            messageInput.TabIndex = 7;
            // 
            // Caesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 341);
            Controls.Add(messageInput);
            Controls.Add(label2);
            Controls.Add(keyInput);
            Controls.Add(btnGoBack);
            Controls.Add(groupBox1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(label1);
            Controls.Add(groupEncryption);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Caesar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Caesar";
            groupEncryption.ResumeLayout(false);
            groupEncryption.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)keyInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupEncryption;
        private TextBox messageInput;
        private Label label1;
        private Button btnEncrypt;
        private GroupBox groupBox1;
        private TextBox decryptionOutput;
        private Button btnGoBack;
        private NumericUpDown keyInput;
        private Label label2;
        private Button btnDecrypt;
        private TextBox encryptedOutput;
    }
}