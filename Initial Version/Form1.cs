using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ASodium;

namespace Challenge_Respond_Login
{
    public partial class Form1 : Form
    {
        private Boolean SetEnvironmentVariableChecker = true;
        private String ServerSignedChallenge;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SetEnvironmentVariableChecker == true) 
            {
                SetEnvironmentVariableHelper.SetEnvironmentVariable();
            }
        }

        private void GenerateDigitalSignatureKeyPairBTN_Click(object sender, EventArgs e)
        {
            RevampedKeyPair UserKeyPair = SodiumPublicKeyAuth.GenerateRevampedKeyPair();
            DigitalSignatureSecretKeyTB.Text = Convert.ToBase64String(UserKeyPair.PrivateKey);
            DigitalSignaturePublicKeyTB.Text = Convert.ToBase64String(UserKeyPair.PublicKey);
            //In actual scenario, the user key pair are stored in bytes array in a file locally on client/user device
            //before safely clearing the key
            UserKeyPair.Clear();
        }

        private void GenerateSignChallengeBTN_Click(object sender, EventArgs e)
        {
            RNGCryptoServiceProvider MyRNGCryptoServiceProvider = new RNGCryptoServiceProvider();
            //1024 Bits of challenge
            //From forum 128 bits of challenge is enough 
            //This is just my preference
            Byte[] ServerChallenge = new Byte[1024];
            MyRNGCryptoServiceProvider.GetBytes(ServerChallenge);
            Byte[] DigitalSignaturePublicKey = new Byte[] { };
            Byte[] SignedServerChallenge = new Byte[] { };
            PublicKeyAuthSealBox MyKeyAuthSealBox = SodiumPublicKeyAuth.SealedSign(ServerChallenge);
            SignedServerChallenge = MyKeyAuthSealBox.SignatureMessage;
            DigitalSignaturePublicKey = MyKeyAuthSealBox.PublicKey;
            ChallengeB64TB.Text = Convert.ToBase64String(ServerChallenge);
            OTDigitalSignaturePK.Text = Convert.ToBase64String(DigitalSignaturePublicKey);
            ServerSignedChallenge = Convert.ToBase64String(SignedServerChallenge);
        }

        private void SignChallengeBTN_Click(object sender, EventArgs e)
        {
            Byte[] UserPrivateKey = Convert.FromBase64String(DigitalSignatureSecretKeyTB.Text);
            Byte[] ServerOneTimePublicKey = Convert.FromBase64String(OTDigitalSignaturePK.Text);
            Byte[] ServerSignedChallengeByte = Convert.FromBase64String(ServerSignedChallenge);
            Byte[] ServerChallengeByte = SodiumPublicKeyAuth.Verify(ServerSignedChallengeByte, ServerOneTimePublicKey);
            Byte[] UserSignedChallengeByte = SodiumPublicKeyAuth.Sign(ServerChallengeByte,UserPrivateKey);
            SignedChallengeTB.Text = Convert.ToBase64String(UserSignedChallengeByte);
        }

        private void VerifySignedChallengeBTN_Click(object sender, EventArgs e)
        {
            Byte[] UserSignedChallengeByte = Convert.FromBase64String(SignedChallengeTB.Text);
            Byte[] UserPublicKey = Convert.FromBase64String(DigitalSignaturePublicKeyTB.Text);
            Byte[] ChallengeByte = new Byte[] { };
            try 
            {
                ChallengeByte = SodiumPublicKeyAuth.Verify(UserSignedChallengeByte, UserPublicKey);
                MessageBox.Show("User successfully login", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("User failed to login", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
