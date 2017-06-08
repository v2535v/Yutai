﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ESRI.ArcGIS.Display;

namespace Yutai.ArcGIS.Controls.SymbolLib
{
    internal class GeometricEffectRadialfromPointPage : GeometricEffectBaseControl
    {
        private Button btnAddGemoetricEffic;
        private Button btnChangeEffic;
        private IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label label3;
        private BasicSymbolLayerBaseControl m_pControl = null;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;

        public GeometricEffectRadialfromPointPage(BasicSymbolLayerBaseControl pControl)
        {
            this.InitializeComponent();
            base.m_pGeometricEffect = new GeometricEffectRadialClass();
            this.m_pControl = pControl;
        }

        public override bool Apply()
        {
            double val = 0.0;
            double num2 = 0.0;
            try
            {
                val = double.Parse(this.textBox1.Text);
            }
            catch
            {
                MessageBox.Show("请出入数字型数据！");
                return false;
            }
            try
            {
                num2 = double.Parse(this.textBox2.Text);
            }
            catch
            {
                MessageBox.Show("请出入数字型数据！");
                return false;
            }
            (base.m_pGeometricEffect as IGraphicAttributes).set_Value((int) this.textBox1.Tag, val);
            (base.m_pGeometricEffect as IGraphicAttributes).set_Value((int) this.textBox2.Tag, num2);
            return true;
        }

        private void btnAddGemoetricEffic_Click(object sender, EventArgs e)
        {
            frmGeometricEffectList list = new frmGeometricEffectList {
                BasicSymbolLayerBaseControl = this.m_pControl
            };
            if ((list.ShowDialog() == DialogResult.OK) && (this.m_pControl != null))
            {
                this.m_pControl.AddControl(this, list.SelectControl);
            }
        }

        private void btnChangeEffic_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Show(this, this.btnChangeEffic.Right, this.btnChangeEffic.Bottom);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void GeometricEffectRadialfromPointPage_Load(object sender, EventArgs e)
        {
            if (base.m_pGeometricEffect == null)
            {
                base.m_pGeometricEffect = new GeometricEffectRadialClass();
            }
            int graphicAttributeCount = (base.m_pGeometricEffect as IGraphicAttributes).GraphicAttributeCount;
            int attrId = (base.m_pGeometricEffect as IGraphicAttributes).get_ID(0);
            string str = (base.m_pGeometricEffect as IGraphicAttributes).get_Name(attrId);
            this.textBox1.Text = (base.m_pGeometricEffect as IGraphicAttributes).get_Value(attrId).ToString();
            this.textBox1.Tag = attrId;
            attrId = (base.m_pGeometricEffect as IGraphicAttributes).get_ID(1);
            str = (base.m_pGeometricEffect as IGraphicAttributes).get_Name(attrId);
            this.textBox2.Text = (base.m_pGeometricEffect as IGraphicAttributes).get_Value(attrId).ToString();
            this.textBox2.Tag = attrId;
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometricEffectRadialfromPointPage));
            this.label1 = new Label();
            this.panel1 = new Panel();
            this.textBox2 = new TextBox();
            this.label3 = new Label();
            this.textBox1 = new TextBox();
            this.label2 = new Label();
            this.btnChangeEffic = new Button();
            this.imageList1 = new ImageList(this.components);
            this.panel2 = new Panel();
            this.btnAddGemoetricEffic = new Button();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new ToolStripMenuItem();
            this.删除ToolStripMenuItem = new ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.ForeColor = SystemColors.ActiveCaptionText;
            this.label1.Location = new Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x1d, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "射线";
            this.panel1.BackColor = SystemColors.Window;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 0x21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0xd4, 0x3d);
            this.panel1.TabIndex = 1;
            this.textBox2.Location = new Point(0x40, 0x22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0x81, 0x15);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            this.textBox2.Leave += new EventHandler(this.textBox1_Leave);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 0x25);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "长度:";
            this.textBox1.Location = new Point(0x40, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x81, 0x15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "角度:";
            this.btnChangeEffic.ImageIndex = 0;
            this.btnChangeEffic.ImageList = this.imageList1;
            this.btnChangeEffic.Location = new Point(0xc1, 0);
            this.btnChangeEffic.Name = "btnChangeEffic";
            this.btnChangeEffic.RightToLeft = RightToLeft.Yes;
            this.btnChangeEffic.Size = new Size(0x10, 0x10);
            this.btnChangeEffic.TabIndex = 2;
            this.btnChangeEffic.UseVisualStyleBackColor = true;
            this.btnChangeEffic.Click += new EventHandler(this.btnChangeEffic_Click);
            this.imageList1.ImageStream = (ImageListStreamer) resources.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.White;
            this.imageList1.Images.SetKeyName(0, "Bitmap4.bmp");
            this.imageList1.Images.SetKeyName(1, "Bitmap5.bmp");
            this.panel2.BackColor = SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnChangeEffic);
            this.panel2.Location = new Point(3, 0x10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(0xed, 0x11);
            this.panel2.TabIndex = 3;
            this.btnAddGemoetricEffic.ImageIndex = 1;
            this.btnAddGemoetricEffic.ImageList = this.imageList1;
            this.btnAddGemoetricEffic.Location = new Point(0xc4, 0);
            this.btnAddGemoetricEffic.Name = "btnAddGemoetricEffic";
            this.btnAddGemoetricEffic.RightToLeft = RightToLeft.Yes;
            this.btnAddGemoetricEffic.Size = new Size(0x10, 0x10);
            this.btnAddGemoetricEffic.TabIndex = 4;
            this.btnAddGemoetricEffic.UseVisualStyleBackColor = true;
            this.btnAddGemoetricEffic.Click += new EventHandler(this.btnAddGemoetricEffic_Click);
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.修改ToolStripMenuItem, this.删除ToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x63, 0x30);
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new Size(0x62, 0x16);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new EventHandler(this.修改ToolStripMenuItem_Click);
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new Size(0x62, 0x16);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new EventHandler(this.删除ToolStripMenuItem_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            base.Controls.Add(this.btnAddGemoetricEffic);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.panel1);
            base.Name = "GeometricEffectRadialfromPointPage";
            base.Size = new Size(0xd4, 0x5e);
            base.Load += new EventHandler(this.GeometricEffectRadialfromPointPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            double val = 0.0;
            try
            {
                val = double.Parse((sender as TextBox).Text);
            }
            catch
            {
                return;
            }
            (base.m_pGeometricEffect as IGraphicAttributes).set_Value((int) (sender as TextBox).Tag, val);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.m_pControl != null)
            {
                this.m_pControl.RemoveControl(this);
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeometricEffectList list = new frmGeometricEffectList {
                BasicSymbolLayerBaseControl = this.m_pControl
            };
            if ((list.ShowDialog() == DialogResult.OK) && (this.m_pControl != null))
            {
                this.m_pControl.ReplaceControl(this, list.SelectControl);
            }
        }
    }
}
