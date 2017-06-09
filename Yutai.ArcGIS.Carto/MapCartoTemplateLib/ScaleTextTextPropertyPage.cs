﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using Yutai.ArcGIS.Common.BaseClasses;
using Yutai.ArcGIS.Common.SymbolLib;

namespace Yutai.ArcGIS.Carto.MapCartoTemplateLib
{
    public class ScaleTextTextPropertyPage : UserControl, IPropertyPage, IPropertyPageEvents
    {
        private bool bool_0 = false;
        private bool bool_1 = false;
        private ComboBoxEdit cboMapUnit;
        private ComboBoxEdit cboPageUnit;
        private Container container_0 = null;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private IMapSurroundFrame imapSurroundFrame_0 = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MapTemplateElement mapTemplateElement_0 = null;
        private RadioGroup rdoStyle;
        private string string_0 = "比例尺文本";
        private SymbolItem symbolItem1;
        private TextEdit txtMapUnitLabel;
        private TextEdit txtPageUnitLabel;

        public event OnValueChangeEventHandler OnValueChange;

        public ScaleTextTextPropertyPage()
        {
            this.InitializeComponent();
            ScaleTextEventsClass.ValueChange += new ScaleTextEventsClass.ValueChangeHandler(this.method_1);
        }

        public void Apply()
        {
            if (this.bool_1)
            {
                this.bool_1 = false;
                this.imapSurroundFrame_0.MapSurround = (ScaleTextFormatPropertyPage.m_pScaleText as IClone).Clone() as IMapSurround;
            }
        }

        public void Cancel()
        {
        }

