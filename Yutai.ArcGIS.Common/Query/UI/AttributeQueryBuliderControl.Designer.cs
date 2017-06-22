﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using Yutai.ArcGIS.Common.Helpers;

namespace Yutai.ArcGIS.Common.Query.UI
{
    partial class AttributeQueryBuliderControl
    {
        protected override void Dispose(bool bool_1)
        {
            if (bool_1 && (this.container_0 != null))
            {
                this.container_0.Dispose();
            }
            base.Dispose(bool_1);
        }

       
        private void InitializeComponent()
        {
            this.label2 = new Label();
            this.btnMatchString = new SimpleButton();
            this.btnIs = new SimpleButton();
            this.btnNot = new SimpleButton();
            this.btnBracket = new SimpleButton();
            this.btnMatchOneChar = new SimpleButton();
            this.btnOr = new SimpleButton();
            this.btnLittleEqual = new SimpleButton();
            this.btnLittle = new SimpleButton();
            this.btnAnd = new SimpleButton();
            this.btnLike = new SimpleButton();
            this.btnGreat = new SimpleButton();
            this.btnNotEqual = new SimpleButton();
            this.btnGreatEqual = new SimpleButton();
            this.btnEqual = new SimpleButton();
            this.btnClose = new SimpleButton();
            this.btnApply = new SimpleButton();
            this.memEditWhereCaluse = new MemoEdit();
            this.textEdit1 = new TextEdit();
            this.Fieldlist = new ListBoxControl();
            this.label4 = new Label();
            this.UniqueValuelist = new ListBoxControl();
            this.btnGetUniqueValue = new SimpleButton();
            this.btnClear = new SimpleButton();
            this.btnValidate = new SimpleButton();
            this.memEditWhereCaluse.Properties.BeginInit();
            this.textEdit1.Properties.BeginInit();
            ((ISupportInitialize) this.Fieldlist).BeginInit();
            ((ISupportInitialize) this.UniqueValuelist).BeginInit();
            base.SuspendLayout();
            this.label2.Location = new Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new Size(48, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "字段";
            this.btnMatchString.Location = new Point(144, 120);
            this.btnMatchString.Name = "btnMatchString";
            this.btnMatchString.Size = new Size(16, 24);
            this.btnMatchString.TabIndex = 42;
            this.btnMatchString.Text = "%";
            this.btnMatchString.Click += new EventHandler(this.btnMatchString_Click);
            this.btnIs.Location = new Point(128, 152);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new Size(32, 24);
            this.btnIs.TabIndex = 41;
            this.btnIs.Text = "&Is";
            this.btnIs.Click += new EventHandler(this.btnIs_Click);
            this.btnNot.Location = new Point(208, 120);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new Size(32, 24);
            this.btnNot.TabIndex = 40;
            this.btnNot.Text = "&Not";
            this.btnNot.Click += new EventHandler(this.btnNot_Click);
            this.btnBracket.Location = new Point(168, 120);
            this.btnBracket.Name = "btnBracket";
            this.btnBracket.Size = new Size(32, 24);
            this.btnBracket.TabIndex = 39;
            this.btnBracket.Text = "()";
            this.btnBracket.Click += new EventHandler(this.btnBracket_Click);
            this.btnMatchOneChar.Location = new Point(128, 120);
            this.btnMatchOneChar.Name = "btnMatchOneChar";
            this.btnMatchOneChar.Size = new Size(16, 24);
            this.btnMatchOneChar.TabIndex = 38;
            this.btnMatchOneChar.Text = "_";
            this.btnMatchOneChar.Click += new EventHandler(this.btnMatchOneChar_Click);
            this.btnOr.Location = new Point(208, 88);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new Size(32, 24);
            this.btnOr.TabIndex = 37;
            this.btnOr.Text = "&Or";
            this.btnOr.Click += new EventHandler(this.btnOr_Click);
            this.btnLittleEqual.Location = new Point(168, 88);
            this.btnLittleEqual.Name = "btnLittleEqual";
            this.btnLittleEqual.Size = new Size(32, 24);
            this.btnLittleEqual.TabIndex = 36;
            this.btnLittleEqual.Text = "<=";
            this.btnLittleEqual.Click += new EventHandler(this.btnLittleEqual_Click);
            this.btnLittle.Location = new Point(128, 88);
            this.btnLittle.Name = "btnLittle";
            this.btnLittle.Size = new Size(32, 24);
            this.btnLittle.TabIndex = 35;
            this.btnLittle.Text = "<";
            this.btnLittle.Click += new EventHandler(this.btnLittle_Click);
            this.btnAnd.Location = new Point(208, 56);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new Size(32, 24);
            this.btnAnd.TabIndex = 34;
            this.btnAnd.Text = "&And";
            this.btnAnd.Click += new EventHandler(this.btnAnd_Click);
            this.btnLike.Location = new Point(208, 24);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new Size(32, 24);
            this.btnLike.TabIndex = 33;
            this.btnLike.Text = "Li&ke";
            this.btnLike.Click += new EventHandler(this.btnLike_Click);
            this.btnGreat.Location = new Point(128, 56);
            this.btnGreat.Name = "btnGreat";
            this.btnGreat.Size = new Size(32, 24);
            this.btnGreat.TabIndex = 32;
            this.btnGreat.Text = ">";
            this.btnGreat.Click += new EventHandler(this.btnGreat_Click);
            this.btnNotEqual.Location = new Point(168, 24);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new Size(32, 24);
            this.btnNotEqual.TabIndex = 31;
            this.btnNotEqual.Text = "<>";
            this.btnNotEqual.Click += new EventHandler(this.btnNotEqual_Click);
            this.btnGreatEqual.Location = new Point(168, 56);
            this.btnGreatEqual.Name = "btnGreatEqual";
            this.btnGreatEqual.Size = new Size(32, 24);
            this.btnGreatEqual.TabIndex = 30;
            this.btnGreatEqual.Text = ">=";
            this.btnGreatEqual.Click += new EventHandler(this.btnGreatEqual_Click);
            this.btnEqual.Location = new Point(128, 24);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new Size(32, 24);
            this.btnEqual.TabIndex = 29;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new EventHandler(this.btnEqual_Click);
            this.btnClose.Location = new Point(200, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(56, 24);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "关闭";
            this.btnClose.Visible = false;
            this.btnApply.Location = new Point(136, 176);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new Size(56, 24);
            this.btnApply.TabIndex = 27;
            this.btnApply.Text = "应用";
            this.btnApply.Visible = false;
            this.memEditWhereCaluse.EditValue = "";
            this.memEditWhereCaluse.Location = new Point(16, 232);
            this.memEditWhereCaluse.Name = "memEditWhereCaluse";
            this.memEditWhereCaluse.Size = new Size(352, 104);
            this.memEditWhereCaluse.TabIndex = 26;
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new Point(24, 200);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = SystemColors.InactiveBorder;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new Size(344, 19);
            this.textEdit1.TabIndex = 25;
            this.Fieldlist.ItemHeight = 17;
            this.Fieldlist.Location = new Point(16, 24);
            this.Fieldlist.Name = "Fieldlist";
            this.Fieldlist.Size = new Size(104, 160);
            this.Fieldlist.TabIndex = 24;
            this.Fieldlist.DoubleClick += new EventHandler(this.Fieldlist_DoubleClick);
            this.Fieldlist.SelectedIndexChanged += new EventHandler(this.Fieldlist_SelectedIndexChanged);
            this.label4.Location = new Point(248, 8);
            this.label4.Name = "label4";
            this.label4.Size = new Size(56, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "唯一值";
            this.UniqueValuelist.Enabled = false;
            this.UniqueValuelist.ItemHeight = 17;
            this.UniqueValuelist.Location = new Point(248, 24);
            this.UniqueValuelist.Name = "UniqueValuelist";
            this.UniqueValuelist.Size = new Size(120, 136);
            this.UniqueValuelist.TabIndex = 47;
            this.UniqueValuelist.DoubleClick += new EventHandler(this.UniqueValuelist_DoubleClick);
            this.btnGetUniqueValue.Location = new Point(248, 168);
            this.btnGetUniqueValue.Name = "btnGetUniqueValue";
            this.btnGetUniqueValue.Size = new Size(120, 24);
            this.btnGetUniqueValue.TabIndex = 49;
            this.btnGetUniqueValue.Text = "获取唯一值";
            this.btnGetUniqueValue.Click += new EventHandler(this.btnGetUniqueValue_Click);
            this.btnClear.Location = new Point(8, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(56, 24);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "清除";
            this.btnClear.Visible = false;
            this.btnValidate.Location = new Point(72, 176);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new Size(56, 24);
            this.btnValidate.TabIndex = 51;
            this.btnValidate.Text = "验证";
            this.btnValidate.Visible = false;
            base.Controls.Add(this.btnValidate);
            base.Controls.Add(this.btnClear);
            base.Controls.Add(this.btnGetUniqueValue);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.UniqueValuelist);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.btnMatchString);
            base.Controls.Add(this.btnIs);
            base.Controls.Add(this.btnNot);
            base.Controls.Add(this.btnBracket);
            base.Controls.Add(this.btnMatchOneChar);
            base.Controls.Add(this.btnOr);
            base.Controls.Add(this.btnLittleEqual);
            base.Controls.Add(this.btnLittle);
            base.Controls.Add(this.btnAnd);
            base.Controls.Add(this.btnLike);
            base.Controls.Add(this.btnGreat);
            base.Controls.Add(this.btnNotEqual);
            base.Controls.Add(this.btnGreatEqual);
            base.Controls.Add(this.btnEqual);
            base.Controls.Add(this.btnClose);
            base.Controls.Add(this.btnApply);
            base.Controls.Add(this.memEditWhereCaluse);
            base.Controls.Add(this.textEdit1);
            base.Controls.Add(this.Fieldlist);
            base.Name = "AttributeQueryBuliderControl";
            base.Size = new Size(384, 352);
            base.Load += new EventHandler(this.AttributeQueryBuliderControl_Load);
            this.memEditWhereCaluse.Properties.EndInit();
            this.textEdit1.Properties.EndInit();
            ((ISupportInitialize) this.Fieldlist).EndInit();
            ((ISupportInitialize) this.UniqueValuelist).EndInit();
            base.ResumeLayout(false);
        }

       
        private SimpleButton btnAnd;
        private SimpleButton btnApply;
        private SimpleButton btnBracket;
        private SimpleButton btnClear;
        private SimpleButton btnClose;
        private SimpleButton btnEqual;
        private SimpleButton btnGetUniqueValue;
        private SimpleButton btnGreat;
        private SimpleButton btnGreatEqual;
        private SimpleButton btnIs;
        private SimpleButton btnLike;
        private SimpleButton btnLittle;
        private SimpleButton btnLittleEqual;
        private SimpleButton btnMatchOneChar;
        private SimpleButton btnMatchString;
        private SimpleButton btnNot;
        private SimpleButton btnNotEqual;
        private SimpleButton btnOr;
        private SimpleButton btnValidate;
        private ListBoxControl Fieldlist;
        private Label label2;
        private Label label4;
        private MemoEdit memEditWhereCaluse;
        private TextEdit textEdit1;
        private ListBoxControl UniqueValuelist;
    }
}