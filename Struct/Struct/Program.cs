using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Horario agora = new Horario(11,25,00);
            Console.WriteLine("Agora são {0}", agora.Hora());

            Horario copia = agora;
            Console.WriteLine("Agora são {0}", copia.Hora());

        }

        struct Horario
        {
            private int hora, minuto, segundo;
            public Horario(int h, int m, int s)
            {
                this.hora = h % 24;
                this.minuto = m % 60;
                this.segundo = s % 60;
            }

            public String Hora()
            {
                String horaTexto = "";
                String minutoTexto = "";
                String segundoTexto = "";
                if(this.hora < 10)
                {
                    horaTexto += "0" + this.hora;
                } else
                {
                    horaTexto += this.hora;
                }

                if (this.minuto < 10)
                {
                    minutoTexto += "0" + this.hora;
                }
                else
                {
                    minutoTexto += this.minuto;
                }

                if (this.segundo < 10)
                {
                    segundoTexto += "0" + this.segundo;
                }
                else
                {
                    segundoTexto += this.segundo;
                }


                return horaTexto + ":" + minutoTexto + ":" + segundoTexto;
            }
            //public int hora, minuto, segundo;
        }
    }
}
