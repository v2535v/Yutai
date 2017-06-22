﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Common.SymbolUI;

namespace Yutai.ArcGIS.Controls.SymbolUI
{
    partial class Marker3DPlacementCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marker3DPlacementCtrl));
            this.groupBox2 = new GroupBox();
            this.axSceneControl1 = new AxSceneControl();
            this.groupBox1 = new GroupBox();
            this.txtOffsetZ = new SpinEdit();
            this.label4 = new Label();
            this.txtOffsetY = new SpinEdit();
            this.txtOffsetX = new SpinEdit();
            this.label6 = new Label();
            this.label7 = new Label();
            this.groupBox3 = new GroupBox();
            this.txtRotateZ = new SpinEdit();
            this.label1 = new Label();
            this.txtRotateY = new SpinEdit();
            this.txtRotateX = new SpinEdit();
            this.label2 = new Label();
            this.label3 = new Label();
            this.groupBox4 = new GroupBox();
            this.txtDZ = new SpinEdit();
            this.label5 = new Label();
            this.txtDY = new SpinEdit();
            this.txtDX = new SpinEdit();
            this.label8 = new Label();
            this.label9 = new Label();
            this.groupBox2.SuspendLayout();
            this.axSceneControl1.BeginInit();
            this.groupBox1.SuspendLayout();
            this.txtOffsetZ.Properties.BeginInit();
            this.txtOffsetY.Properties.BeginInit();
            this.txtOffsetX.Properties.BeginInit();
            this.groupBox3.SuspendLayout();
            this.txtRotateZ.Properties.BeginInit();
            this.txtRotateY.Properties.BeginInit();
            this.txtRotateX.Properties.BeginInit();
            this.groupBox4.SuspendLayout();
            this.txtDZ.Properties.BeginInit();
            this.txtDY.Properties.BeginInit();
            this.txtDX.Properties.BeginInit();
            base.SuspendLayout();
            this.groupBox2.Controls.Add(this.axSceneControl1);
            this.groupBox2.Location = new System.Drawing.Point(232, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(152, 144);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3D预览";
            this.axSceneControl1.Location = new System.Drawing.Point(6, 20);
            this.axSceneControl1.Name = "axSceneControl1";
            this.axSceneControl1.OcxState = (AxHost.State) resources.GetObject("axSceneControl1.OcxState");
            this.axSceneControl1.Size = new Size(140, 118);
            this.axSceneControl1.TabIndex = 0;
            this.groupBox1.Controls.Add(this.txtOffsetZ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOffsetY);
            this.groupBox1.Controls.Add(this.txtOffsetX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(104, 120);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "偏移量";
            int[] bits = new int[4];
            this.txtOffsetZ.EditValue = new decimal(bits);
            this.txtOffsetZ.Location = new System.Drawing.Point(32, 80);
            this.txtOffsetZ.Name = "txtOffsetZ";
            this.txtOffsetZ.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtOffsetZ.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtOffsetZ.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 100;
            this.txtOffsetZ.Properties.MaxValue = new decimal(bits);
            bits = new int[4];
            bits[0] = 100;
            bits[3] = -2147483648;
            this.txtOffsetZ.Properties.MinValue = new decimal(bits);
            this.txtOffsetZ.Size = new Size(64, 21);
            this.txtOffsetZ.TabIndex = 84;
            this.txtOffsetZ.EditValueChanged += new EventHandler(this.txtOffsetZ_EditValueChanged);
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new Size(11, 12);
            this.label4.TabIndex = 83;
            this.label4.Text = "Z";
            bits = new int[4];
            this.txtOffsetY.EditValue = new decimal(bits);
            this.txtOffsetY.Location = new System.Drawing.Point(32, 48);
            this.txtOffsetY.Name = "txtOffsetY";
            this.txtOffsetY.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtOffsetY.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtOffsetY.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 360;
            this.txtOffsetY.Properties.MaxValue = new decimal(bits);
            bits = new int[4];
            bits[0] = 360;
            bits[3] = -2147483648;
            this.txtOffsetY.Properties.MinValue = new decimal(bits);
            this.txtOffsetY.Size = new Size(64, 21);
            this.txtOffsetY.TabIndex = 82;
            this.txtOffsetY.EditValueChanged += new EventHandler(this.txtOffsetY_EditValueChanged);
            bits = new int[4];
            this.txtOffsetX.EditValue = new decimal(bits);
            this.txtOffsetX.Location = new System.Drawing.Point(32, 24);
            this.txtOffsetX.Name = "txtOffsetX";
            this.txtOffsetX.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtOffsetX.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtOffsetX.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 100;
            this.txtOffsetX.Properties.MaxValue = new decimal(bits);
            bits = new int[4];
            bits[0] = 360;
            bits[3] = -2147483648;
            this.txtOffsetX.Properties.MinValue = new decimal(bits);
            this.txtOffsetX.Size = new Size(64, 21);
            this.txtOffsetX.TabIndex = 81;
            this.txtOffsetX.EditValueChanged += new EventHandler(this.txtOffsetX_EditValueChanged);
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Name = "label6";
            this.label6.Size = new Size(11, 12);
            this.label6.TabIndex = 80;
            this.label6.Text = "X";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new Size(11, 12);
            this.label7.TabIndex = 79;
            this.label7.Text = "Y";
            this.groupBox3.Controls.Add(this.txtRotateZ);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtRotateY);
            this.groupBox3.Controls.Add(this.txtRotateX);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(120, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(104, 120);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "旋转角度";
            bits = new int[4];
            this.txtRotateZ.EditValue = new decimal(bits);
            this.txtRotateZ.Location = new System.Drawing.Point(32, 80);
            this.txtRotateZ.Name = "txtRotateZ";
            this.txtRotateZ.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtRotateZ.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtRotateZ.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 360;
            this.txtRotateZ.Properties.MaxValue = new decimal(bits);
            bits = new int[4];
            bits[0] = 360;
            bits[3] = -2147483648;
            this.txtRotateZ.Properties.MinValue = new decimal(bits);
            this.txtRotateZ.Size = new Size(64, 21);
            this.txtRotateZ.TabIndex = 84;
            this.txtRotateZ.EditValueChanged += new EventHandler(this.txtRotateZ_EditValueChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new Size(11, 12);
            this.label1.TabIndex = 83;
            this.label1.Text = "Z";
            bits = new int[4];
            this.txtRotateY.EditValue = new decimal(bits);
            this.txtRotateY.Location = new System.Drawing.Point(32, 48);
            this.txtRotateY.Name = "txtRotateY";
            this.txtRotateY.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtRotateY.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtRotateY.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 360;
            this.txtRotateY.Properties.MaxValue = new decimal(bits);
            bits = new int[4];
            bits[0] = 360;
            bits[3] = -2147483648;
            this.txtRotateY.Properties.MinValue = new decimal(bits);
            this.txtRotateY.Size = new Size(64, 21);
            this.txtRotateY.TabIndex = 82;
            this.txtRotateY.EditValueChanged += new EventHandler(this.txtRotateY_EditValueChanged);
            bits = new int[4];
            this.txtRotateX.EditValue = new decimal(bits);
            this.txtRotateX.Location = new System.Drawing.Point(32, 24);
            this.txtRotateX.Name = "txtRotateX";
            this.txtRotateX.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtRotateX.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtRotateX.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 360;
            this.txtRotateX.Properties.MaxValue = new decimal(bits);
            bits = new int[4];
            bits[0] = 360;
            bits[3] = -2147483648;
            this.txtRotateX.Properties.MinValue = new decimal(bits);
            this.txtRotateX.Size = new Size(64, 21);
            this.txtRotateX.TabIndex = 81;
            this.txtRotateX.EditValueChanged += new EventHandler(this.txtRotateX_EditValueChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new Size(11, 12);
            this.label2.TabIndex = 80;
            this.label2.Text = "X";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new Size(11, 12);
            this.label3.TabIndex = 79;
            this.label3.Text = "Y";
            this.groupBox4.Controls.Add(this.txtDZ);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtDY);
            this.groupBox4.Controls.Add(this.txtDX);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(16, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(208, 120);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标准化起始偏移量";
            bits = new int[4];
            this.txtDZ.EditValue = new decimal(bits);
            this.txtDZ.Location = new System.Drawing.Point(56, 80);
            this.txtDZ.Name = "txtDZ";
            this.txtDZ.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtDZ.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtDZ.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 1;
            this.txtDZ.Properties.MaxValue = new decimal(bits);
            this.txtDZ.Size = new Size(64, 21);
            this.txtDZ.TabIndex = 84;
            this.txtDZ.EditValueChanged += new EventHandler(this.txtDZ_EditValueChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new Size(11, 12);
            this.label5.TabIndex = 83;
            this.label5.Text = "Z";
            bits = new int[4];
            this.txtDY.EditValue = new decimal(bits);
            this.txtDY.Location = new System.Drawing.Point(56, 48);
            this.txtDY.Name = "txtDY";
            this.txtDY.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtDY.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtDY.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 1;
            this.txtDY.Properties.MaxValue = new decimal(bits);
            this.txtDY.Size = new Size(64, 21);
            this.txtDY.TabIndex = 82;
            this.txtDY.EditValueChanged += new EventHandler(this.txtDY_EditValueChanged);
            bits = new int[4];
            this.txtDX.EditValue = new decimal(bits);
            this.txtDX.Location = new System.Drawing.Point(56, 24);
            this.txtDX.Name = "txtDX";
            this.txtDX.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.txtDX.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.txtDX.Properties.EditFormat.FormatType = FormatType.Numeric;
            bits = new int[4];
            bits[0] = 1;
            this.txtDX.Properties.MaxValue = new decimal(bits);
            this.txtDX.Size = new Size(64, 21);
            this.txtDX.TabIndex = 81;
            this.txtDX.EditValueChanged += new EventHandler(this.txtDX_EditValueChanged);
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new Size(11, 12);
            this.label8.TabIndex = 80;
            this.label8.Text = "X";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 56);
            this.label9.Name = "label9";
            this.label9.Size = new Size(11, 12);
            this.label9.TabIndex = 79;
            this.label9.Text = "Y";
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Name = "Marker3DPlacementCtrl";
            base.Size = new Size(400, 288);
            base.Load += new EventHandler(this.Marker3DPlacementCtrl_Load);
            this.groupBox2.ResumeLayout(false);
            this.axSceneControl1.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtOffsetZ.Properties.EndInit();
            this.txtOffsetY.Properties.EndInit();
            this.txtOffsetX.Properties.EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.txtRotateZ.Properties.EndInit();
            this.txtRotateY.Properties.EndInit();
            this.txtRotateX.Properties.EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.txtDZ.Properties.EndInit();
            this.txtDY.Properties.EndInit();
            this.txtDX.Properties.EndInit();
            base.ResumeLayout(false);
        }

       
        private Container components = null;
        private AxSceneControl axSceneControl1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private SpinEdit txtDX;
        private SpinEdit txtDY;
        private SpinEdit txtDZ;
        private SpinEdit txtOffsetX;
        private SpinEdit txtOffsetY;
        private SpinEdit txtOffsetZ;
        private SpinEdit txtRotateX;
        private SpinEdit txtRotateY;
        private SpinEdit txtRotateZ;
    }
}