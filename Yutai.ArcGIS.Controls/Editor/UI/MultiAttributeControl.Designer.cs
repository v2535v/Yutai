﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Common.BaseClasses;
using Yutai.Shared;


namespace Yutai.ArcGIS.Controls.Editor.UI
{
    partial class MultiAttributeControl
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
            this.panel1 = new Panel();
            this.textBox1 = new TextBox();
            this.treeView1 = new TreeView();
            this.splitter1 = new Splitter();
            this.panel2 = new Panel();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(104, 304);
            this.panel1.TabIndex = 0;
            this.textBox1.Dock = DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(104, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            this.treeView1.Dock = DockStyle.Fill;
            this.treeView1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = -1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = -1;
            this.treeView1.Size = new Size(104, 304);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
            this.splitter1.Location = new System.Drawing.Point(104, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 304);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(107, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(301, 304);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.splitter1);
            base.Controls.Add(this.panel1);
            this.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
            base.Name = "MultiAttributeControl";
            base.Size = new Size(408, 304);
            base.Load += new EventHandler(this.AttributeControl_Load);
            this.panel1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

       
        private Container components = null;
        private IActiveViewEvents_Event m_pActiveViewEvents;
        private IMap m_pMap;
        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private TextBox textBox1;
        private TreeView treeView1;
    }
}