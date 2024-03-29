﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SuperGrid
{
    /// <summary>
    /// Lógica de interacción para PruebaGridDinamico.xaml
    /// </summary>
    public partial class PruebaGridDinamico : Window
    {
        RowDefinition rowDef1;
        ColumnDefinition colDef1;
        public PruebaGridDinamico()
        {
            InitializeComponent();
        }


        private void addCol(object sender, RoutedEventArgs e)
        {
            colDef1 = new ColumnDefinition();
            grid1.ColumnDefinitions.Add(colDef1);
        }

        private void addRow(object sender, RoutedEventArgs e)
        {
            rowDef1 = new RowDefinition();
            grid1.RowDefinitions.Add(rowDef1);
        }

        private void clearCol(object sender, RoutedEventArgs e)
        {
            grid1.ColumnDefinitions.Clear();
        }

        private void clearRow(object sender, RoutedEventArgs e)
        {
            grid1.RowDefinitions.Clear();
        }

        private void removeCol(object sender, RoutedEventArgs e)
        {
            if (grid1.ColumnDefinitions.Count <= 0)
            {
                tp1.Content = "No More Columns to Remove!";
            }
            else
            {
                grid1.ColumnDefinitions.RemoveAt(0);
            }
        }

        private void removeRow(object sender, RoutedEventArgs e)
        {
            if (grid1.RowDefinitions.Count <= 0)
            {
                tp1.Content = "No More Rows to Remove!";
            }
            else
            {
                grid1.RowDefinitions.RemoveAt(0);
            }
        }

        private void colCount(object sender, RoutedEventArgs e)
        {
            tp2.Content = "The current number of Columns is: " + grid1.ColumnDefinitions.Count;
        }

        private void rowCount(object sender, RoutedEventArgs e)
        {
            tp2.Content = "The current number of Rows is: " + grid1.RowDefinitions.Count;
        }

        private void rem5Col(object sender, RoutedEventArgs e)
        {
            if (grid1.ColumnDefinitions.Count < 5)
            {
                tp1.Content = "There aren't five Columns to Remove!";
            }
            else
            {
                grid1.ColumnDefinitions.RemoveRange(0, 5);
            }
        }

        private void rem5Row(object sender, RoutedEventArgs e)
        {
            if (grid1.RowDefinitions.Count < 5)
            {
                tp1.Content = "There aren't five Rows to Remove!";
            }
            else
            {
                grid1.RowDefinitions.RemoveRange(0, 5);
            }
        }

        private void containsRow(object sender, RoutedEventArgs e)
        {
            if (grid1.RowDefinitions.Contains(rowDef1))
            {
                tp2.Content = "Grid Contains RowDefinition rowDef1";
            }
            else
            {
                tp2.Content = "Grid Does Not Contain RowDefinition rowDef1";
            }
        }

        private void containsCol(object sender, RoutedEventArgs e)
        {
            if (grid1.ColumnDefinitions.Contains(colDef1))
            {
                tp3.Content = "Grid Contains ColumnDefinition colDef1";
            }
            else
            {
                tp3.Content = "Grid Does Not Contain ColumnDefinition colDef1";
            }
        }

        private void colReadOnly(object sender, RoutedEventArgs e)
        {
            tp4.Content = "RowDefinitionsCollection IsReadOnly?: " + grid1.RowDefinitions.IsReadOnly.ToString();
            tp5.Content = "ColumnDefinitionsCollection IsReadOnly?: " + grid1.ColumnDefinitions.IsReadOnly.ToString();
        }

        private void insertRowAt(object sender, RoutedEventArgs e)
        {
            rowDef1 = new RowDefinition();
            grid1.RowDefinitions.Insert(grid1.RowDefinitions.Count, rowDef1);
            tp1.Content = "RowDefinition added at index position " + grid1.RowDefinitions.IndexOf(rowDef1).ToString();
        }

        private void insertColAt(object sender, RoutedEventArgs e)
        {
            colDef1 = new ColumnDefinition();
            grid1.ColumnDefinitions.Insert(grid1.ColumnDefinitions.Count, colDef1);
            tp2.Content = "ColumnDefinition added at index position " + grid1.ColumnDefinitions.IndexOf(colDef1).ToString();
        }
    }
    }
