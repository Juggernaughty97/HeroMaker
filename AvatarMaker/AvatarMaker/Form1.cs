using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvatarMaker
{
    public partial class Form1 : Form
    {
        

        // iamgem

        string imagem = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;

            bool[] habilidades = { false, false, false, false, false, false, false, false };

            habilidades[0] = chk_voar.Checked;
            habilidades[1] = chk_raiox.Checked;
            habilidades[2] = chk_inv.Checked;
            habilidades[3] = chk_escudo.Checked;
            habilidades[4] = chk_transf.Checked;
            habilidades[5] = chk_elast.Checked;
            habilidades[6] = chk_telep.Checked;
            habilidades[7] = chk_forca.Checked;

            // Lista, tem tamanho dinâmico consoante a quantidade de cidades
            List<String> cidades = new List<String>();

            foreach(String s in lst_cidades.SelectedItems) 
                cidades.Add(s);

            // guardar o transporte selecionado numa string
            string transporte = "";

            if (rdo_jetpack.Checked)
                transporte = "Jet Pack";
            if (rdo_tele.Checked)
                transporte = "Teletransporte";
            if (rdo_veiculo.Checked)
                transporte = "Veículo";
            if (rdo_nave.Checked)
                transporte = "Nave";

            // caracteristicas físicas

            int velocidade = scroll_vel.Value;
            int resistencia = scroll_resistencia.Value;
            int forca = scroll_forca.Value;


            lbl_pontos.Text = (scroll_vel.Value + scroll_resistencia.Value + scroll_forca.Value).ToString();


            if (velocidade + resistencia + forca > 100)
            {
                MessageBox.Show("O herói não pode ter mais que 100 pontos usados em velocidade, resitência e força.");
            }

            // datas

            DateTime aniversario = date_aniversario.Value;
            DateTime descobrimento = date_descobrimento.Value;
            DateTime falecimento = date_falecimento.Value;

            // experiencia
            decimal anos_experiencia = num_exp.Value;

            // lado mau

            int lado_mau = 0;

            lado_mau = trk_lado_mau.Value;

            



            string status_message = "O teu herói  \"" + txt_nome.Text + "\"  tem as seguintes habilidades: ";
            if (habilidades[0])
                status_message += "Voar. ";
            if (habilidades[1])
                status_message += "Visão RaioX. ";
            if (habilidades[2])
                status_message += "Invisibilidade. ";
            if (habilidades[3])
                status_message += "Escudo. ";
            if (habilidades[4])
                status_message += "Transformação. ";
            if (habilidades[5])
                status_message += "Elasticidade. ";
            if (habilidades[6])
                status_message += "Telepatia. ";
            if (habilidades[7])
                status_message += "Super Força.";

            status_message += "\nO herói defende estas cidades: ";

            foreach (String cidade in cidades)
                status_message += cidade + ". ";

            status_message += "\nO herói prefere mover-se com " + transporte + ". ";

            status_message += "\nVelocidade " + velocidade + ", resistência: " + resistencia + ", força " + forca + ". ";
            status_message += "\nNasceu a " + aniversario + ", \ndescobriu os seus super-poderes a " + descobrimento + ", \nfaleceu a " + falecimento + ". ";

            status_message += "\nAnos de experiência " + anos_experiencia + ".";

            status_message += "\nA cor da capa para o herói é " + pic_capa.BackColor.ToString() + ".";

            status_message += "\nO herói tem propensão para o lado mau de " + lado_mau + ".";

            status_message += "\nA imagem do herói é: " + imagem;

            

            if(velocidade + resistencia + forca <= 100)
            {
                Heroi heroi = new Heroi(nome, habilidades, cidades, transporte, velocidade, resistencia, forca, aniversario, descobrimento, falecimento, anos_experiencia, pic_capa.BackColor.ToString(), lado_mau, imagem);

                ListaHeroi.historia.Add(heroi);

                MessageBox.Show(status_message);

                MessageBox.Show("Já criou " + ListaHeroi.historia.Count() + " heróis.");

                Form2 f2 = new Form2();
                f2.Show();
            }
                

        }

        private void scroll_vel_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_velocidade.Text = scroll_vel.Value.ToString();

            lbl_pontos.Text = (scroll_vel.Value + scroll_forca.Value + scroll_resistencia.Value).ToString();

            while (scroll_resistencia.Value + scroll_forca.Value + scroll_vel.Value > 100)
            {
                if (scroll_vel.Value == 0)
                {
                    scroll_forca.Value -= 1;
                    lbl_forca.Text = scroll_forca.Value.ToString();
                }

                else
                {
                    if (scroll_resistencia.Value == 0)
                        scroll_forca.Value -= 1;
                    else
                        scroll_resistencia.Value -= 1;
                    lbl_forca.Text = scroll_forca.Value.ToString();
                    lbl_resistencia.Text = scroll_resistencia.Value.ToString();

                }
            }

        }

        private void scroll_resistencia_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_resistencia.Text = scroll_resistencia.Value.ToString();

            lbl_pontos.Text = (scroll_vel.Value + scroll_forca.Value + scroll_resistencia.Value).ToString();

            while (scroll_resistencia.Value + scroll_forca.Value + scroll_vel.Value > 100)
            {
                if (scroll_resistencia.Value == 0)
                {
                    scroll_forca.Value -= 1;
                    lbl_forca.Text = scroll_forca.Value.ToString(); 
                }

                else {
                    if(scroll_forca.Value == 0)
                        scroll_vel.Value -= 1;
                    else
                        scroll_forca.Value -= 1;
                    lbl_forca.Text = scroll_forca.Value.ToString();
                    lbl_velocidade.Text = scroll_vel.Value.ToString();

                }
            }
        }

        private void scroll_forca_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_forca.Text = scroll_forca.Value.ToString();

            lbl_pontos.Text = (scroll_vel.Value + scroll_forca.Value + scroll_resistencia.Value).ToString();

            while (scroll_resistencia.Value + scroll_forca.Value + scroll_vel.Value > 100)
            {
                if (scroll_forca.Value == 0)
                {
                    scroll_resistencia.Value -= 1;
                    lbl_resistencia.Text = scroll_resistencia.Value.ToString();
                }

                else
                {
                    if(scroll_vel.Value == 0)
                        scroll_resistencia.Value -= 1;
                    else
                        scroll_vel.Value -= 1;
                    lbl_resistencia.Text = scroll_resistencia.Value.ToString();
                    lbl_velocidade.Text = scroll_vel.Value.ToString();

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog corCapa = new ColorDialog();

            if(corCapa.ShowDialog() == DialogResult.OK)
            {
                pic_capa.BackColor = corCapa.Color;
            }
                
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_mau.Text = trk_lado_mau.Value.ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog portraitPicker = new OpenFileDialog();

            if (portraitPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap  (portraitPicker.FileName);

                imagem = portraitPicker.FileName;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.StartPosition = FormStartPosition.Manual;
            NewForm.Location = Location;


            NewForm.Show();
            Dispose(false);
        }
    }
}
