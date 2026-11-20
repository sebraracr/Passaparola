using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Passaparola_Oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;                // Enter kutuya alt satır eklemesin
                textBox1.Text = textBox1.Text.Trim();     // baştaki/sondaki boşlukları sil
                switch (soruno)
                {
                    // Cevap 1
                    case 1:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 2
                    case 2:
                        if (textBox1.Text.ToLower() == "bursa")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 3
                    case 3:
                        if (textBox1.Text.ToLower() == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 4
                    case 4:
                        if (textBox1.Text.ToLower() == "diyarbakır")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 5
                    case 5:
                        if (textBox1.Text.ToLower() == "eski")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 6
                    case 6:
                        if (textBox1.Text.ToLower() == "ferman")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 7
                    case 7:
                        if (textBox1.Text.ToLower() == "güneş")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 8
                    case 8:
                        if (textBox1.Text.ToLower() == "halı")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 9
                    case 9:
                        if (textBox1.Text.ToLower() == "ısparta")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 10
                    case 10:
                        if (textBox1.Text.ToLower() == "içel")
                        {
                            buttonİ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 11
                    case 11:
                        if (textBox1.Text.ToLower() == "jandarma")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 12
                    case 12:
                        if (textBox1.Text.ToLower() == "kayısı")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 13
                    case 13:
                        if (textBox1.Text.ToLower() == "lale")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 14
                    case 14:
                        if (textBox1.Text.ToLower() == "mart")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 15
                    case 15:
                        if (textBox1.Text.ToLower() == "ney")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 16
                    case 16:
                        if (textBox1.Text.ToLower() == "ozan")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 17
                    case 17:
                        if (textBox1.Text.ToLower() == "pilav")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 18
                    case 18:
                        if (textBox1.Text.ToLower() == "ramazan")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 19
                    case 19:
                        if (textBox1.Text.ToLower() == "snake")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 20
                    case 20:
                        if (textBox1.Text.ToLower() == "tarkan")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 21
                    case 21:
                        if (textBox1.Text.ToLower() == "umut")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 22
                    case 22:
                        if (textBox1.Text.ToLower() == "van")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 23
                    case 23:
                        if (textBox1.Text.ToLower() == "yıldırım")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    // Cevap 24
                    case 24:
                        if (textBox1.Text.ToLower() == "zeytin")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                }
            }
            }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                buttonA.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz?";
                buttonB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü?";
                buttonC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz?";
                buttonD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                buttonE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                buttonF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                buttonG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                buttonH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülü ile meşhur ilimiz?";
                buttonI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                buttonİ.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                buttonJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                buttonK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali?";
                buttonL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                buttonM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                buttonN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi?";
                buttonO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların hiç sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                buttonP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                buttonR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                buttonS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı?";
                buttonT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                buttonU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                buttonV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                buttonY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                buttonZ.BackColor = Color.Yellow;
            }
        }
    }
}
