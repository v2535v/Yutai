﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Output;

namespace Yutai.ArcGIS.Controls.Controls.Export
{
    partial class ExportMap2SVGPropertyPage
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

       
        private void InitializeComponent()
        {
            this.chkPolygonizeMarkers = new CheckEdit();
            this.label2 = new Label();
            this.cboColorspace = new ComboBoxEdit();
            this.chkEmbedFonts = new CheckEdit();
            this.chkCompress = new CheckEdit();
            this.chkPolygonizeMarkers.Properties.BeginInit();
            this.cboColorspace.Properties.BeginInit();
            this.chkEmbedFonts.Properties.BeginInit();
            this.chkCompress.Properties.BeginInit();
            base.SuspendLayout();
            this.chkPolygonizeMarkers.Location = new Point(8, 80);
            this.chkPolygonizeMarkers.Name = "chkPolygonizeMarkers";
            this.chkPolygonizeMarkers.Properties.Caption = "转换标记符号为多边形";
            this.chkPolygonizeMarkers.Size = new Size(144, 19);
            this.chkPolygonizeMarkers.TabIndex = 4;
            this.chkPolygonizeMarkers.CheckedChanged += new EventHandler(this.chkPolygonizeMarkers_CheckedChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "目标颜色空间:";
            this.cboColorspace.EditValue = "RGB";
            this.cboColorspace.Location = new Point(96, 8);
            this.cboColorspace.Name = "cboColorspace";
            this.cboColorspace.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboColorspace.Properties.Items.AddRange(new object[] { "RGB", "CMYK" });
            this.cboColorspace.Size = new Size(96, 23);
            this.cboColorspace.TabIndex = 6;
            this.cboColorspace.SelectedIndexChanged += new EventHandler(this.cboColorspace_SelectedIndexChanged);
            this.chkEmbedFonts.Location = new Point(8, 104);
            this.chkEmbedFonts.Name = "chkEmbedFonts";
            this.chkEmbedFonts.Properties.Caption = "内置所有文档字体";
            this.chkEmbedFonts.Size = new Size(144, 19);
            this.chkEmbedFonts.TabIndex = 9;
            this.chkEmbedFonts.CheckedChanged += new EventHandler(this.cboEmbedFonts_CheckedChanged);
            this.chkCompress.Location = new Point(8, 56);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Properties.Caption = "压缩";
            this.chkCompress.Size = new Size(144, 19);
            this.chkCompress.TabIndex = 11;
            this.chkCompress.CheckedChanged += new EventHandler(this.chkCompress_CheckedChanged);
            base.Controls.Add(this.chkCompress);
            base.Controls.Add(this.chkEmbedFonts);
            base.Controls.Add(this.cboColorspace);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.chkPolygonizeMarkers);
            base.Name = "ExportMap2SVGPropertyPage";
            base.Size = new Size(216, 184);
            base.Load += new EventHandler(this.ExportMap2EMFPropertyPage_Load);
            this.chkPolygonizeMarkers.Properties.EndInit();
            this.cboColorspace.Properties.EndInit();
            this.chkEmbedFonts.Properties.EndInit();
            this.chkCompress.Properties.EndInit();
            base.ResumeLayout(false);
        }

       
        private Container components = null;
        private ComboBoxEdit cboColorspace;
        private CheckEdit chkCompress;
        private CheckEdit chkEmbedFonts;
        private CheckEdit chkPolygonizeMarkers;
        private Label label2;
    }
}