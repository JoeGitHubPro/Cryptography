using CryptographyBase.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class CryptographyForm : Form
    {
        public CryptographyForm()
        {
            InitializeComponent();
            rbEncrypt.Checked = true;
            cbCipherAlgorthim.SelectedIndex = 0;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter input text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtKey.Text == string.Empty)
            {
                MessageBox.Show("Please enter input key.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = txtInput.Text;
            string key = txtKey.Text;
            string algothim = cbCipherAlgorthim.Text;
            string outPut = string.Empty;

            if (!input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("alphabetic character only are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isEncrypt = true;

            if (rbDecrypt.Checked)
            {
                isEncrypt = false;

            }


            switch (algothim)
            {
                case "Caesar":
                    int intKey;
                    try
                    {
                        intKey = Int32.Parse(key);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter intger key value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    }

                    if (isEncrypt)
                    {
                        outPut = Caesar.Encrypt(intKey, input);
                    }
                    else
                    {
                        outPut = Caesar.Decrypt(intKey, input);
                    }

                    break;

                case "MonoAlphabetic":

                    if (isEncrypt)
                    {
                        outPut = MonoAlphabetic.Encrypt(key, input);
                    }
                    else
                    {
                        outPut = MonoAlphabetic.Decrypt(key, input);
                    }

                    break;

                case "PlayFair":
                    if (isEncrypt)
                    {
                        outPut = PlayFair.Encrypt(key, input);
                    }
                    else
                    {
                        outPut = PlayFair.Decrypt(key, input);

                    }
                    break;

                case "Hill":
                    // Read text from the textbox
                    string text = txtKey.Text;

                    // Split the text into rows
                    string[] rows = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    // Initialize the 2D array
                    double[,] keyMatrix = new double[rows.Length, 0];

                    // Split each row into individual values
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] values = rows[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        keyMatrix = ResizeArray(keyMatrix, values.Length, i);
                        for (int j = 0; j < values.Length; j++)
                        {
                            keyMatrix[i, j] = Convert.ToInt32(values[j]);
                        }
                    }

                    if (isEncrypt)
                    {
                        outPut = Hill.Encrypt(keyMatrix, input);
                    }
                    else
                    {
                        outPut = Hill.Decrypt(keyMatrix, input);

                    }
                    break;

                default:
                    MessageBox.Show("Please select algorthim first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }


            txtOutPut.Text = outPut;
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Cipher Text : ";
            lblOutPut.Text = "Plain Text :";
            btnAction.Text = "Decrypt";
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Plain Text :";
            lblOutPut.Text = "Cipher Text : ";
            btnAction.Text = "Encrypt";
        }
        private double[,] ResizeArray(double[,] original, int columns, int row)
        {
            var newArray = new double[original.GetLength(0), columns];
            for (int i = 0; i < original.GetLength(0); i++)
            {
                for (int j = 0; j < original.GetLength(1); j++)
                {
                    newArray[i, j] = original[i, j];
                }
            }
            return newArray;
        }
    }
}