        private void cboMapUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                ScaleTextFormatPropertyPage.m_pScaleText.MapUnits = (esriUnits) this.cboMapUnit.SelectedIndex;
                this.method_2();
            }
        }

        private void cboPageUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                if (this.cboPageUnit.SelectedIndex == 0)
                {
                    ScaleTextFormatPropertyPage.m_pScaleText.PageUnits = esriUnits.esriCentimeters;
                }
                else if (this.cboPageUnit.SelectedIndex == 1)
                {
                    ScaleTextFormatPropertyPage.m_pScaleText.PageUnits = esriUnits.esriInches;
                }
                else if (this.cboPageUnit.SelectedIndex == 2)
                {
                    ScaleTextFormatPropertyPage.m_pScaleText.PageUnits = esriUnits.esriPoints;
                }
                this.method_2();
            }
        }

        protected override void Dispose(bool bool_2)
        {
            if (bool_2 && (this.container_0 != null))
            {
                this.container_0.Dispose();
            }
            base.Dispose(bool_2);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new GroupBox();
            this.symbolItem1 = new SymbolItem();
            this.groupBox2 = new GroupBox();
            this.rdoStyle = new RadioGroup();
            this.groupBox3 = new GroupBox();
            this.txtMapUnitLabel = new TextEdit();
            this.cboMapUnit = new ComboBoxEdit();
            this.txtPageUnitLabel = new TextEdit();
            this.cboPageUnit = new ComboBoxEdit();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.rdoStyle.Properties.BeginInit();
            this.groupBox3.SuspendLayout();
            this.txtMapUnitLabel.Properties.BeginInit();
            this.cboMapUnit.Properties.BeginInit();
            this.txtPageUnitLabel.Properties.BeginInit();
            this.cboPageUnit.Properties.BeginInit();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.symbolItem1);
            this.groupBox1.Location = new Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0xf8, 0x38);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预览";
            this.symbolItem1.BackColor = SystemColors.ControlLight;
            this.symbolItem1.Dock = DockStyle.Fill;
            this.symbolItem1.Location = new Point(3, 0x11);
            this.symbolItem1.Name = "symbolItem1";
            this.symbolItem1.Size = new Size(0xf2, 0x24);
            this.symbolItem1.Symbol = null;
            this.symbolItem1.TabIndex = 2;
            this.groupBox2.Controls.Add(this.rdoStyle);
            this.groupBox2.Location = new Point(8, 0x47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0xf8, 0x48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "样式";
            this.rdoStyle.Location = new Point(8, 0x10);
            this.rdoStyle.Name = "rdoStyle";
            this.rdoStyle.Properties.BorderStyle = BorderStyles.NoBorder;
            this.rdoStyle.Properties.Items.AddRange(new RadioGroupItem[] { new RadioGroupItem(null, "绝对比例"), new RadioGroupItem(null, "相对比例") });
            this.rdoStyle.Size = new Size(0x88, 0x30);
            this.rdoStyle.TabIndex = 0;
            this.rdoStyle.SelectedIndexChanged += new EventHandler(this.rdoStyle_SelectedIndexChanged);
            this.groupBox3.Controls.Add(this.txtMapUnitLabel);
            this.groupBox3.Controls.Add(this.cboMapUnit);
            this.groupBox3.Controls.Add(this.txtPageUnitLabel);
            this.groupBox3.Controls.Add(this.cboPageUnit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new Point(8, 0x97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0xf8, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "格式";
            this.txtMapUnitLabel.EditValue = "";
            this.txtMapUnitLabel.Location = new Point(0x88, 80);
            this.txtMapUnitLabel.Name = "txtMapUnitLabel";
            this.txtMapUnitLabel.Size = new Size(80, 0x15);
            this.txtMapUnitLabel.TabIndex = 7;
            this.txtMapUnitLabel.EditValueChanged += new EventHandler(this.txtMapUnitLabel_EditValueChanged);
            this.cboMapUnit.EditValue = "";
            this.cboMapUnit.Location = new Point(0x10, 80);
            this.cboMapUnit.Name = "cboMapUnit";
            this.cboMapUnit.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboMapUnit.Properties.Items.AddRange(new object[] { "未知单位", "英寸", "点", "英尺", "码", "英里", "海里", "毫米", "厘米", "米", "公里", "十进制度", "分米" });
            this.cboMapUnit.Size = new Size(0x68, 0x15);
            this.cboMapUnit.TabIndex = 6;
            this.cboMapUnit.SelectedIndexChanged += new EventHandler(this.cboMapUnit_SelectedIndexChanged);
            this.txtPageUnitLabel.EditValue = "";
            this.txtPageUnitLabel.Location = new Point(0x88, 0x22);
            this.txtPageUnitLabel.Name = "txtPageUnitLabel";
            this.txtPageUnitLabel.Size = new Size(80, 0x15);
            this.txtPageUnitLabel.TabIndex = 5;
            this.txtPageUnitLabel.EditValueChanged += new EventHandler(this.txtPageUnitLabel_EditValueChanged);
            this.cboPageUnit.EditValue = "";
            this.cboPageUnit.Location = new Point(0x10, 0x22);
            this.cboPageUnit.Name = "cboPageUnit";
            this.cboPageUnit.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboPageUnit.Properties.Items.AddRange(new object[] { "厘米", "英寸", "点" });
            this.cboPageUnit.Size = new Size(0x60, 0x15);
            this.cboPageUnit.TabIndex = 4;
            this.cboPageUnit.SelectedIndexChanged += new EventHandler(this.cboPageUnit_SelectedIndexChanged);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x88, 0x40);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x1d, 0x11);
            this.label3.TabIndex = 3;
            this.label3.Text = "标记";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(0x10, 0x40);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x36, 0x11);
            this.label4.TabIndex = 2;
            this.label4.Text = "地图单位";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x90, 0x12);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x1d, 0x11);
            this.label2.TabIndex = 1;
            this.label2.Text = "标记";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(0x10, 0x12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x36, 0x11);
            this.label1.TabIndex = 0;
            this.label1.Text = "页面单位";
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Name = "ScaleTextTextPropertyPage";
            base.Size = new Size(280, 0x130);
            base.Load += new EventHandler(this.ScaleTextTextPropertyPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.rdoStyle.Properties.EndInit();
            this.groupBox3.ResumeLayout(false);
            this.txtMapUnitLabel.Properties.EndInit();
            this.cboMapUnit.Properties.EndInit();
            this.txtPageUnitLabel.Properties.EndInit();
            this.cboPageUnit.Properties.EndInit();
            base.ResumeLayout(false);
        }

        void IPropertyPage.Hide()
        {
            base.Hide();
        }

        private void method_0()
        {
            if (ScaleTextFormatPropertyPage.m_pScaleText != null)
            {
                this.symbolItem1.Symbol = ScaleTextFormatPropertyPage.m_pScaleText;
                this.txtMapUnitLabel.Text = ScaleTextFormatPropertyPage.m_pScaleText.MapUnitLabel;
                this.txtPageUnitLabel.Text = ScaleTextFormatPropertyPage.m_pScaleText.PageUnitLabel;
                this.cboMapUnit.SelectedIndex = (int) ScaleTextFormatPropertyPage.m_pScaleText.MapUnits;
                this.rdoStyle.SelectedIndex = (int) ScaleTextFormatPropertyPage.m_pScaleText.Style;
                esriUnits pageUnits = ScaleTextFormatPropertyPage.m_pScaleText.PageUnits;
                switch (pageUnits)
                {
                    case esriUnits.esriInches:
                        this.cboPageUnit.SelectedIndex = 1;
                        return;

                    case esriUnits.esriPoints:
                        this.cboPageUnit.SelectedIndex = 2;
                        return;
                }
                if (pageUnits == esriUnits.esriCentimeters)
                {
                    this.cboPageUnit.SelectedIndex = 0;
                }
            }
        }

        private void method_1(object object_0)
        {
            if (object_0 is ScaleTextFormatPropertyPage)
            {
                this.bool_0 = false;
                this.method_0();
                this.symbolItem1.Invalidate();
                this.bool_0 = true;
            }
        }

        private void method_2()
        {
            this.bool_1 = true;
            if (this.OnValueChange != null)
            {
                this.OnValueChange();
            }
            this.symbolItem1.Invalidate();
        }

        private void rdoStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                ScaleTextFormatPropertyPage.m_pScaleText.Style = (esriScaleTextStyleEnum) this.rdoStyle.SelectedIndex;
                this.method_2();
            }
        }

        public void ResetControl()
        {
            this.bool_0 = false;
            this.method_0();
            this.bool_0 = true;
        }

        private void ScaleTextTextPropertyPage_Load(object sender, EventArgs e)
        {
            this.method_0();
            this.bool_0 = true;
        }

        public void SetObjects(object object_0)
        {
            this.mapTemplateElement_0 = object_0 as MapTemplateElement;
            this.imapSurroundFrame_0 = this.mapTemplateElement_0.Element as IMapSurroundFrame;
            if ((this.imapSurroundFrame_0 != null) && (ScaleTextFormatPropertyPage.m_pScaleText == null))
            {
                ScaleTextFormatPropertyPage.m_pScaleText = (this.imapSurroundFrame_0.MapSurround as IClone).Clone() as IScaleText;
            }
        }

        private void txtMapUnitLabel_EditValueChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                ScaleTextFormatPropertyPage.m_pScaleText.MapUnitLabel = this.txtMapUnitLabel.Text;
                this.method_2();
            }
        }

        private void txtPageUnitLabel_EditValueChanged(object sender, EventArgs e)
        {
            if (this.bool_0)
            {
                ScaleTextFormatPropertyPage.m_pScaleText.PageUnitLabel = this.txtPageUnitLabel.Text;
                this.method_2();
            }
        }

        public bool IsPageDirty
        {
            get
            {
                return this.bool_1;
            }
        }

        int IPropertyPage.Height
        {
            get
            {
                return base.Height;
            }
        }

        int IPropertyPage.Width
        {
            get
            {
                return base.Width;
            }
        }

        public string Title
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }
    }
}

