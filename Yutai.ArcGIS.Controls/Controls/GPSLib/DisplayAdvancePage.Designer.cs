﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using Yutai.ArcGIS.Common.BaseClasses;
using Yutai.ArcGIS.Common.Helpers;
using Yutai.ArcGIS.Common.SymbolLib;

namespace Yutai.ArcGIS.Controls.Controls.GPSLib
{
    partial class DisplayAdvancePage
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
            this.groupBox1 = new GroupBox();
            this.chkShowMarkerTrailBearing = new CheckBox();
            this.chkShowCurrentBearing = new CheckBox();
            this.label1 = new Label();
            this.groupBox2 = new GroupBox();
            this.colorEdit2 = new ColorEdit();
            this.colorEdit1 = new ColorEdit();
            this.chkShowMarkerTrailSpeed = new CheckBox();
            this.chkShowCurrentSpeed = new CheckBox();
            this.lblMaxSpeedUnit = new Label();
            this.lblMinSpeedUnit = new Label();
            this.cboSpeedColorRamp = new ColorRampComboBox();
            this.HighSpeedValue = new TextBox();
            this.label5 = new Label();
            this.txtLowSpeedValue = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.groupBox3 = new GroupBox();
            this.lblMaxAltituteUnit = new Label();
            this.lblMinAltituteUnit = new Label();
            this.chkShowMarkerTrailAltitude = new CheckBox();
            this.chkShowCurrentAltitude = new CheckBox();
            this.txtHighAltitudeSize = new TextBox();
            this.label11 = new Label();
            this.txtLowAltitudeSize = new TextBox();
            this.label12 = new Label();
            this.txtHighAltitudeValue = new TextBox();
            this.label9 = new Label();
            this.txtLowAltitudeValue = new TextBox();
            this.label10 = new Label();
            this.label8 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.colorEdit2.Properties.BeginInit();
            this.colorEdit1.Properties.BeginInit();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.chkShowMarkerTrailBearing);
            this.groupBox1.Controls.Add(this.chkShowCurrentBearing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(303, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            this.chkShowMarkerTrailBearing.AutoSize = true;
            this.chkShowMarkerTrailBearing.Location = new Point(155, 43);
            this.chkShowMarkerTrailBearing.Name = "chkShowMarkerTrailBearing";
            this.chkShowMarkerTrailBearing.Size = new Size(84, 16);
            this.chkShowMarkerTrailBearing.TabIndex = 2;
            this.chkShowMarkerTrailBearing.Text = "点轨迹符号";
            this.chkShowMarkerTrailBearing.UseVisualStyleBackColor = true;
            this.chkShowMarkerTrailBearing.CheckedChanged += new EventHandler(this.chkShowCurrentBearing_CheckedChanged);
            this.chkShowCurrentBearing.AutoSize = true;
            this.chkShowCurrentBearing.Location = new Point(14, 43);
            this.chkShowCurrentBearing.Name = "chkShowCurrentBearing";
            this.chkShowCurrentBearing.Size = new Size(96, 16);
            this.chkShowCurrentBearing.TabIndex = 1;
            this.chkShowCurrentBearing.Text = "当前位置符号";
            this.chkShowCurrentBearing.UseVisualStyleBackColor = true;
            this.chkShowCurrentBearing.CheckedChanged += new EventHandler(this.chkShowCurrentBearing_CheckedChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "通过以下符号旋转指定方向";
            this.groupBox2.Controls.Add(this.colorEdit2);
            this.groupBox2.Controls.Add(this.colorEdit1);
            this.groupBox2.Controls.Add(this.chkShowMarkerTrailSpeed);
            this.groupBox2.Controls.Add(this.chkShowCurrentSpeed);
            this.groupBox2.Controls.Add(this.lblMaxSpeedUnit);
            this.groupBox2.Controls.Add(this.lblMinSpeedUnit);
            this.groupBox2.Controls.Add(this.cboSpeedColorRamp);
            this.groupBox2.Controls.Add(this.HighSpeedValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLowSpeedValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new Point(9, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(303, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "速度";
            this.colorEdit2.EditValue = Color.Empty;
            this.colorEdit2.Location = new Point(235, 127);
            this.colorEdit2.Name = "colorEdit2";
            this.colorEdit2.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.colorEdit2.Size = new Size(47, 21);
            this.colorEdit2.TabIndex = 17;
            this.colorEdit2.TextChanged += new EventHandler(this.colorEdit1_TextChanged);
            this.colorEdit1.EditValue = Color.Empty;
            this.colorEdit1.Location = new Point(235, 97);
            this.colorEdit1.Name = "colorEdit1";
            this.colorEdit1.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.colorEdit1.Size = new Size(47, 21);
            this.colorEdit1.TabIndex = 16;
            this.colorEdit1.TextChanged += new EventHandler(this.colorEdit1_TextChanged);
            this.chkShowMarkerTrailSpeed.AutoSize = true;
            this.chkShowMarkerTrailSpeed.Location = new Point(143, 41);
            this.chkShowMarkerTrailSpeed.Name = "chkShowMarkerTrailSpeed";
            this.chkShowMarkerTrailSpeed.Size = new Size(84, 16);
            this.chkShowMarkerTrailSpeed.TabIndex = 15;
            this.chkShowMarkerTrailSpeed.Text = "点轨迹符号";
            this.chkShowMarkerTrailSpeed.UseVisualStyleBackColor = true;
            this.chkShowMarkerTrailSpeed.CheckedChanged += new EventHandler(this.chkShowCurrentBearing_CheckedChanged);
            this.chkShowCurrentSpeed.AutoSize = true;
            this.chkShowCurrentSpeed.Location = new Point(14, 41);
            this.chkShowCurrentSpeed.Name = "chkShowCurrentSpeed";
            this.chkShowCurrentSpeed.Size = new Size(96, 16);
            this.chkShowCurrentSpeed.TabIndex = 14;
            this.chkShowCurrentSpeed.Text = "当前位置符号";
            this.chkShowCurrentSpeed.UseVisualStyleBackColor = true;
            this.chkShowCurrentSpeed.CheckedChanged += new EventHandler(this.chkShowCurrentBearing_CheckedChanged);
            this.lblMaxSpeedUnit.AutoSize = true;
            this.lblMaxSpeedUnit.Location = new Point(166, 130);
            this.lblMaxSpeedUnit.Name = "lblMaxSpeedUnit";
            this.lblMaxSpeedUnit.Size = new Size(11, 12);
            this.lblMaxSpeedUnit.TabIndex = 13;
            this.lblMaxSpeedUnit.Text = " ";
            this.lblMinSpeedUnit.AutoSize = true;
            this.lblMinSpeedUnit.Location = new Point(166, 102);
            this.lblMinSpeedUnit.Name = "lblMinSpeedUnit";
            this.lblMinSpeedUnit.Size = new Size(11, 12);
            this.lblMinSpeedUnit.TabIndex = 12;
            this.lblMinSpeedUnit.Text = " ";
            this.cboSpeedColorRamp.FormattingEnabled = true;
            this.cboSpeedColorRamp.Location = new Point(68, 70);
            this.cboSpeedColorRamp.Name = "cboSpeedColorRamp";
            this.cboSpeedColorRamp.Size = new Size(215, 20);
            this.cboSpeedColorRamp.TabIndex = 11;
            this.cboSpeedColorRamp.SelectedIndexChanged += new EventHandler(this.cboSpeedColorRamp_SelectedIndexChanged);
            this.HighSpeedValue.Location = new Point(66, 127);
            this.HighSpeedValue.Name = "HighSpeedValue";
            this.HighSpeedValue.Size = new Size(81, 21);
            this.HighSpeedValue.TabIndex = 10;
            this.HighSpeedValue.Text = "100";
            this.HighSpeedValue.TextChanged += new EventHandler(this.txtLowSpeedValue_TextChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(9, 130);
            this.label5.Name = "label5";
            this.label5.Size = new Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "最大速度";
            this.txtLowSpeedValue.Location = new Point(66, 102);
            this.txtLowSpeedValue.Name = "txtLowSpeedValue";
            this.txtLowSpeedValue.Size = new Size(81, 21);
            this.txtLowSpeedValue.TabIndex = 8;
            this.txtLowSpeedValue.Text = "1";
            this.txtLowSpeedValue.TextChanged += new EventHandler(this.txtLowSpeedValue_TextChanged);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "最小速度";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "符号范围";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new Size(173, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用以下符号颜色设置符号化速度";
            this.groupBox3.Controls.Add(this.lblMaxAltituteUnit);
            this.groupBox3.Controls.Add(this.lblMinAltituteUnit);
            this.groupBox3.Controls.Add(this.chkShowMarkerTrailAltitude);
            this.groupBox3.Controls.Add(this.chkShowCurrentAltitude);
            this.groupBox3.Controls.Add(this.txtHighAltitudeSize);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtLowAltitudeSize);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtHighAltitudeValue);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtLowAltitudeValue);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new Point(9, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(303, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "高度";
            this.lblMaxAltituteUnit.AutoSize = true;
            this.lblMaxAltituteUnit.Location = new Point(132, 91);
            this.lblMaxAltituteUnit.Name = "lblMaxAltituteUnit";
            this.lblMaxAltituteUnit.Size = new Size(11, 12);
            this.lblMaxAltituteUnit.TabIndex = 22;
            this.lblMaxAltituteUnit.Text = " ";
            this.lblMinAltituteUnit.AutoSize = true;
            this.lblMinAltituteUnit.Location = new Point(132, 63);
            this.lblMinAltituteUnit.Name = "lblMinAltituteUnit";
            this.lblMinAltituteUnit.Size = new Size(11, 12);
            this.lblMinAltituteUnit.TabIndex = 21;
            this.lblMinAltituteUnit.Text = " ";
            this.chkShowMarkerTrailAltitude.AutoSize = true;
            this.chkShowMarkerTrailAltitude.Location = new Point(140, 32);
            this.chkShowMarkerTrailAltitude.Name = "chkShowMarkerTrailAltitude";
            this.chkShowMarkerTrailAltitude.Size = new Size(84, 16);
            this.chkShowMarkerTrailAltitude.TabIndex = 20;
            this.chkShowMarkerTrailAltitude.Text = "点轨迹符号";
            this.chkShowMarkerTrailAltitude.UseVisualStyleBackColor = true;
            this.chkShowMarkerTrailAltitude.CheckedChanged += new EventHandler(this.chkShowCurrentBearing_CheckedChanged);
            this.chkShowCurrentAltitude.AutoSize = true;
            this.chkShowCurrentAltitude.Location = new Point(11, 32);
            this.chkShowCurrentAltitude.Name = "chkShowCurrentAltitude";
            this.chkShowCurrentAltitude.Size = new Size(96, 16);
            this.chkShowCurrentAltitude.TabIndex = 19;
            this.chkShowCurrentAltitude.Text = "当前位置符号";
            this.chkShowCurrentAltitude.UseVisualStyleBackColor = true;
            this.chkShowCurrentAltitude.CheckedChanged += new EventHandler(this.chkShowCurrentBearing_CheckedChanged);
            this.txtHighAltitudeSize.Location = new Point(226, 85);
            this.txtHighAltitudeSize.Name = "txtHighAltitudeSize";
            this.txtHighAltitudeSize.Size = new Size(68, 21);
            this.txtHighAltitudeSize.TabIndex = 18;
            this.txtHighAltitudeSize.Text = "25";
            this.txtHighAltitudeSize.TextChanged += new EventHandler(this.txtLowSpeedValue_TextChanged);
            this.label11.AutoSize = true;
            this.label11.Location = new Point(189, 88);
            this.label11.Name = "label11";
            this.label11.Size = new Size(29, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "大小";
            this.txtLowAltitudeSize.Location = new Point(226, 60);
            this.txtLowAltitudeSize.Name = "txtLowAltitudeSize";
            this.txtLowAltitudeSize.Size = new Size(68, 21);
            this.txtLowAltitudeSize.TabIndex = 16;
            this.txtLowAltitudeSize.Text = "5";
            this.txtLowAltitudeSize.TextChanged += new EventHandler(this.txtLowSpeedValue_TextChanged);
            this.label12.AutoSize = true;
            this.label12.Location = new Point(189, 63);
            this.label12.Name = "label12";
            this.label12.Size = new Size(29, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "大小";
            this.txtHighAltitudeValue.Location = new Point(44, 82);
            this.txtHighAltitudeValue.Name = "txtHighAltitudeValue";
            this.txtHighAltitudeValue.Size = new Size(81, 21);
            this.txtHighAltitudeValue.TabIndex = 14;
            this.txtHighAltitudeValue.Text = "5000";
            this.txtHighAltitudeValue.TextChanged += new EventHandler(this.txtLowSpeedValue_TextChanged);
            this.label9.AutoSize = true;
            this.label9.Location = new Point(9, 85);
            this.label9.Name = "label9";
            this.label9.Size = new Size(29, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "最大";
            this.txtLowAltitudeValue.Location = new Point(44, 57);
            this.txtLowAltitudeValue.Name = "txtLowAltitudeValue";
            this.txtLowAltitudeValue.Size = new Size(81, 21);
            this.txtLowAltitudeValue.TabIndex = 12;
            this.txtLowAltitudeValue.Text = "1000";
            this.txtLowAltitudeValue.TextChanged += new EventHandler(this.txtLowSpeedValue_TextChanged);
            this.label10.AutoSize = true;
            this.label10.Location = new Point(9, 60);
            this.label10.Name = "label10";
            this.label10.Size = new Size(29, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "最小";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new Size(185, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "通过以下符号大小符号化高度信息";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Name = "DisplayAdvancePage";
            base.Size = new Size(340, 383);
            base.Load += new EventHandler(this.DisplayAdvancePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.colorEdit2.Properties.EndInit();
            this.colorEdit1.Properties.EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            base.ResumeLayout(false);
        }

        void IPropertyPage.Hide()
        {
            base.Hide();
        }

       
        private IContainer components = null;
        private ColorRampComboBox cboSpeedColorRamp;
        private CheckBox chkShowCurrentAltitude;
        private CheckBox chkShowCurrentBearing;
        private CheckBox chkShowCurrentSpeed;
        private CheckBox chkShowMarkerTrailAltitude;
        private CheckBox chkShowMarkerTrailBearing;
        private CheckBox chkShowMarkerTrailSpeed;
        private ColorEdit colorEdit1;
        private ColorEdit colorEdit2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox HighSpeedValue;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label lblMaxAltituteUnit;
        private Label lblMaxSpeedUnit;
        private Label lblMinAltituteUnit;
        private Label lblMinSpeedUnit;
        private TextBox txtHighAltitudeSize;
        private TextBox txtHighAltitudeValue;
        private TextBox txtLowAltitudeSize;
        private TextBox txtLowAltitudeValue;
        private TextBox txtLowSpeedValue;
    }
}