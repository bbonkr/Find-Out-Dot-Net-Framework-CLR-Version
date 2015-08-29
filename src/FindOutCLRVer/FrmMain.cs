using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindOutCLRVer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            Icon = Properties.Resources.MainIcon;

            NormalFont = txtClrVersion.Font;
            errorFont = new Font(NormalFont.FontFamily, 18);

            Load += (s, e) =>
               {
               };

            btnBrowser.Click += (s, e) =>
              {
                  OpenFileDialog dialog = new OpenFileDialog();
                  dialog.AutoUpgradeEnabled = true;
                  dialog.Multiselect = false;
                  if (DialogResult.OK == dialog.ShowDialog())
                  {
                      txtFilePath.Text = dialog.FileName;

                      CheckClrVersion(dialog.FileName);
                  }
              };

            pnlDropZone.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            };

            pnlDropZone.DragDrop += (s, e) =>
            {
                string[] arrFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (arrFiles.Length > 0)
                {
                    CheckClrVersion(arrFiles[0]);
                }
            };

            pnlDropZone.Paint += (s, e) =>
            {
            };
        }

        private void CheckClrVersion(string filePath)
        {
            WhatCanIDoForYou helpme = new WhatCanIDoForYou();
            try
            {
                txtClrVersion.Font = NormalFont;
                txtClrVersion.Text = helpme.CheckClrVersion(filePath);
            }
            catch (Exception ex)
            {
                txtClrVersion.Font = errorFont;
                txtClrVersion.Text = ex.Message;
            }
        }

        private Font errorFont;
        private Font NormalFont;
    }
}