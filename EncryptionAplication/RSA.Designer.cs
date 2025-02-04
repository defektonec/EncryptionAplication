namespace EncryptionAplication
{
    partial class RSA
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
            txtDecrypted = new TextBox();
            txtPublicKey = new TextBox();
            groupEncryption = new GroupBox();
            txtEncrypted = new TextBox();
            txtMessage = new TextBox();
            btnGoBack = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPrivateKey = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupEncryption.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDecrypted);
            groupBox1.Location = new Point(370, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 134);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decryption";
            // 
            // txtDecrypted
            // 
            txtDecrypted.BackColor = SystemColors.ScrollBar;
            txtDecrypted.ForeColor = SystemColors.WindowText;
            txtDecrypted.Location = new Point(11, 22);
            txtDecrypted.Multiline = true;
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.PlaceholderText = "Here will be decrypted text ...";
            txtDecrypted.ReadOnly = true;
            txtDecrypted.Size = new Size(316, 93);
            txtDecrypted.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            txtPublicKey.BackColor = SystemColors.ButtonHighlight;
            txtPublicKey.ForeColor = SystemColors.WindowText;
            txtPublicKey.Location = new Point(370, 182);
            txtPublicKey.Multiline = true;
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.PlaceholderText = "Input key ...";
            txtPublicKey.Size = new Size(327, 43);
            txtPublicKey.TabIndex = 37;
            // 
            // groupEncryption
            // 
            groupEncryption.Controls.Add(txtEncrypted);
            groupEncryption.Location = new Point(12, 302);
            groupEncryption.Name = "groupEncryption";
            groupEncryption.Size = new Size(334, 134);
            groupEncryption.TabIndex = 40;
            groupEncryption.TabStop = false;
            groupEncryption.Text = "Encryption";
            // 
            // txtEncrypted
            // 
            txtEncrypted.BackColor = SystemColors.ScrollBar;
            txtEncrypted.ForeColor = SystemColors.WindowText;
            txtEncrypted.Location = new Point(11, 22);
            txtEncrypted.Multiline = true;
            txtEncrypted.Name = "txtEncrypted";
            txtEncrypted.PlaceholderText = "Here will be encrypted text ...";
            txtEncrypted.ReadOnly = true;
            txtEncrypted.Size = new Size(305, 93);
            txtEncrypted.TabIndex = 6;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = SystemColors.ButtonHighlight;
            txtMessage.ForeColor = SystemColors.WindowText;
            txtMessage.Location = new Point(12, 61);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Insert text for encryption or decryption ...";
            txtMessage.Size = new Size(316, 231);
            txtMessage.TabIndex = 38;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(12, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(683, 31);
            btnGoBack.TabIndex = 39;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(367, 92);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(327, 25);
            btnDecrypt.TabIndex = 35;
            btnDecrypt.Text = "Decrypt Text";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(367, 61);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(328, 25);
            btnEncrypt.TabIndex = 36;
            btnEncrypt.Text = "Encrypt Text";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 164);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 33;
            label2.Text = "Public key:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 34;
            label1.Text = "Input data:";
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.BackColor = SystemColors.ButtonHighlight;
            txtPrivateKey.ForeColor = SystemColors.WindowText;
            txtPrivateKey.Location = new Point(370, 249);
            txtPrivateKey.Multiline = true;
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.PlaceholderText = "Input key ...";
            txtPrivateKey.Size = new Size(327, 43);
            txtPrivateKey.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 231);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 42;
            label3.Text = "Private key:";
            // 
            // button1
            // 
            button1.Location = new Point(367, 123);
            button1.Name = "button1";
            button1.Size = new Size(327, 25);
            button1.TabIndex = 44;
            button1.Text = "Generate keys";
            button1.UseVisualStyleBackColor = true;
            // 
            // RSA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 456);
            Controls.Add(button1);
            Controls.Add(txtPrivateKey);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtPublicKey);
            Controls.Add(groupEncryption);
            Controls.Add(txtMessage);
            Controls.Add(btnGoBack);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RSA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RSA";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupEncryption.ResumeLayout(false);
            groupEncryption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDecrypted;
        private TextBox txtPublicKey;
        private GroupBox groupEncryption;
        private TextBox txtEncrypted;
        private TextBox txtMessage;
        private Button btnGoBack;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Label label2;
        private Label label1;
        private TextBox txtPrivateKey;
        private Label label3;
        private Button button1;
    }
}