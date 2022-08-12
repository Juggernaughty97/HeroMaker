using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatarMaker
{
    public class Heroi : IComparable
    {
        public Heroi(string nome, bool[] habilidadesEspeciais, List<string> localizacoes, string transporte, int velocidade, int resistencia, int forca, DateTime aniversario, DateTime descobrimento, DateTime falecimento, decimal experiencia, string corCapa, int ladoMau, string imagem)
        {
            this.nome = nome;
            this.habilidadesEspeciais = habilidadesEspeciais;
            this.localizacoes = localizacoes;
            this.transporte = transporte;
            this.velocidade = velocidade;
            this.resistencia = resistencia;
            this.forca = forca;
            this.aniversario = aniversario;
            this.descobrimento = descobrimento;
            this.falecimento = falecimento;
            this.experiencia = experiencia;
            this.corCapa = corCapa;
            this.ladoMau = ladoMau;
            this.imagem = imagem;
        }

        public string nome { get; set; }
        public bool[] habilidadesEspeciais { get; set; }
        public List<String> localizacoes { get; set; }
        public string transporte { get; set; }
        public int velocidade { get; set; }
        public int resistencia { get; set; }
        public int forca { get; set; }
        public DateTime aniversario { get; set; }
        public DateTime descobrimento { get; set; }
        public DateTime falecimento { get; set; }
        public decimal experiencia { get; set; }
        public string corCapa { get; set; }
        public int ladoMau { get; set; }
        public string imagem { get; set; }

        public int CompareTo(object obj)
        {
            Heroi outroHeroi = (Heroi) obj;
            return nome.CompareTo(outroHeroi.nome);
        }

        override public string ToString()
        {

            string status_message = "";

            status_message += "Nome: " + nome;


            status_message += "\r\ntem as seguintes habilidades: ";
            
            if (habilidadesEspeciais[0])
                status_message += "Voar. ";
            if (habilidadesEspeciais[1])
                status_message += "Visão RaioX. ";
            if (habilidadesEspeciais[2])
                status_message += "Invisibilidade. ";
            if (habilidadesEspeciais[3])
                status_message += "Escudo. ";
            if (habilidadesEspeciais[4])
                status_message += "Transformação. ";
            if (habilidadesEspeciais[5])
                status_message += "Elasticidade. ";
            if (habilidadesEspeciais[6])
                status_message += "Telepatia. ";
            if (habilidadesEspeciais[7])
                status_message += "Super Força.";

            status_message += "\r\nO herói defende estas cidades: ";

            foreach (String cidade in localizacoes)
                status_message += cidade + ". ";

            status_message += "\r\nO herói prefere mover-se com " + transporte + ". ";

            status_message += "\r\nVelocidade " + velocidade + ", resistência: " + resistencia + ", força " + forca + ". ";
            status_message += "\r\nNasceu a " + aniversario + ", \r\nDescobriu os seus super-poderes a " + descobrimento + ", \r\nFaleceu a " + falecimento + ". ";

            status_message += "\r\nAnos de experiência " + experiencia + ".";

            status_message += "\r\nA cor da capa para o herói é " + corCapa.ToString() + ".";

            status_message += "\r\nO herói tem propensão para o lado mau de " + ladoMau + ".";

            status_message += "\r\nA imagem do herói é: " + imagem;


            return status_message;
        }

    }
}
