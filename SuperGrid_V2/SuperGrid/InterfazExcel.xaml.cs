using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SuperGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class InterfazExcel : Window
    {
        public int contador = 0;
        // constantes
        const int FILAS_MAX = 9;
        const int COLUM_MAX = 9;
        // datos
        public Celda[,] memoryCeldas;

        // intefaz
        // InterfaceCeldas es un grid, con Grid.Row y Grid.Column se regula fila/columna

        public InterfazExcel()
        {
            InitializeComponent();
            PreparaCeldas();
            PreparaInterfaz();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void PreparaCeldas()
        {
            memoryCeldas = new Celda[FILAS_MAX + 1, COLUM_MAX + 1];
        }

        private void PreparaInterfaz()
        {
            // carga objetos ya definidos en el interfaz
            ColumnDefinition coldef;
            RowDefinition rowdef;
            // coldef = InterfaceCeldas.ColumnDefinitions;
            
            //InterfaceCeldas.Children.
            Brush bGris = Brushes.LightGray;
        
            //Celda c = new Celda();
            //memoryCeldas[0 , 0] = c;
            memoryCeldas[0, 0] = new Celda(0, 0, "ESQUINA00");

            Label lbEsquina = new Label();
            lbEsquina.Content = "ESQUINA";
            lbEsquina.Tag = "ESQUINA00";
            lbEsquina.Background = bGris;
            
            Grid.SetRow(lbEsquina, 0);
            Grid.SetColumn(lbEsquina, 0);
            InterfaceCeldas.Children.Add(lbEsquina);
            

            // Relleno etiquetas fila ff columna 0
            for (int ff = 1; ff <= FILAS_MAX; ff++)
            {
                memoryCeldas[ff , 0] = new Celda(ff,0,"ETF");

                Label lbNuevo = new Label();
                lbNuevo.Content = "Fila0" + ff ;
                lbNuevo.Tag = "ETI_FILA_" + ff;
                lbNuevo.Background = bGris;
                Grid.SetRow(lbNuevo, ff);
                Grid.SetColumn(lbNuevo, 0);
                InterfaceCeldas.Children.Add(lbNuevo);
            }

            // Relleno etiquetas fila 0 columna cc
            for (int cc = 1; cc <= COLUM_MAX; cc++)
            {
                memoryCeldas[0 , cc] = new Celda(0,cc,"ETC");

                Label lbNuevo = new Label();
                lbNuevo.Content = "Columna0" + cc;
                lbNuevo.Tag = "ETI_COLUMNA_" + cc;
                lbNuevo.Background = bGris;
                Grid.SetRow(lbNuevo, 0);
                Grid.SetColumn(lbNuevo, cc);
                InterfaceCeldas.Children.Add(lbNuevo);

            }

        }


        //private void addCol(object sender, RoutedEventArgs e)
        //{
        //    colDef1 = new ColumnDefinition();
        //    grid1.ColumnDefinitions.Add(colDef1);
        //}

        //private void addRow(object sender, RoutedEventArgs e)
        //{
        //    rowDef1 = new RowDefinition();
        //    grid1.RowDefinitions.Add(rowDef1);
        //}

        private void Accion_Crear(object sender, RoutedEventArgs e)
        {
            Label lbNuevo = new Label();
            lbNuevo.Content = "label" + contador++;
            lbNuevo.Tag = "String";

        }

        private void Accion_CrearBien(object sender, RoutedEventArgs e)
        {
            Label lbNuevo = new Label();
            lbNuevo.Content = "label" + contador++;
            lbNuevo.Tag = "String";

        }

        private void Accion_Generar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Generando");
        }

        private void Accion_Test (object sender, RoutedEventArgs e)
        {
           
            // probando nombres del tipo enum TipoCelda
            Type nombretipos = typeof(TipoCelda);
            foreach (string s in Enum.GetNames(nombretipos))
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(nombretipos, Enum.Parse(nombretipos, s), "d"));

            UtilCelda.UtilCeldaTest();

            // objeto  encoding ASCII. para conversion String/CHar[] <--> Byte[]
            ASCIIEncoding ascii = new ASCIIEncoding();
            String unicodeString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Encode string. Char[] --> Byte[]
            Byte[] encodedBytes = ascii.GetBytes(unicodeString);
            // Decode Byte[] -->char[]
            Char[] decodedChars = ascii.GetChars(encodedBytes);
            MessageBox.Show("BYTE: " + encodedBytes[0] + "\t CHAR: " + decodedChars[0]);
            String muestra = "BYTE: " + encodedBytes[0] + "\t CHAR: " + decodedChars[0];
            for ( int i=0; i < unicodeString.Length; i++)
            {
                muestra+= "\n BYTE: " + encodedBytes[i] + "\t CHAR: " + decodedChars[i];
            }

            MessageBox.Show(muestra);

            //// correlation encodedBYTE - decodedCHAR para generar letra columna
            //// A --> 65;  B --> 66; etc    
            //// decodedCharsevolver 69 --> D
            //encodedBytes[0] += 4;
            //decodedChars = ascii.GetChars(encodedBytes);
            //MessageBox.Show("BYTE: " + encodedBytes[0] + "\t CHAR: " + charCalculado[0]);


        }
    }
}
