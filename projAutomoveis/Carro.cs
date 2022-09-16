using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace projAutomoveis
{

    //Criação da Classe 'Carro' e definindo a herança da classe 'Veiculo'

    public class Carro : Veiculo
    {
        private double capacid_bagagem;
        private int num_portas;
        private string tipo_carroceria;

        // Criação dos contrutores sem parâmetros

        public Carro()
        {
            capacid_bagagem = 0;
            num_portas = 0;
            tipo_carroceria = null;
        
        }

        // Criação dos contrutores com parâmetros + os atributos herdados pelo classe 'Veiculo'

        public Carro(string modelo, string placa, string cor, string tipo_carroceria,
        int ano, double capacid_bagagem, int num_portas, string chassi)

        {
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Tipo_carroceria = tipo_carroceria;
            this.Ano = ano;
            this.Capacid_bagagem = capacid_bagagem;
            this.Num_portas = num_portas;     
            this.Chassi = chassi;          

        }

        // Propriedades e tipos dos atributos

        public double Capacid_bagagem
        {
            get { return capacid_bagagem; }
            set { capacid_bagagem = value; }
        }

        public int Num_portas
        {
            get { return num_portas; }
            set { num_portas = value; }
        }

        public string Tipo_carroceria
        {
            get { return tipo_carroceria; }
            set { tipo_carroceria = value; }
        }

        //Sobrescrevendo o método MostrarDados com os valores dos atributos concatenados no objeto 'message'

        public override string MostrarDados()
        {
            string message = string.Empty;
            message = String.Concat("MODELO: ", this.Modelo, "\n",
                                    "PLACA: ", this.Placa, "\n",
                                    "COR: ", this.Cor, "\n",
                                    "TIPO DE CARROCERIA: ", this.Tipo_carroceria, "\n",
                                    "ANO: ", this.Ano, "\n",
                                    "CAPACIDADE DA BAGAGEM: ", this.Capacid_bagagem, " LITROS", "\n",
                                    "NÚMEROS DE PORTA: ", this.Num_portas, "\n",
                                    "CHASSI: ", this.Chassi, "\n"
                );

            return message;

        }

    }
}
