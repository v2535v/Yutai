﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Common.Wrapper;

namespace Yutai.ArcGIS.Catalog.Geodatabase.UI
{
    public class frmAddRuleByClass : Form
    {
        private bool bool_0;
        private Button btnCancel;
        private Button btnOK;
        private CheckedListBox checkedListBox1;
        private CheckEdit chkShowError;
        private System.Windows.Forms.ComboBox comboRule;
        private esriTopologyRuleType[] esriTopologyRuleType_0 = new esriTopologyRuleType[] { esriTopologyRuleType.esriTRTLineNoOverlap, esriTopologyRuleType.esriTRTLineNoIntersection, esriTopologyRuleType.esriTRTLineNoDangles, esriTopologyRuleType.esriTRTLineNoPseudos, esriTopologyRuleType.esriTRTLineNoSelfOverlap, esriTopologyRuleType.esriTRTLineNoSelfIntersect, esriTopologyRuleType.esriTRTLineNoMultipart, esriTopologyRuleType.esriTRTLineNoIntersectOrInteriorTouch, esriTopologyRuleType.esriTRTAreaNoOverlap, esriTopologyRuleType.esriTRTAreaNoGaps };
        private GroupBox groupBox1;
        private IArray iarray_0;
        private IContainer icontainer_0;
        private ImageComboBoxEdit imageComboBoxEdit1;
        private ImageList imageList_0;
        private int int_0;
        private ITopologyRule[] itopologyRule_0 = null;
        private Label label1;
        private Label label2;
        private Label lblTopoInfo1;
        private Label lblTopoInfo2;
        private string[] string_0 = new string[] { "线不能重叠", "线不能相交", "线不能有悬挂点", "线不能有伪节点", "线不能自重叠", "线不能自相交", "线必须为单部分", "线不能相交或内部相接", "面不能重叠", "面不能有缝隙" };
        private string[] string_1 = new string[] { 
            "同一层中线要素不能与其他线重叠。", "任何重叠的线段被视为错误。", "同一线层中的线不能与其他线相交或重叠", "任何重叠的线段或相交点都被视为错误", "一条线必须与同层中其他线的终点相接。", "任何不与其他线相接的线的终点被视为错误。", "一条线必须与同层中多于一条的线在终点处相接。", "任何只有两条线相接的终点被视为错误", "一个层中的线要素不允许自重叠。", "任何自重叠的线段被视为错误。", "一个层中的要素不允许自相交或自重叠。", "任何自重叠的线段或自相交的点别视为错误。", "一个层中的线要素不允许超过一个部分。", "任何超过一个部分的线要素被视为错误。", "同一层的线必须在终点处与另外的线相接。", "任何重叠的线或相交的点被视为错误。", 
            "同一层内面与面不能重叠。", "任何要素重叠的区域被视为错误", "同一层的面之间不能存在缝隙", "缝隙的边界被视为错误。"
         };

        public frmAddRuleByClass()
        {
            this.InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count > 0)
            {
                this.itopologyRule_0 = new ITopologyRule[this.checkedListBox1.CheckedItems.Count];
                for (int i = 0; i < this.checkedListBox1.CheckedItems.Count; i++)
                {
                    ObjectWrap wrap = this.checkedListBox1.CheckedItems[i] as ObjectWrap;
                    this.itopologyRule_0[i] = new TopologyRuleClass { OriginClassID = ((IFeatureClass) wrap.Object).ObjectClassID, AllOriginSubtypes = true, TopologyRuleType = this.esriTopologyRuleType_0[this.comboRule.SelectedIndex], Name = this.string_0[this.comboRule.SelectedIndex] };
                }
            }
            base.Close();
        }

