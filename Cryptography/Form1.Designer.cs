namespace Cryptography
{
    partial class CryptographyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptographyForm));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.cbCipherAlgorthim = new System.Windows.Forms.ComboBox();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(246, 107);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(317, 120);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain Text :";
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.Location = new System.Drawing.Point(59, 364);
            this.lblOutPut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(162, 30);
            this.lblOutPut.TabIndex = 2;
            this.lblOutPut.Text = "Cipher Text : ";
            // 
            // cbCipherAlgorthim
            // 
            this.cbCipherAlgorthim.FormattingEnabled = true;
            this.cbCipherAlgorthim.Items.AddRange(new object[] {
            "Caesar",
            "MonoAlphabetic",
            "PlayFair",
            "Hill",
            "VIGENÈRE",
            "VIGENÈRE-AutoKey",
            "RailFence"});
            this.cbCipherAlgorthim.Location = new System.Drawing.Point(246, 241);
            this.cbCipherAlgorthim.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbCipherAlgorthim.Name = "cbCipherAlgorthim";
            this.cbCipherAlgorthim.Size = new System.Drawing.Size(317, 38);
            this.cbCipherAlgorthim.TabIndex = 4;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(13, 39);
            this.rbEncrypt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(109, 34);
            this.rbEncrypt.TabIndex = 5;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(13, 84);
            this.rbDecrypt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(112, 34);
            this.rbDecrypt.TabIndex = 6;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            this.rbDecrypt.CheckedChanged += new System.EventHandler(this.rbDecrypt_CheckedChanged);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(827, 497);
            this.btnAction.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(164, 48);
            this.btnAction.TabIndex = 7;
            this.btnAction.Text = "Encrypt";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(673, 108);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(213, 171);
            this.txtKey.TabIndex = 8;
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(593, 111);
            this.Key.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(68, 30);
            this.Key.TabIndex = 9;
            this.Key.Text = "Key :";
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(246, 364);
            this.txtOutPut.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(744, 120);
            this.txtOutPut.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cipher Algorthim :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDecrypt);
            this.groupBox1.Controls.Add(this.rbEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(898, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBox1.Size = new System.Drawing.Size(230, 172);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypto Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cryptography Theory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aldhabi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 556);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Designed by Youssef Mohamed Ali  - Supervised by Dr.Samira Mersal";
            // 
            // CryptographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1163, 597);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.cbCipherAlgorthim);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CryptographyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.Load += new System.EventHandler(this.CryptographyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.ComboBox cbCipherAlgorthim;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

