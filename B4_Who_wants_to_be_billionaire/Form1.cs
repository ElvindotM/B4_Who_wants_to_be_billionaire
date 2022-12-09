using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace B4_Who_wants_to_be_billionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SualN=0, Qazanc=0;

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kim milyonçu olmaq istəyir proqramına xoş gəldiniz!" + "\n" + "Hazırsınız?");
            BtnSonraki.Enabled = false;
            BtnBitir.Enabled = false;
            BtnBasla.Enabled = false;

            SualN++;
            
            
            if (SualN == 1)
            {
                richTextBox1.Text = "1. BMW markalı avtomobil hansı ölkədə istehsal edilir?";
                BtnA.Text = "A: Abş";
                BtnB.Text = "B: Böyük Britaniya";
                BtnC.Text = "C: Almaniya";
                BtnD.Text = "D: Azərbaycan";
                label17.Text = "C: Almaniya";
                
            }
            
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnBasla.Enabled = false;

            Qazanc++;

            label18.Text=BtnA.Text;
            if (label18.Text==label17.Text)
            {
                BtnA.BackColor = Color.Green;
                BtnSonraki.Enabled=true;
                switch (Qazanc)
                {
                    case 1: LblQazanc.Text = "100" + ".00 ₼";
                        break;
                    case 2: LblQazanc.Text = "200" + ".00 ₼";
                        break;
                    case 3: LblQazanc.Text = "300" + ".00 ₼";
                        break;
                    case 4: LblQazanc.Text = "500" + ".00 ₼";
                        break;
                    case 5: LblQazanc.Text = "1 000" + ".00 ₼";
                        break;
                    case 6:
                        LblQazanc.Text = "2 000" + ".00 ₼";
                        break;
                    case 7:
                        LblQazanc.Text = "4 000" + ".00 ₼";
                        break;
                    case 8:
                        LblQazanc.Text = "8 000" + ".00 ₼";
                        break;
                    case 9:
                        LblQazanc.Text = "16 000" + ".00 ₼";
                        break;
                    case 10:
                        LblQazanc.Text = "32 000" + ".00 ₼";
                        break;
                    case 11:
                        LblQazanc.Text = "64 000" + ".00 ₼";
                        break;
                    case 12:
                        LblQazanc.Text = "125 000" + ".00 ₼";
                        break;
                    case 13:
                        LblQazanc.Text = "250 000" + ".00 ₼";
                        break;
                    case 14:
                        LblQazanc.Text = "500 000" + ".00 ₼";
                        break;
                    case 15:
                        LblQazanc.Text = "1 000 000" + ".00 ₼";
                        break;
                    default: LblQazanc.Text = "0.00 ₼";
                        break;
                }


            }
            else
            {
                BtnA.BackColor = Color.Red;
                BtnSonraki.Enabled = false;
                BtnBitir.Enabled = true;
                if (label17.Text == BtnB.Text)
                {
                    BtnB.BackColor = Color.Green;
                }
                if (label17.Text == BtnC.Text)
                {
                    BtnC.BackColor = Color.Green;
                }
                if (label17.Text == BtnD.Text)
                {
                    BtnD.BackColor = Color.Green;
                }
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnBasla.Enabled = false;
            Qazanc++;

            label18.Text = BtnB.Text;
            if (label18.Text == label17.Text)
            {
                BtnB.BackColor = Color.Green;
                BtnSonraki.Enabled = true;
                switch (Qazanc)
                {
                    case 1:
                        LblQazanc.Text = "100" + ".00 ₼";
                        break;
                    case 2:
                        LblQazanc.Text = "200" + ".00 ₼";
                        break;
                    case 3:
                        LblQazanc.Text = "300" + ".00 ₼";
                        break;
                    case 4:
                        LblQazanc.Text = "500" + ".00 ₼";
                        break;
                    case 5:
                        LblQazanc.Text = "1 000" + ".00 ₼";
                        break;
                    case 6:
                        LblQazanc.Text = "2 000" + ".00 ₼";
                        break;
                    case 7:
                        LblQazanc.Text = "4 000" + ".00 ₼";
                        break;
                    case 8:
                        LblQazanc.Text = "8 000" + ".00 ₼";
                        break;
                    case 9:
                        LblQazanc.Text = "16 000" + ".00 ₼";
                        break;
                    case 10:
                        LblQazanc.Text = "32 000" + ".00 ₼";
                        break;
                    case 11:
                        LblQazanc.Text = "64 000" + ".00 ₼";
                        break;
                    case 12:
                        LblQazanc.Text = "125 000" + ".00 ₼";
                        break;
                    case 13:
                        LblQazanc.Text = "250 000" + ".00 ₼";
                        break;
                    case 14:
                        LblQazanc.Text = "500 000" + ".00 ₼";
                        break;
                    case 15:
                        LblQazanc.Text = "1 000 000" + ".00 ₼";
                        break;
                    default:
                        LblQazanc.Text = "0.00 ₼";
                        break;
                }
            }
            else
            {
                BtnB.BackColor = Color.Red;
                BtnSonraki.Enabled = false;
                BtnBitir.Enabled = true;
                if (label17.Text == BtnA.Text)
                {
                    BtnA.BackColor = Color.Green;
                }
                if (label17.Text == BtnC.Text)
                {
                    BtnC.BackColor = Color.Green;
                }
                if (label17.Text == BtnD.Text)
                {
                    BtnD.BackColor = Color.Green;
                }
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnD.Enabled = false;
            BtnBasla.Enabled = false;
            Qazanc++;

            label18.Text = BtnC.Text;
            if (label18.Text == label17.Text)
            {
                BtnC.BackColor = Color.Green;
                BtnSonraki.Enabled = true;
                switch (Qazanc)
                {
                    case 1:
                        LblQazanc.Text = "100" + ".00 ₼";
                        break;
                    case 2:
                        LblQazanc.Text = "200" + ".00 ₼";
                        break;
                    case 3:
                        LblQazanc.Text = "300" + ".00 ₼";
                        break;
                    case 4:
                        LblQazanc.Text = "500" + ".00 ₼";
                        break;
                    case 5:
                        LblQazanc.Text = "1 000" + ".00 ₼";
                        break;
                    case 6:
                        LblQazanc.Text = "2 000" + ".00 ₼";
                        break;
                    case 7:
                        LblQazanc.Text = "4 000" + ".00 ₼";
                        break;
                    case 8:
                        LblQazanc.Text = "8 000" + ".00 ₼";
                        break;
                    case 9:
                        LblQazanc.Text = "16 000" + ".00 ₼";
                        break;
                    case 10:
                        LblQazanc.Text = "32 000" + ".00 ₼";
                        break;
                    case 11:
                        LblQazanc.Text = "64 000" + ".00 ₼";
                        break;
                    case 12:
                        LblQazanc.Text = "125 000" + ".00 ₼";
                        break;
                    case 13:
                        LblQazanc.Text = "250 000" + ".00 ₼";
                        break;
                    case 14:
                        LblQazanc.Text = "500 000" + ".00 ₼";
                        break;
                    case 15:
                        LblQazanc.Text = "1 000 000" + ".00 ₼";
                        break;
                    default:
                        LblQazanc.Text = "0.00 ₼";
                        break;
                }


            }
            else
            {
                BtnC.BackColor = Color.Red;
                BtnSonraki.Enabled = false;
                BtnBitir.Enabled = true;
                if (label17.Text == BtnB.Text)
                {
                    BtnB.BackColor = Color.Green;
                }
                if (label17.Text == BtnA.Text)
                {
                    BtnA.BackColor = Color.Green;
                }
                if (label17.Text == BtnD.Text)
                {
                    BtnD.BackColor = Color.Green;
                }
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnBasla.Enabled = false;
            Qazanc++;

            label18.Text = BtnD.Text;
            if (label18.Text == label17.Text)
            {
                BtnD.BackColor = Color.Green;
                BtnSonraki.Enabled = true;
                switch (Qazanc)
                {
                    case 1:
                        LblQazanc.Text = "100" + ".00 ₼";
                        break;
                    case 2:
                        LblQazanc.Text = "200" + ".00 ₼";
                        break;
                    case 3:
                        LblQazanc.Text = "300" + ".00 ₼";
                        break;
                    case 4:
                        LblQazanc.Text = "500" + ".00 ₼";
                        break;
                    case 5:
                        LblQazanc.Text = "1 000" + ".00 ₼";
                        break;
                    case 6:
                        LblQazanc.Text = "2 000" + ".00 ₼";
                        break;
                    case 7:
                        LblQazanc.Text = "4 000" + ".00 ₼";
                        break;
                    case 8:
                        LblQazanc.Text = "8 000" + ".00 ₼";
                        break;
                    case 9:
                        LblQazanc.Text = "16 000" + ".00 ₼";
                        break;
                    case 10:
                        LblQazanc.Text = "32 000" + ".00 ₼";
                        break;
                    case 11:
                        LblQazanc.Text = "64 000" + ".00 ₼";
                        break;
                    case 12:
                        LblQazanc.Text = "125 000" + ".00 ₼";
                        break;
                    case 13:
                        LblQazanc.Text = "250 000" + ".00 ₼";
                        break;
                    case 14:
                        LblQazanc.Text = "500 000" + ".00 ₼";
                        break;
                    case 15:
                        LblQazanc.Text = "1 000 000" + ".00 ₼";
                        break;
                    default:
                        LblQazanc.Text = "0.00 ₼";
                        break;
                }
            }
            else
            {
                BtnD.BackColor = Color.Red;
                BtnSonraki.Enabled = false;
                BtnBitir.Enabled = true;
                if (label17.Text == BtnB.Text)
                {
                    BtnB.BackColor = Color.Green;
                }
                if (label17.Text == BtnC.Text)
                {
                    BtnC.BackColor = Color.Green;
                }
                if (label17.Text == BtnA.Text)
                {
                    BtnA.BackColor = Color.Green;
                }
            }
        }

        private void BtnBitir_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = false;
            MessageBox.Show("Təbrik edirik!" + "\n"+"Qazandığınız məbləğ: " + LblQazanc.Text);
            LblQazanc.Text = "0.00₼";
        }

        private void BtnYenidenBasla_Click(object sender, EventArgs e)
        {
            SualN = 0;
            Qazanc = 0;
            SualN++;
            richTextBox1.Text = "1. BMW markalı avtomobil hansı ölkədə istehsal edilir?";
            BtnA.Text = "A: Abş";
            BtnB.Text = "B: Böyük Britaniya";
            BtnC.Text = "C: Almaniya";
            BtnD.Text = "D: Azərbaycan";
            label17.Text = "C: Almaniya";
            BtnA.BackColor = Color.MidnightBlue;
            BtnB.BackColor = Color.MidnightBlue;
            BtnC.BackColor = Color.MidnightBlue;
            BtnD.BackColor = Color.MidnightBlue;
            BtnSonraki.Enabled = true;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnBitir.Enabled = true;
            
            
            BtnA.BackColor = Color.MidnightBlue;
            BtnB.BackColor= Color.MidnightBlue;
            BtnC.BackColor = Color.MidnightBlue;
            BtnD.BackColor = Color.MidnightBlue;

            SualN++;
            if (SualN==2)

            {
                richTextBox1.Text = "2. Azərbaycanın əhali sayına görə ikinci böyük şəhəri hansıdır?";
                BtnA.Text = "A: Gəncə";
                BtnB.Text = "B: Sumqayıt";
                BtnC.Text = "C: Mingəçevir";
                BtnD.Text = "D: Şamaxı";
                label17.Text = "B: Sumqayıt";
            }
            if (SualN==3)
            {
                richTextBox1.Text = "3. Ana və Poçtalyon şeirinin müəllifi kimdir?";
                BtnA.Text = "A: Mirzə Ələkbər Sabir";
                BtnB.Text = "B: Bəxtiyar Vahabzadə";
                BtnC.Text = "C: Süleyman Rüstəm";
                BtnD.Text = "D: Səməd Vurğun";
                label17.Text = "C: Süleyman Rüstəm";
            }
            if (SualN==4)
            {
                richTextBox1.Text = "4. Bəzi aylar 30, bəziləri 31; neçə ayda 28 gün var ?";
                BtnA.Text = "A: Fevral";
                BtnB.Text = "B: Noyabr";
                BtnC.Text = "C: Mart";
                BtnD.Text = "D: Bütün aylarda";
                label17.Text = "D: Bütün aylarda";
            }
            if (SualN == 5)
            {
                richTextBox1.Text = "5. Lev Tolstoy,Bernard Şou,Qandi və Pifaqoru birləşdirən cəhət nədir?";
                BtnA.Text = "A: Yazıçı olmaqları";
                BtnB.Text = "B: Vegeterian olmaları";
                BtnC.Text = "C: Ət yeyən olmaları";
                BtnD.Text = "D: Elmi tədqiqatları";
                label17.Text = "B: Vegeterian olmaları";
            }
            if (SualN == 6)
            {
                richTextBox1.Text = "6. Babək neçənci ildən azadlıq hərəkatına başçılıq etməyə başlamışdı?";
                BtnA.Text = "A: 816";
                BtnB.Text = "B: 813";
                BtnC.Text = "C: 817";
                BtnD.Text = "D: 815";
                label17.Text = "A: 816";
            }
            if (SualN == 7)
            {
                richTextBox1.Text = "7. “Dəniz kənarıyla qaçan Alabaş” əsərində bu dənizlərdən birinin adı çəkilir";
                BtnA.Text = "A: Oxot dənizi";
                BtnB.Text = "B: Xəzər dənizi";
                BtnC.Text = "C: Qara dəniz";
                BtnD.Text = "D: Azov dənizi";
                label17.Text = "A: Oxot dənizi";
            }
            if (SualN == 8)
            {
                richTextBox1.Text = "8. Yırtıcı balıq deyil";
                BtnA.Text = "A: sıf";
                BtnB.Text = "B: naxa";
                BtnC.Text = "C: durna balığı";
                BtnD.Text = "D: heç biri";
                label17.Text = "D: heç biri";
            }
            if (SualN == 9)
            {
                richTextBox1.Text = "9. Bu əsərlərdən biri M.Füzulinin \"Leyli və Məcnun\" poemasının təsiri iə yazılmışdır";
                BtnA.Text = "A: Məsihi. \"Vərqa və Gülşa\"";
                BtnB.Text = "B: \"Dastani - Əhməd Hərami\"";
                BtnC.Text = "C: Əssar Təbrizi. \"Mehr və Müştəri\"";
                BtnD.Text = "D: Həqiri Təbrizi. \"Leyli və Məcnun\"";
                label17.Text = "A: Məsihi. \"Vərqa və Gülşa\"";
            }
            if (SualN == 10)
            {
                richTextBox1.Text = "10. D.Defonun \"Robinzon Kruzo\" əsərində Robinzon tapdığı qızın adını nə qoyur?";
                BtnA.Text = "A: Bazar";
                BtnB.Text = "B: Gözəl";
                BtnC.Text = "C: Fevral";
                BtnD.Text = "D: Cümə";
                label17.Text = "D: Cümə";
            }
            if (SualN == 11)
            {
                richTextBox1.Text = "11. 4 ədəd dizi olan yeganə heyvan hansıdır?";
                BtnA.Text = "A: Ayı";
                BtnB.Text = "B: Zürafə";
                BtnC.Text = "C: Fil";
                BtnD.Text = "D: Dələ";
                label17.Text = "C: Fil";
            }
            if (SualN == 12)
            {
                richTextBox1.Text = "12. Hansı meyvə qəhvədən daha tez yuxunuzu açar?";
                BtnA.Text = "A: Ərik";
                BtnB.Text = "B: Limon";
                BtnC.Text = "C: Alça";
                BtnD.Text = "D: Alma";
                label17.Text = "D: Alma";
            }
            if (SualN == 13)
            {
                richTextBox1.Text = "13. Dünyanın ən böyük şəkər ixtiraçısı?";
                BtnA.Text = "A: Kolumbiya";
                BtnB.Text = "B: Kuba";
                BtnC.Text = "C: Yaponiya";
                BtnD.Text = "D: Tayland";
                label17.Text = "B: Kuba";
            }
            if (SualN == 14)
            {
                richTextBox1.Text = "14. Qayçını kim icad edib?";
                BtnA.Text = "A: Nyuton";
                BtnB.Text = "B: Fernando Magellan";
                BtnC.Text = "C: Leonardo Da Vinçi";
                BtnD.Text = "D: Arximed";
                label17.Text = "C: Leonardo Da Vinçi";
            }
            if (SualN == 15)
            {
                richTextBox1.Text = "15. İspaniya necə tərcümə olunur?";
                BtnA.Text = "A: Qırmızı yastıq";
                BtnB.Text = "B: Dovşanlar torpağı";
                BtnC.Text = "C: Sevimli heyvan";
                BtnD.Text = "D: Öküzlər vətəni";
                label17.Text = "B: Dovşanlar torpağı";
                
            }
            if (SualN == 16)
            {
                richTextBox1.Text = "";
                BtnA.Text = "A:";
                BtnB.Text = "B:";
                BtnC.Text = "C:";
                BtnD.Text = "D:";
                richTextBox1.Enabled = false;
                BtnA.Enabled= false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Siz milyonçusu oldunuz!");

            }

        }
    }
}
