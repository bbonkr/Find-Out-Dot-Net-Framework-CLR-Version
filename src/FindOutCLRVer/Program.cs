using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindOutCLRVer
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                // Run Windows Form
                Application.Run(new FrmMain());
            }
            else
            {
                string filePath = args[0];

                try
                {
                    WhatCanIDoForYou helpme = new WhatCanIDoForYou();
                    Console.WriteLine("File: {0}\r\nCLR Version: {1}",
                        filePath,
                        helpme.CheckClrVersion(filePath));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
        }
    }
}