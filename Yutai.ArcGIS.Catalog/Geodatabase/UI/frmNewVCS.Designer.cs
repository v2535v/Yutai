﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Common.ControlExtend;

namespace Yutai.ArcGIS.Catalog.Geodatabase.UI
{
    partial class frmNewVCS
    {
        protected override void Dispose(bool bool_2)
        {
            if (bool_2 && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(bool_2);
        }

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewVCS));
            this.groupBox4 = new GroupBox();
            this.cboLineUnitName = new ComboBoxEdit();
            this.txtValue = new TextEdit();
            this.label6 = new Label();
            this.label5 = new Label();
            this.groupBox1 = new GroupBox();
            this.groupBoxSpere = new GroupBox();
            this.cboSpheres = new ComboBoxEdit();
            this.txtFlattening = new TextEdit();
            this.txtMiniorAxis = new TextEdit();
            this.txtMajorAxis = new TextEdit();
            this.rdoFlattening = new RadioButton();
            this.rdoMiniorAxis = new RadioButton();
            this.label4 = new Label();
            this.label7 = new Label();
            this.cboDatumName = new ComboBoxEdit();
            this.label3 = new Label();
            this.cboProjectName = new ComboBoxEdit();
            this.label2 = new Label();
            this.rdoVCSBase = new RadioGroup();
            this.paramlistView = new EditListView();
            this.lvcolumnHeader_0 = new LVColumnHeader();
            this.lvcolumnHeader_1 = new LVColumnHeader();
            this.label1 = new Label();
            this.textEditName = new TextEdit();
            this.groupBox3 = new GroupBox();
            this.btnCancel = new SimpleButton();
            this.btnOK = new SimpleButton();
            this.groupBox4.SuspendLayout();
            this.cboLineUnitName.Properties.BeginInit();
            this.txtValue.Properties.BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxSpere.SuspendLayout();
            this.cboSpheres.Properties.BeginInit();
            this.txtFlattening.Properties.BeginInit();
            this.txtMiniorAxis.Properties.BeginInit();
            this.txtMajorAxis.Properties.BeginInit();
            this.cboDatumName.Properties.BeginInit();
            this.cboProjectName.Properties.BeginInit();
            this.rdoVCSBase.Properties.BeginInit();
            this.textEditName.Properties.BeginInit();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            this.groupBox4.Controls.Add(this.cboLineUnitName);
            this.groupBox4.Controls.Add(this.txtValue);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(18, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(296, 88);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "线性单位";
            this.cboLineUnitName.EditValue = "";
            this.cboLineUnitName.Location = new System.Drawing.Point(80, 24);
            this.cboLineUnitName.Name = "cboLineUnitName";
            this.cboLineUnitName.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboLineUnitName.Properties.Items.AddRange(new object[] { "自定义", "Meter", "Kilometer" });
            this.cboLineUnitName.Size = new Size(192, 21);
            this.cboLineUnitName.TabIndex = 10;
            this.cboLineUnitName.SelectedIndexChanged += new EventHandler(this.cboLineUnitName_SelectedIndexChanged);
            this.txtValue.EditValue = "1";
            this.txtValue.Location = new System.Drawing.Point(80, 56);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new Size(192, 21);
            this.txtValue.TabIndex = 9;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 56);
            this.label6.Name = "label6";
            this.label6.Size = new Size(59, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "单位(米):";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "名称:";
            this.groupBox1.Controls.Add(this.groupBoxSpere);
            this.groupBox1.Controls.Add(this.cboDatumName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboProjectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoVCSBase);
            this.groupBox1.Location = new System.Drawing.Point(18, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(296, 292);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据框架";
            this.groupBoxSpere.Controls.Add(this.cboSpheres);
            this.groupBoxSpere.Controls.Add(this.txtFlattening);
            this.groupBoxSpere.Controls.Add(this.txtMiniorAxis);
            this.groupBoxSpere.Controls.Add(this.txtMajorAxis);
            this.groupBoxSpere.Controls.Add(this.rdoFlattening);
            this.groupBoxSpere.Controls.Add(this.rdoMiniorAxis);
            this.groupBoxSpere.Controls.Add(this.label4);
            this.groupBoxSpere.Controls.Add(this.label7);
            this.groupBoxSpere.Enabled = false;
            this.groupBoxSpere.Location = new System.Drawing.Point(16, 128);
            this.groupBoxSpere.Name = "groupBoxSpere";
            this.groupBoxSpere.Size = new Size(264, 152);
            this.groupBoxSpere.TabIndex = 9;
            this.groupBoxSpere.TabStop = false;
            this.groupBoxSpere.Text = "椭球参数";
            this.cboSpheres.EditValue = "";
            this.cboSpheres.Location = new System.Drawing.Point(80, 24);
            this.cboSpheres.Name = "cboSpheres";
            this.cboSpheres.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboSpheres.Properties.Items.AddRange(new object[] { "自定义", "Krasovsky_1940", "WGS_1984", "Xian_1980" });
            this.cboSpheres.Size = new Size(160, 21);
            this.cboSpheres.TabIndex = 9;
            this.cboSpheres.SelectedIndexChanged += new EventHandler(this.cboSpheres_SelectedIndexChanged);
            this.txtFlattening.EditValue = "1";
            this.txtFlattening.Location = new System.Drawing.Point(80, 120);
            this.txtFlattening.Name = "txtFlattening";
            this.txtFlattening.Size = new Size(160, 21);
            this.txtFlattening.TabIndex = 8;
            this.txtMiniorAxis.EditValue = "1";
            this.txtMiniorAxis.Location = new System.Drawing.Point(80, 88);
            this.txtMiniorAxis.Name = "txtMiniorAxis";
            this.txtMiniorAxis.Size = new Size(160, 21);
            this.txtMiniorAxis.TabIndex = 7;
            this.txtMajorAxis.EditValue = "1";
            this.txtMajorAxis.Location = new System.Drawing.Point(80, 56);
            this.txtMajorAxis.Name = "txtMajorAxis";
            this.txtMajorAxis.Size = new Size(160, 21);
            this.txtMajorAxis.TabIndex = 6;
            this.rdoFlattening.Location = new System.Drawing.Point(8, 118);
            this.rdoFlattening.Name = "rdoFlattening";
            this.rdoFlattening.Size = new Size(72, 24);
            this.rdoFlattening.TabIndex = 4;
            this.rdoFlattening.Text = "扁率倒数";
            this.rdoFlattening.Click += new EventHandler(this.rdoFlattening_Click);
            this.rdoMiniorAxis.Location = new System.Drawing.Point(8, 83);
            this.rdoMiniorAxis.Name = "rdoMiniorAxis";
            this.rdoMiniorAxis.Size = new Size(64, 24);
            this.rdoMiniorAxis.TabIndex = 3;
            this.rdoMiniorAxis.Text = "短半轴";
            this.rdoMiniorAxis.Click += new EventHandler(this.rdoMiniorAxis_Click);
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Name = "label4";
            this.label4.Size = new Size(47, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "长半轴:";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new Size(35, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "名称:";
            this.cboDatumName.EditValue = "";
            this.cboDatumName.Enabled = false;
            this.cboDatumName.Location = new System.Drawing.Point(72, 98);
            this.cboDatumName.Name = "cboDatumName";
            this.cboDatumName.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboDatumName.Properties.Items.AddRange(new object[] { "自定义", "D_Beijing_1954", "D_Krasovsky_1940", "D_WGS_1984", "D_Xian_1980" });
            this.cboDatumName.Size = new Size(200, 21);
            this.cboDatumName.TabIndex = 8;
            this.cboDatumName.SelectedIndexChanged += new EventHandler(this.cboDatumName_SelectedIndexChanged);
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "名称:";
            this.cboProjectName.EditValue = "";
            this.cboProjectName.Location = new System.Drawing.Point(72, 45);
            this.cboProjectName.Name = "cboProjectName";
            this.cboProjectName.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cboProjectName.Properties.Items.AddRange(new object[] { "Bandar_Abbas", "Caspian", "Fahud_Height_Datum_1993", "Fao", "Ha_Tien_1960", "Hon_Dau_1992", "Hong_Kong_Chart_Datum", "Hong_Kong_Principal_Datum", "Japanese_Standard_Levelling_Datum_1949", "KOC_Construction_Datum", "KOC_Well_Datum", "Kuwait_PWD", "PDO_Height_Datum_1993", "Yellow_Sea_1956", "Yellow_Sea_1985" });
            this.cboProjectName.Size = new Size(200, 21);
            this.cboProjectName.TabIndex = 6;
            this.cboProjectName.SelectedIndexChanged += new EventHandler(this.cboProjectName_SelectedIndexChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "名称:";
            this.rdoVCSBase.Location = new System.Drawing.Point(6, -3);
            this.rdoVCSBase.Name = "rdoVCSBase";
            this.rdoVCSBase.Properties.Appearance.BackColor = Color.Transparent;
            this.rdoVCSBase.Properties.Appearance.Options.UseBackColor = true;
            this.rdoVCSBase.Properties.Items.AddRange(new RadioGroupItem[] { new RadioGroupItem(null, "基于大地水准面"), new RadioGroupItem(null, "基于椭球表面") });
            this.rdoVCSBase.Size = new Size(206, 118);
            this.rdoVCSBase.TabIndex = 4;
            this.rdoVCSBase.SelectedIndexChanged += new EventHandler(this.rdoVCSBase_SelectedIndexChanged);
            this.paramlistView.Columns.AddRange(new ColumnHeader[] { this.lvcolumnHeader_0, this.lvcolumnHeader_1 });
            this.paramlistView.ComboBoxBgColor = Color.LightBlue;
            this.paramlistView.ComboBoxFont = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.paramlistView.EditBgColor = Color.LightBlue;
            this.paramlistView.EditFont = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
            this.paramlistView.FullRowSelect = true;
            this.paramlistView.GridLines = true;
            this.paramlistView.Location = new System.Drawing.Point(18, 21);
            this.paramlistView.LockRowCount = 0;
            this.paramlistView.Name = "paramlistView";
            this.paramlistView.Size = new Size(272, 85);
            this.paramlistView.TabIndex = 2;
            this.paramlistView.UseCompatibleStateImageBehavior = false;
            this.paramlistView.View = View.Details;
            this.paramlistView.SelectedIndexChanged += new EventHandler(this.paramlistView_SelectedIndexChanged);
            this.paramlistView.ValueChanged += new Common.ControlExtend.ValueChangedHandler(this.method_2);
            this.lvcolumnHeader_0.ColumnStyle = ListViewColumnStyle.ReadOnly;
            this.lvcolumnHeader_0.Text = "参数";
            this.lvcolumnHeader_0.Width = 144;
            this.lvcolumnHeader_1.ColumnStyle = ListViewColumnStyle.EditBox;
            this.lvcolumnHeader_1.Text = "值";
            this.lvcolumnHeader_1.Width = 122;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "名称:";
            this.textEditName.EditValue = "";
            this.textEditName.Location = new System.Drawing.Point(58, 8);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new Size(240, 21);
            this.textEditName.TabIndex = 9;
            this.groupBox3.Controls.Add(this.paramlistView);
            this.groupBox3.Location = new System.Drawing.Point(18, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(296, 116);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数";
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 565);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(48, 24);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnOK.Location = new System.Drawing.Point(217, 565);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new Size(48, 24);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new EventHandler(this.btnOK_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(349, 601);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btnOK);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.textEditName);
            base.Controls.Add(this.groupBox3);
            
            base.Name = "frmNewVCS";
            this.Text = "New VCS";
            base.Load += new EventHandler(this.frmNewVCS_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.cboLineUnitName.Properties.EndInit();
            this.txtValue.Properties.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSpere.ResumeLayout(false);
            this.groupBoxSpere.PerformLayout();
            this.cboSpheres.Properties.EndInit();
            this.txtFlattening.Properties.EndInit();
            this.txtMiniorAxis.Properties.EndInit();
            this.txtMajorAxis.Properties.EndInit();
            this.cboDatumName.Properties.EndInit();
            this.cboProjectName.Properties.EndInit();
            this.rdoVCSBase.Properties.EndInit();
            this.textEditName.Properties.EndInit();
            this.groupBox3.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

       
        private bool bool_1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private ComboBoxEdit cboDatumName;
        private ComboBoxEdit cboLineUnitName;
        private ComboBoxEdit cboProjectName;
        private ComboBoxEdit cboSpheres;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBoxSpere;
        private IHVDatum ihvdatum_0;
        private ISpheroid ispheroid_0;
        private IUnit iunit_0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private LVColumnHeader lvcolumnHeader_0;
        private LVColumnHeader lvcolumnHeader_1;
        private EditListView paramlistView;
        private RadioButton rdoFlattening;
        private RadioButton rdoMiniorAxis;
        private RadioGroup rdoVCSBase;
        private TextEdit textEditName;
        private TextEdit txtFlattening;
        private TextEdit txtMajorAxis;
        private TextEdit txtMiniorAxis;
        private TextEdit txtValue;
    }
}