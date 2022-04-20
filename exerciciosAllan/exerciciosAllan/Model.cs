using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI14T
{
    class modelexercicios
    {
        //declarar variávei
        private double A;
        private double B;
        private double C;
        private double maca;
        private double impostos;
        //declarar construtor


        public modelexercicios()
        {

            ConsultarA = 10;
            ConsultarB = 20;
            ConsultarC = 0;
            ConsultarCustoConsumidor = 0;
            ConsultarImpostos = 73;
            ConsultarMaca = 0;
        }// fim do construtor 

        public double ConsultarA
        {
            get
            {
                return A;
            }

            set
            {
                this.A = value;

            }
        }// fim modificar num1 

        public double ConsultarB
        {
            get
            {

                return B;
            }
            set
            {

                this.B = value;

            }
        }// fim modificar num 2

        public double ConsultarC
        {
            get
            {

                return C;

            }
            set
            {

                this.C = value;
            }
        }// fim modificar num 3

        public double ConsultarImpostos
        {
            get
            {
                return impostos;
            }
            set
            {
                this.impostos = value;
            }
        }//fim do consultarImpostos

        public double ConsultarCustoConsumidor
        {
            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }
        }//fim do ConsultarCustoConsumidor

        public double ConsultarMaca
        {
            get
            {
                return maca;
            }
            set
            {
                this.maca = value;
            }
        }//fim do consultarMaca

        //Método exercício01
        public string Exercicio01()
        {
            ConsultarC = ConsultarA;
            ConsultarA = ConsultarB;
            ConsultarB = ConsultarC;
            return "A: " + ConsultarA + "\nB: " + ConsultarB;


        }//Fim do método exercício 1


        //Exercício 2


        public int Exercicio02(int num)
        {
            return num - 1;
        }

        //Exercício 3


        public double Exercicio03(double ba, double al)
        {
            return ba * al;

        }

        //Exercício 4

        public double Exercicio04(int anos, int meses, int dias)
        {
            anos = anos * 365;
            meses = meses * 30;
            return dias + anos + meses;
        }


        //Exercício 5

        public string Exercicio05(double eleitores, double vbranco, double vnulo, double vvalido)
        {
            vbranco = (vbranco / eleitores) * 100;
            vnulo = (vnulo / eleitores) * 100;
            vvalido = (vvalido / eleitores) * 100;
            string msg = "Porcentagem de votos em branco: " + vbranco + "%\n" +
                        "Porcentagem de votos nulos: " + vnulo + "%\n" +
                        "Porcentagem de votos válidos: " + vvalido + "%\n";
            return msg;


        }



        //Exercício 6

        public double Exercicio06(double sal, double perc)
        {
            perc = perc / 100;
            return perc * sal + sal;
        }


        //Exercício 7

        public double Exercicio07(double custoDeFabrica)
        {
            ConsultarCustoConsumidor = (ConsultarImpostos * custoDeFabrica) / 100;
            return ConsultarCustoConsumidor;
        }

        //Exercício 8

        public double Exercicio08(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        //Exercicio 9 

        public double Exercicio09(double maca)
        {
            if (maca < 12)
            {
                ConsultarMaca = maca * 1;
            }
            if (maca >= 12)
            {
                ConsultarMaca = maca * 1.30;
            }
            return ConsultarMaca;
        }

        //Exercicico 10

        public double Exercicio10()

    }// fim class 
}