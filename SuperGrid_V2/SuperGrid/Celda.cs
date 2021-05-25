using System;
using System.Collections.Generic;

namespace SuperGrid
{

    public enum TipoCelda { CeldaNulo, CeldaEntero, CeldaDoble, CeldaString, CeldaFecha };

    public static class UtilCelda
    {
        // valores constantes fijos
        public const int NULOENTERO = 0;
        public const double NULODOBLE = 0.0;
        public const string NULOSTRING = "";
        // al ser static, para darle valor habria que hacer un new DateTime(), se hará en el constructor
        public static  DateTime NULOFECHA;

        static UtilCelda()
        {
            //para ASIGNAR VALOR DINAMICAMENTE CON UN NEW DATETIME AL static 
            NULOFECHA = new DateTime(0);
        }
        public static void UtilCeldaTest()
        {
            Type t = typeof(TipoCelda);
            string n = nameof(t);
            Console.WriteLine("Los posibles TipoCelda y sus valores correspondientes enum son:");
            foreach (string s in Enum.GetNames(t))
            { 
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(t, Enum.Parse(t, s), "d"));
                Console.WriteLine(n+" - "+nameof(s) );
            }
        }

        public static DateTime NuloFecha
        {
            get
            {
                return NULOFECHA;
            }
        }

        public static int NuloEntero
        {
            get
            {
                return NULOENTERO;
            }
        }
        public static double NuloDoble
        {
            get
            {
                return NULODOBLE;
            }
        }
        public static string NuloString
        {
            get
            {
                return NULOSTRING;
            }
        }
    }

    public class Celda
        {
        
        //coordenadas
        private int f, c; // f-ila , c-olumna
        //tipo
        private TipoCelda tipoCelda;
        //posibles valores
        private int     ivalor;
        private double  dvalor;
        private string  svalor;
        private DateTime fvalor;

        private  void  ResetValores()
        {
            this.ivalor = UtilCelda.NULOENTERO;
            this.dvalor = UtilCelda.NULODOBLE;
            this.svalor = UtilCelda.NULOSTRING;
            this.fvalor = UtilCelda.NULOFECHA;
        }

        public Celda()
        {
            this.f = this.c = 0;
            this.tipoCelda = TipoCelda.CeldaNulo;
            ResetValores();
        }

        public Celda(int fil, int col, int valor_int)
        {
            f = fil;
            c = col;
            ResetValores();
            tipoCelda = TipoCelda.CeldaEntero;
            this.ivalor = valor_int;
        }

        public Celda(int fil, int col, double valor_doub)
        {
            f = fil;
            c = col;
            ResetValores();
            tipoCelda = TipoCelda.CeldaDoble;
            dvalor = valor_doub;
        }

        public Celda(int fil, int col, String valor_stri)
        {
            f = fil;
            c = col;
            tipoCelda = TipoCelda.CeldaString;
            ResetValores();
            svalor = valor_stri;
        }
        public Celda(int fil, int col, DateTime valor_fecha)
        {
            f = fil;
            c = col;
            tipoCelda = TipoCelda.CeldaFecha;
            ResetValores();
            fvalor = valor_fecha;
        }

        public TipoCelda GetTipoCelda()
        {
            return this.tipoCelda;
        }

        public void GetValor(out int v) 
        {
            v = this.ivalor;
        }

        public void GetValor(out double d)
        {
            d = this.dvalor;
        }

        public void GetValor(out string s)
        {
            s = this.svalor;
        }

        public void GetValor(out DateTime f)
        {
            f = this.fvalor;
        }

        override
        public String ToString()
        {
            return "Cel[" + this.f + "," + this.c + "]- " +
                this.ivalor + 
                this.svalor + 
                this.dvalor +
                (String)Convert.ToString(this.fvalor); 
                
        }

        public TipoCelda DevuelveCelda(out int fil, out int col, out int i, out double d, out string s, out DateTime f)
        {            fil = this.f;
            col = this.c;
            i = UtilCelda.NULOENTERO;
            d = UtilCelda.NULODOBLE;
            s = UtilCelda.NULOSTRING;
            f = UtilCelda.NULOFECHA;
            
            switch (this.tipoCelda)
            {
                 case TipoCelda.CeldaEntero:
                    i = this.ivalor;
                    break;
                case TipoCelda.CeldaDoble:
                    d = this.dvalor;
                    break;
                case TipoCelda.CeldaString:
                    s = this.svalor;
                    break;
                case TipoCelda.CeldaFecha:
                    f = this.fvalor;
                    break;
                case TipoCelda.CeldaNulo:
                    // es correcto el tipo, f y c, pero contiene nulo
                    break;
                default:
                    // en caso de error en el enum this.tipoCelda
                    Console.WriteLine("Celda erronea [" + this.f + "," + this.c + "] tipo: " + this.tipoCelda);
                    Console.WriteLine(this.ToString());
                    fil = col = -1;
                    break;
            }
            return this.tipoCelda;
        }
    }
}