        private void chkShowError_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkShowError.Checked)
            {
                this.imageComboBoxEdit1.SelectedIndex--;
            }
            else
            {
                this.imageComboBoxEdit1.SelectedIndex++;
            }
        }

        private void comboRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Clear();
            if (this.comboRule.SelectedIndex != -1)
            {
                int num;
                IFeatureClass class2;
                if (this.comboRule.SelectedIndex < 8)
                {
                    for (num = 0; num < this.iarray_0.Count; num++)
                    {
                        class2 = (IFeatureClass) this.iarray_0.get_Element(num);
                        if (class2.ShapeType == esriGeometryType.esriGeometryPolyline)
                        {
                            this.checkedListBox1.Items.Add(new ObjectWrap(class2));
                        }
                    }
                }
                else
                {
                    for (num = 0; num < this.iarray_0.Count; num++)
                    {
                        class2 = (IFeatureClass) this.iarray_0.get_Element(num);
                        if (class2.ShapeType == esriGeometryType.esriGeometryPolygon)
                        {
                            this.checkedListBox1.Items.Add(new ObjectWrap(class2));
                        }
                    }
                }
                this.lblTopoInfo1.Text = this.string_1[2 * this.comboRule.SelectedIndex];
                this.lblTopoInfo2.Text = this.string_1[(2 * this.comboRule.SelectedIndex) + 1];
                if (this.chkShowError.Checked)
                {
                    this.imageComboBoxEdit1.SelectedIndex = 2 * this.comboRule.SelectedIndex;
                }
                else
                {
                    this.imageComboBoxEdit1.SelectedIndex = (2 * this.comboRule.SelectedIndex) + 1;
                }
            }
        }

        protected override void Dispose(bool bool_1)
        {
            if (bool_1 && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(bool_1);
        }

        private void frmAddRuleByClass_Load(object sender, EventArgs e)
        {
            foreach (string str in this.string_0)
            {
                this.comboRule.Items.Add(str);
            }
            this.comboRule.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRuleByClass));
            this.label1 = new Label();
            this.label2 = new Label();
            this.comboRule = new System.Windows.Forms.ComboBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.imageList_0 = new ImageList(this.icontainer_0);
            this.groupBox1 = new GroupBox();
            this.lblTopoInfo2 = new Label();
            this.lblTopoInfo1 = new Label();
            this.chkShowError = new CheckEdit();
            this.imageComboBoxEdit1 = new ImageComboBoxEdit();
            this.checkedListBox1 = new CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.chkShowError.Properties.BeginInit();
            this.imageComboBoxEdit1.Properties.BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0x3e);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4d, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要素类的要素";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x1d, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "规则";
            this.comboRule.Location = new System.Drawing.Point(1, 0x20);
            this.comboRule.Name = "comboRule";
            this.comboRule.Size = new Size(0xc0, 20);
            this.comboRule.TabIndex = 3;
            this.comboRule.SelectedIndexChanged += new EventHandler(this.comboRule_SelectedIndexChanged);
            this.btnOK.DialogResult = DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(0x150, 0xc0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new Size(0x38, 0x18);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new EventHandler(this.btnOK_Click);
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(0x198, 0xc0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(0x40, 0x18);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.imageList_0.ImageStream = (ImageListStreamer) resources.GetObject("imageList1.ImageStream");
            this.imageList_0.TransparentColor = Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "");
            this.imageList_0.Images.SetKeyName(1, "");
            this.imageList_0.Images.SetKeyName(2, "");
            this.imageList_0.Images.SetKeyName(3, "");
            this.imageList_0.Images.SetKeyName(4, "");
            this.imageList_0.Images.SetKeyName(5, "");
            this.imageList_0.Images.SetKeyName(6, "");
            this.imageList_0.Images.SetKeyName(7, "");
            this.imageList_0.Images.SetKeyName(8, "");
            this.imageList_0.Images.SetKeyName(9, "");
            this.imageList_0.Images.SetKeyName(10, "");
            this.imageList_0.Images.SetKeyName(11, "");
            this.imageList_0.Images.SetKeyName(12, "");
            this.imageList_0.Images.SetKeyName(13, "");
            this.imageList_0.Images.SetKeyName(14, "");
            this.imageList_0.Images.SetKeyName(15, "");
            this.imageList_0.Images.SetKeyName(0x10, "");
            this.imageList_0.Images.SetKeyName(0x11, "");
            this.imageList_0.Images.SetKeyName(0x12, "");
            this.imageList_0.Images.SetKeyName(0x13, "");
            this.groupBox1.Controls.Add(this.lblTopoInfo2);
            this.groupBox1.Controls.Add(this.lblTopoInfo1);
            this.groupBox1.Controls.Add(this.chkShowError);
            this.groupBox1.Controls.Add(this.imageComboBoxEdit1);
            this.groupBox1.Location = new System.Drawing.Point(0xd0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x110, 0xb0);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "规则描述";
            this.lblTopoInfo2.Location = new System.Drawing.Point(0x68, 0x68);
            this.lblTopoInfo2.Name = "lblTopoInfo2";
            this.lblTopoInfo2.Size = new Size(160, 0x30);
            this.lblTopoInfo2.TabIndex = 13;
            this.lblTopoInfo1.Location = new System.Drawing.Point(0x68, 0x20);
            this.lblTopoInfo1.Name = "lblTopoInfo1";
            this.lblTopoInfo1.Size = new Size(160, 0x30);
            this.lblTopoInfo1.TabIndex = 12;
            this.chkShowError.EditValue = true;
            this.chkShowError.Location = new System.Drawing.Point(8, 0x98);
            this.chkShowError.Name = "chkShowError";
            this.chkShowError.Properties.Caption = "显示错误";
            this.chkShowError.Size = new Size(0x4b, 0x13);
            this.chkShowError.TabIndex = 11;
            this.chkShowError.CheckedChanged += new EventHandler(this.chkShowError_CheckedChanged);
            this.imageComboBoxEdit1.EditValue = 0;
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(9, 0x18);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.imageComboBoxEdit1.Properties.Items.AddRange(new ImageComboBoxItem[] { 
                new ImageComboBoxItem("", 0, 0), new ImageComboBoxItem("", 1, 1), new ImageComboBoxItem("", 2, 2), new ImageComboBoxItem("", 3, 3), new ImageComboBoxItem("", 4, 4), new ImageComboBoxItem("", 5, 5), new ImageComboBoxItem("", 6, 6), new ImageComboBoxItem("", 7, 7), new ImageComboBoxItem("", 8, 8), new ImageComboBoxItem("", 9, 9), new ImageComboBoxItem("", 10, 10), new ImageComboBoxItem("", 11, 11), new ImageComboBoxItem("", 12, 12), new ImageComboBoxItem("", 13, 13), new ImageComboBoxItem("", 14, 14), new ImageComboBoxItem("", 15, 15), 
                new ImageComboBoxItem("", 0x10, 0x10), new ImageComboBoxItem("", 0x11, 0x11), new ImageComboBoxItem("", 0x12, 0x12), new ImageComboBoxItem("", 0x13, 0x13), new ImageComboBoxItem("", 20, 20), new ImageComboBoxItem("", 0x15, 0x15), new ImageComboBoxItem("", 0x16, 0x16), new ImageComboBoxItem("", 0x17, 0x17), new ImageComboBoxItem("", 0x18, 0x18), new ImageComboBoxItem("", 0x19, 0x19), new ImageComboBoxItem("", 0x1a, 0x1a), new ImageComboBoxItem("", 0x1b, 0x1b), new ImageComboBoxItem("", 0x1c, 0x1c), new ImageComboBoxItem("", 0x1d, 0x1d), new ImageComboBoxItem("", 30, 30), new ImageComboBoxItem("", 0x1f, 0x1f), 
                new ImageComboBoxItem("", 0x20, 0x20), new ImageComboBoxItem("", 0x21, 0x21), new ImageComboBoxItem("", 0x22, 0x22), new ImageComboBoxItem("", 0x23, 0x23), new ImageComboBoxItem("", 0x24, 0x24), new ImageComboBoxItem("", 0x25, 0x25), new ImageComboBoxItem("", 0x26, 0x26), new ImageComboBoxItem("", 0x27, 0x27), new ImageComboBoxItem("", 40, 40), new ImageComboBoxItem("", 0x29, 0x29), new ImageComboBoxItem("", 0x2a, 0x2a), new ImageComboBoxItem("", 0x2b, 0x2b), new ImageComboBoxItem("", 0x2c, 0x2c), new ImageComboBoxItem("", 0x2d, 0x2d), new ImageComboBoxItem("", 0x2e, 0x2e), new ImageComboBoxItem("", 0x2f, 0x2f), 
                new ImageComboBoxItem("", 0x30, 0x30), new ImageComboBoxItem("", 0x31, 0x31)
             });
            this.imageComboBoxEdit1.Properties.LargeImages = this.imageList_0;
            this.imageComboBoxEdit1.Properties.ReadOnly = true;
            this.imageComboBoxEdit1.Properties.ShowDropDown = ShowDropDown.Never;
            this.imageComboBoxEdit1.Properties.SmallImages = this.imageList_0;
            this.imageComboBoxEdit1.Size = new Size(0x58, 0x7a);
            this.imageComboBoxEdit1.TabIndex = 9;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 0x4d);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(0xbb, 0x54);
            this.checkedListBox1.TabIndex = 10;
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x1e8, 0xe4);
            base.Controls.Add(this.checkedListBox1);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.btnOK);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.comboRule);
            
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmAddRuleByClass";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "添加规则";
            base.Load += new EventHandler(this.frmAddRuleByClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.chkShowError.Properties.EndInit();
            this.imageComboBoxEdit1.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public bool bVaildRule
        {
            get
            {
                return this.bool_0;
            }
        }

        public IArray OriginClassArray
        {
            set
            {
                this.iarray_0 = value;
            }
        }

        public ITopologyRule[] TopologyRules
        {
            get
            {
                return this.itopologyRule_0;
            }
        }
    }
}

