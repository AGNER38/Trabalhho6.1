using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho6._1
{
 public class Veiculo
    {
        private string matricula;
        private string marca;
        private string modelo;
        private int anoFabricacao;
        private double quilometragem;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }
        public double Quilometragem
        {
            get { return quilometragem; }
            private set { quilometragem = value; }
        }
        
        public Veiculo() { }
        
        public Veiculo(string matricula, string marca, string modelo, int anoFabricacao, double quilometragem)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.quilometragem = quilometragem;
        }
        
        public void ActualizarQuilometragem(double km)
        {
            if (km > 0)
                quilometragem += km;
            else
                Console.WriteLine("Valor inválido!");
        }
        
        public void ApresentarDados()
        {
            Console.WriteLine("\n--- Dados do Veículo ---");
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + anoFabricacao);
            Console.WriteLine("Quilometragem: " + quilometragem + " km");
        }
    }

}
