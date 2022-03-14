using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_week_2
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }
        string TextBoxIsi = "";
        string TextBoxWarna = "";
        string TextBoxIsiCut = "";
        string TextBoxWarnaCut = "";
        string TextBoxWarnaLower = "";
        string TextBoxFullLower = "";
        float fontSizeBaru = 0;
        bool canGivenColor;
        int cekRestart = 0;
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            TextBoxIsiCut = "";
            TextBoxFullLower = TextBoxInput.Text.ToLower();
            if (TextBoxInput.Text.Length < 4)
            {
                TextBoxFullLower = "syntax";
            }
            if (TextBoxInput.Text.Length >= 4)
            {
                TextBoxIsiCut = TextBoxInput.Text.Substring(0, 4);
                if (TextBoxIsiCut.ToLower() == "isi:")
                {
                    TextBoxIsi = TextBoxInput.Text.Substring(4);
                    if (TextBoxIsi.StartsWith(" "))
                    {
                        TextBoxIsi = TextBoxIsi.Substring(1);
                    }
                    canGivenColor = true;
                }
                else if (TextBoxFullLower != "restart" && TextBoxWarnaCut.ToLower() != "warna:" && TextBoxFullLower != "shown" && TextBoxFullLower != "hide" && TextBoxFullLower != "besarkan" && TextBoxFullLower != "kecilkan")
                {
                    TextBoxFullLower = "syntax";
                }
                else if (cekRestart == 1 && (TextBoxFullLower == "restart" || TextBoxWarnaCut.ToLower() == "warna:" || TextBoxFullLower == "shown" || TextBoxFullLower == "hide" || TextBoxFullLower == "besarkan" || TextBoxFullLower == "kecilkan"))
                {
                    TextBoxFullLower = "restart";
                }
                else
                {
                    canGivenColor = true;
                    TextBoxWarnaCut = "";
                }
            }
            if (TextBoxInput.Text.Length >= 6)
            {
                TextBoxWarnaCut = "";
                TextBoxWarnaCut = TextBoxInput.Text.Substring(0, 6);
                if (TextBoxWarnaCut.ToLower() == "warna:")
                {
                    TextBoxWarna = TextBoxInput.Text.Substring(6);
                    if (TextBoxWarna.StartsWith(" "))
                    {
                        TextBoxWarna = TextBoxWarna.Substring(1);
                    }
                    TextBoxWarnaLower = TextBoxWarna.ToLower();
                    if (TextBoxWarnaLower != "default" && TextBoxWarnaLower != "merah" && TextBoxWarnaLower != "hijau" && TextBoxWarnaLower != "biru")
                    {
                        TextBoxFullLower = "syntax";
                    }
                    else if (cekRestart == 1 && (TextBoxWarnaLower == "default" || TextBoxWarnaLower == "merah" || TextBoxWarnaLower == "hijau" || TextBoxWarnaLower == "biru"))
                    {
                        TextBoxFullLower = "restart";
                    }
                    else 
                    {
                        canGivenColor = true;
                        TextBoxWarnaCut = "";
                    }
                }
                else if (TextBoxFullLower != "restart" && TextBoxIsiCut.ToLower() != "isi:" && TextBoxFullLower != "shown" && TextBoxFullLower != "hide" && TextBoxFullLower != "besarkan" && TextBoxFullLower != "kecilkan")
                {
                    TextBoxFullLower = "syntax"; 
                }
                else
                {
                    canGivenColor = true;
                    TextBoxWarnaCut = "";
                }
            }
        }
        private void BtnProses_Click(object sender, EventArgs e)
        {
            if (canGivenColor == true)
            {
                if (TextBoxFullLower == "shown")
                {
                    LabelOutput.Show();
                }
                else if (TextBoxFullLower == "hide")
                {
                    LabelOutput.Hide();
                }
                else if (TextBoxFullLower == "besarkan")
                {
                    LabelOutput.AutoSize = true;
                    fontSizeBaru = LabelOutput.Font.Size * 1.1f;
                    LabelOutput.Font = new Font(LabelOutput.Font.FontFamily, fontSizeBaru);
                }
                else if (TextBoxFullLower == "kecilkan")
                {
                    LabelOutput.AutoSize = true;
                    fontSizeBaru = LabelOutput.Font.Size / 1.1f;
                    LabelOutput.Font = new Font(LabelOutput.Font.FontFamily, fontSizeBaru);
                }
                else if (TextBoxWarnaLower == "default")
                {
                    LabelOutput.ForeColor = Color.Black;
                }
                else if (TextBoxWarnaLower == "merah")
                {
                    LabelOutput.ForeColor = Color.Red;
                }
                else if (TextBoxWarnaLower == "hijau")
                {
                    LabelOutput.ForeColor = Color.Green;
                }
                else if (TextBoxWarnaLower == "biru")
                {
                    LabelOutput.ForeColor = Color.Blue;
                }
                LabelOutput.Text = TextBoxIsi;
            }
            if (TextBoxFullLower == "restart")
            {
                LabelOutput.Show();
                TextBoxWarnaLower = "default";
                LabelOutput.ForeColor = Color.Black;
                LabelOutput.Text = "[EMPTY]";
                TextBoxIsi = "[EMPTY]";
                LabelOutput.Font = new Font(LabelOutput.Font.FontFamily, 15);
                canGivenColor = false;
                cekRestart = 1;
            }
            else if (TextBoxFullLower != "syntax")
            {
                canGivenColor = true;
                cekRestart = 0;
            }

            if (TextBoxFullLower == "syntax")
            {
                MessageBox.Show("Syntax tidak terdaftar");
                canGivenColor = false;
            }
            else if (TextBoxFullLower != "restart")
            {
                canGivenColor = true;
                cekRestart = 0;
            }
        }
    }
}
