﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using Yutai.Pipeline.Analysis.Helpers;
using Yutai.Pipeline.Analysis.QueryForms;
using Yutai.Pipeline.Config.Interfaces;
using Yutai.Plugins.Concrete;
using Yutai.Plugins.Enums;
using Yutai.Plugins.Interfaces;

namespace Yutai.Pipeline.Analysis.QueryCommands
{
    class CmdQueryByJMD : YutaiCommand
    {
        private SimpleQueryByJMDUI QueryUI;


        private PipelineAnalysisPlugin _plugin;

        public CmdQueryByJMD(IAppContext context, PipelineAnalysisPlugin plugin)
        {
            OnCreate(context);
            _plugin = plugin;
        }
        
        public override void OnClick(object sender, EventArgs args)
        {
            if (this.QueryUI == null || this.QueryUI.IsDisposed)
            {
                this.QueryUI = new SimpleQueryByJMDUI();
                this.QueryUI.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.QueryUI.MinimizeBox = false;
                this.QueryUI.MaximizeBox = false;
                this.QueryUI.TopMost = true;
                this.QueryUI.MapControl = (IMapControl3)_context.MapControl;
                this.QueryUI.pPipeCfg = _plugin.PipeConfig;
                this.QueryUI.m_context = this._context;
                this.QueryUI.Closing += new CancelEventHandler(this.QueryUI_Closing);
                this.QueryUI.Show();
                this.QueryUI.Plugin = _plugin;
            }
            else if (!this.QueryUI.Visible)
            {
                this.QueryUI.AutoFlash();
                this.QueryUI.Show();
                if (this.QueryUI.WindowState == FormWindowState.Minimized)
                {
                    this.QueryUI.WindowState = FormWindowState.Normal;
                }
            }
        }

        public override void OnCreate(object hook)
        {
            _context = hook as IAppContext;
            base.m_caption = "按建筑物查询";
            base.m_category = "PipelineQuery";
            base.m_bitmap = Properties.Resources.icon_query_building;
            base.m_name = "PipeQuery_ByJMD";
            base._key = "PipeQuery_ByJMD";
            base.m_toolTip = "按建筑物查询";
            base.m_checked = false;
            base.m_message = "按建筑物查询";
            base.m_enabled = true;
            base._itemType = RibbonItemType.Button;

            CommonUtils.AppContext = _context;
        }

        private void QueryUI_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.QueryUI.Hide();
        }

        public override bool Enabled
        {
            get
            {
                if (_plugin.PipeConfig?.Layers == null)
                    return false;
                if (_plugin.PipeConfig.Layers.Count <= 0)
                    return false;
                if (_plugin.PipeConfig.FunctionLayers.Count <= 0)
                    return false;
                if (_plugin.PipeConfig.GetFunctionLayer(enumFunctionLayerType.Jmd) == null)
                    return false;
                return true;
            }
        }
    }
}