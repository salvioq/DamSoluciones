﻿using System;
using System.IO;
using System.Text;

namespace SuperGrid
{
    /// <summary>
    /// Produces Excel file without using Excel
    /// Source code from: https://www.codeproject.com/Articles/33850/Generate-Excel-files-without-using-Microsoft-Excel
    /// Author: Serhiy Perevoznyk  https://www.codeproject.com/script/Membership/View.aspx?mid=2232138
    /// </summary>
    /// 
    /// 
    /// 
    /// 
    // <?xml version="1.0" encoding="UTF-8"?>;
    // <? mso-application progid = "Excel.Sheet" ?>
    // < Workbook xmlns = "urn:schemas-microsoft-com:office:spreadsheet" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet" xmlns:html="https://www.w3.org/TR/html401/">
    
    //<Worksheet ss:Name="CognaLearn+Intedashboard">
    
    //<Table>
    //<Column ss:Index="1" ss:AutoFitWidth="0" ss:Width="110"/>
    //<Row>
    //<Cell><Data ss:Type="String">ID</Data></Cell>
    //<Cell><Data ss:Type="String">Project</Data></Cell>
    //<Cell><Data ss:Type="String">Reporter</Data></Cell>
    //<Cell><Data ss:Type="String">Assigned To</Data></Cell>
    //<Cell><Data ss:Type= "String" > Priority </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Severity </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Reproducibility </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Product Version</Data></Cell>
    //<Cell><Data ss:Type= "String" > Category </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Date Submitted</Data></Cell>
    //<Cell><Data ss:Type= "String" > OS </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > OS Version</Data></Cell>
    //<Cell><Data ss:Type= "String" > Platform </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > View Status</Data></Cell>
    //<Cell><Data ss:Type= "String" > Updated </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Summary </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Status </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Resolution </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > Fixed in Version</Data></Cell>
    //</Row>
    //<Row>
    //<Cell><Data ss:Type= "Number" > 0000033 </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > CognaLearn Intedashboard</Data></Cell>
    //<Cell><Data ss:Type= "String" > janardhana.l </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" ></ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > normal </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > text </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > always </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" ></ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > GUI </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > 2016 - 10 - 14 </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" ></ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" ></ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" ></ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" >public</Data></Cell>
    //<Cell><Data ss:Type="String">2016-10-14</Data></Cell>
    //<Cell><Data ss:Type="String">IE8 browser_Modules screen tool tip text is shown twice</Data></Cell>
    //<Cell><Data ss:Type= "String" > new</ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" > open </ Data ></ Cell >
    //<Cell >< Data ss:Type= "String" ></ Data ></ Cell >
    //</ Row >
    //</ Table >
    //</ Worksheet >
    //</ Workbook >
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///  

    public class ExcelXMLWriter
    {
        // todo: reescribir para generar XML
        //

        private Stream stream;
        private BinaryWriter writer;

        private ushort[] clBegin = { 0x0809, 8, 0, 0x10, 0, 0 };
        private ushort[] clEnd = { 0x0A, 00 };


        private void WriteUshortArray(ushort[] value)
        {
            for (int i = 0; i < value.Length; i++)
                writer.Write(value[i]);
        }

        /// <summary>
        /// Initializes a new instance of the<see cref="ExcelWriter"/> class.
        /// </summary>
        /// <param name = "stream" > The stream.</param>
        public ExcelXMLWriter(Stream stream)
        {
            this.stream = stream;
            writer = new BinaryWriter(stream);
        }

        /// <summary>
        /// Writes the text cell value.
        /// </summary>
        /// <param name = "row" > The row.</param>
        /// <param name = "col" > The col.</param>
        /// <param name = "value" > The string value.</param>
        public void WriteCell(int row, int col, string value)
        {
            ushort[] clData = { 0x0204, 0, 0, 0, 0, 0 };
            int iLen = value.Length;
            byte[] plainText = Encoding.ASCII.GetBytes(value);
            clData[1] = (ushort)(8 + iLen);
            clData[2] = (ushort)row;
            clData[3] = (ushort)col;
            clData[5] = (ushort)iLen;
            WriteUshortArray(clData);
            writer.Write(plainText);
        }

        /// <summary>
        /// Writes the integer cell value.
        /// </summary>
        /// <param name = "row" > The row number.</param>
        /// <param name = "col" > The column number.</param>
        /// <param name = "value" > The value.</param>
        public void WriteCell(int row, int col, int value)
        {
            ushort[] clData = { 0x027E, 10, 0, 0, 0 };
            clData[2] = (ushort)row;
            clData[3] = (ushort)col;
            WriteUshortArray(clData);
            int iValue = (value << 2) | 2;
            writer.Write(iValue);
        }

        /// <summary>
        /// Writes the double cell value.
        /// </summary>
        /// <param name = "row" > The row number.</param>
        /// <param name = "col" > The column number.</param>
        /// <param name = "value" > The value.</param>
        public void WriteCell(int row, int col, double value)
        {
            ushort[] clData = { 0x0203, 14, 0, 0, 0 };
            clData[2] = (ushort)row;
            clData[3] = (ushort)col;
            WriteUshortArray(clData);
            writer.Write(value);
        }

        /// <summary>
        /// Writes the empty cell.
        /// </summary>
        /// <param name = "row" > The row number.</param>
        /// <param name = "col" > The column number.</param>
        public void WriteCell(int row, int col)
        {
            ushort[] clData = { 0x0201, 6, 0, 0, 0x17 };
            clData[2] = (ushort)row;
            clData[3] = (ushort)col;
            WriteUshortArray(clData);
        }

        /// <summary>
        /// Must be called once for creating XLS file header
        /// </summary>
        public void BeginWrite()
        {
            WriteUshortArray(clBegin);
        }

        /// <summary>
        /// Ends the writing operation, but do not close the stream
        /// </summary>
        public void EndWrite()
        {
            WriteUshortArray(clEnd);
            writer.Flush();
        }

    }
}
