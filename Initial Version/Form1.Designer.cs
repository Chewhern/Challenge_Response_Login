namespace Challenge_Respond_Login
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
            this.UserDeviceDomainPanel = new System.Windows.Forms.Panel();
            this.ServerDomainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DigitalSignatureSecretKeyTB = new System.Windows.Forms.TextBox();
            this.DigitalSignaturePublicKeyTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerateDigitalSignatureKeyPairBTN = new System.Windows.Forms.Button();
            this.ChallengeB64TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OTDigitalSignaturePK = new System.Windows.Forms.TextBox();
            this.GenerateSignChallengeBTN = new System.Windows.Forms.Button();
            this.VerifySignedChallengeBTN = new System.Windows.Forms.Button();
            this.SignChallengeBTN = new System.Windows.Forms.Button();
            this.SignedChallengeTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UserDeviceDomainPanel.SuspendLayout();
            this.ServerDomainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDeviceDomainPanel
            // 
            this.UserDeviceDomainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserDeviceDomainPanel.Controls.Add(this.label9);
            this.UserDeviceDomainPanel.Controls.Add(this.SignedChallengeTB);
            this.UserDeviceDomainPanel.Controls.Add(this.SignChallengeBTN);
            this.UserDeviceDomainPanel.Controls.Add(this.GenerateDigitalSignatureKeyPairBTN);
            this.UserDeviceDomainPanel.Controls.Add(this.DigitalSignaturePublicKeyTB);
            this.UserDeviceDomainPanel.Controls.Add(this.label5);
            this.UserDeviceDomainPanel.Controls.Add(this.DigitalSignatureSecretKeyTB);
            this.UserDeviceDomainPanel.Controls.Add(this.label4);
            this.UserDeviceDomainPanel.Controls.Add(this.label3);
            this.UserDeviceDomainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserDeviceDomainPanel.Location = new System.Drawing.Point(0, 0);
            this.UserDeviceDomainPanel.Name = "UserDeviceDomainPanel";
            this.UserDeviceDomainPanel.Size = new System.Drawing.Size(256, 673);
            this.UserDeviceDomainPanel.TabIndex = 0;
            // 
            // ServerDomainPanel
            // 
            this.ServerDomainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerDomainPanel.Controls.Add(this.VerifySignedChallengeBTN);
            this.ServerDomainPanel.Controls.Add(this.GenerateSignChallengeBTN);
            this.ServerDomainPanel.Controls.Add(this.OTDigitalSignaturePK);
            this.ServerDomainPanel.Controls.Add(this.label7);
            this.ServerDomainPanel.Controls.Add(this.ChallengeB64TB);
            this.ServerDomainPanel.Controls.Add(this.label6);
            this.ServerDomainPanel.Controls.Add(this.label2);
            this.ServerDomainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ServerDomainPanel.Location = new System.Drawing.Point(824, 0);
            this.ServerDomainPanel.Name = "ServerDomainPanel";
            this.ServerDomainPanel.Size = new System.Drawing.Size(254, 673);
            this.ServerDomainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(333, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Public Or Internet Unsafe Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(64, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Side";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Digital Signature Secret Key";
            // 
            // DigitalSignatureSecretKeyTB
            // 
            this.DigitalSignatureSecretKeyTB.Location = new System.Drawing.Point(26, 121);
            this.DigitalSignatureSecretKeyTB.Multiline = true;
            this.DigitalSignatureSecretKeyTB.Name = "DigitalSignatureSecretKeyTB";
            this.DigitalSignatureSecretKeyTB.ReadOnly = true;
            this.DigitalSignatureSecretKeyTB.Size = new System.Drawing.Size(204, 89);
            this.DigitalSignatureSecretKeyTB.TabIndex = 3;
            // 
            // DigitalSignaturePublicKeyTB
            // 
            this.DigitalSignaturePublicKeyTB.Location = new System.Drawing.Point(26, 255);
            this.DigitalSignaturePublicKeyTB.Multiline = true;
            this.DigitalSignaturePublicKeyTB.Name = "DigitalSignaturePublicKeyTB";
            this.DigitalSignaturePublicKeyTB.ReadOnly = true;
            this.DigitalSignaturePublicKeyTB.Size = new System.Drawing.Size(204, 89);
            this.DigitalSignaturePublicKeyTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digital Signature Public Key";
            // 
            // GenerateDigitalSignatureKeyPairBTN
            // 
            this.GenerateDigitalSignatureKeyPairBTN.Location = new System.Drawing.Point(26, 360);
            this.GenerateDigitalSignatureKeyPairBTN.Name = "GenerateDigitalSignatureKeyPairBTN";
            this.GenerateDigitalSignatureKeyPairBTN.Size = new System.Drawing.Size(204, 77);
            this.GenerateDigitalSignatureKeyPairBTN.TabIndex = 6;
            this.GenerateDigitalSignatureKeyPairBTN.Text = "Generate D.S KeyPair";
            this.GenerateDigitalSignatureKeyPairBTN.UseVisualStyleBackColor = true;
            this.GenerateDigitalSignatureKeyPairBTN.Click += new System.EventHandler(this.GenerateDigitalSignatureKeyPairBTN_Click);
            // 
            // ChallengeB64TB
            // 
            this.ChallengeB64TB.Location = new System.Drawing.Point(18, 121);
            this.ChallengeB64TB.Multiline = true;
            this.ChallengeB64TB.Name = "ChallengeB64TB";
            this.ChallengeB64TB.ReadOnly = true;
            this.ChallengeB64TB.Size = new System.Drawing.Size(204, 89);
            this.ChallengeB64TB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Challenge (Base 64)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "OneTime D.S PK";
            // 
            // OTDigitalSignaturePK
            // 
            this.OTDigitalSignaturePK.Location = new System.Drawing.Point(22, 255);
            this.OTDigitalSignaturePK.Multiline = true;
            this.OTDigitalSignaturePK.Name = "OTDigitalSignaturePK";
            this.OTDigitalSignaturePK.ReadOnly = true;
            this.OTDigitalSignaturePK.Size = new System.Drawing.Size(200, 89);
            this.OTDigitalSignaturePK.TabIndex = 10;
            // 
            // GenerateSignChallengeBTN
            // 
            this.GenerateSignChallengeBTN.Location = new System.Drawing.Point(22, 360);
            this.GenerateSignChallengeBTN.Name = "GenerateSignChallengeBTN";
            this.GenerateSignChallengeBTN.Size = new System.Drawing.Size(200, 77);
            this.GenerateSignChallengeBTN.TabIndex = 11;
            this.GenerateSignChallengeBTN.Text = "Generate Challenge And Signs it(One Time)";
            this.GenerateSignChallengeBTN.UseVisualStyleBackColor = true;
            this.GenerateSignChallengeBTN.Click += new System.EventHandler(this.GenerateSignChallengeBTN_Click);
            // 
            // VerifySignedChallengeBTN
            // 
            this.VerifySignedChallengeBTN.Location = new System.Drawing.Point(22, 474);
            this.VerifySignedChallengeBTN.Name = "VerifySignedChallengeBTN";
            this.VerifySignedChallengeBTN.Size = new System.Drawing.Size(200, 64);
            this.VerifySignedChallengeBTN.TabIndex = 14;
            this.VerifySignedChallengeBTN.Text = "Verify User Sent Signed Challenge";
            this.VerifySignedChallengeBTN.UseVisualStyleBackColor = true;
            this.VerifySignedChallengeBTN.Click += new System.EventHandler(this.VerifySignedChallengeBTN_Click);
            // 
            // SignChallengeBTN
            // 
            this.SignChallengeBTN.Location = new System.Drawing.Point(26, 579);
            this.SignChallengeBTN.Name = "SignChallengeBTN";
            this.SignChallengeBTN.Size = new System.Drawing.Size(203, 64);
            this.SignChallengeBTN.TabIndex = 7;
            this.SignChallengeBTN.Text = "Sign Server Challenge";
            this.SignChallengeBTN.UseVisualStyleBackColor = true;
            this.SignChallengeBTN.Click += new System.EventHandler(this.SignChallengeBTN_Click);
            // 
            // SignedChallengeTB
            // 
            this.SignedChallengeTB.Location = new System.Drawing.Point(26, 474);
            this.SignedChallengeTB.Multiline = true;
            this.SignedChallengeTB.Name = "SignedChallengeTB";
            this.SignedChallengeTB.ReadOnly = true;
            this.SignedChallengeTB.Size = new System.Drawing.Size(203, 89);
            this.SignedChallengeTB.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Signed Challenge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerDomainPanel);
            this.Controls.Add(this.UserDeviceDomainPanel);
            this.Name = "Form1";
            this.Text = "Challenge And Respond Passwordless Login Mechanism";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserDeviceDomainPanel.ResumeLayout(false);
            this.UserDeviceDomainPanel.PerformLayout();
            this.ServerDomainPanel.ResumeLayout(false);
            this.ServerDomainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserDeviceDomainPanel;
        private System.Windows.Forms.Button GenerateDigitalSignatureKeyPairBTN;
        private System.Windows.Forms.TextBox DigitalSignaturePublicKeyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DigitalSignatureSecretKeyTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ServerDomainPanel;
        private System.Windows.Forms.Button GenerateSignChallengeBTN;
        private System.Windows.Forms.TextBox OTDigitalSignaturePK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ChallengeB64TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SignedChallengeTB;
        private System.Windows.Forms.Button SignChallengeBTN;
        private System.Windows.Forms.Button VerifySignedChallengeBTN;
    }
}

