﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using Yutai.Controls;
using Yutai.Plugins.Concrete;
using Yutai.Plugins.Enums;
using Yutai.Plugins.Interfaces;

namespace Yutai.Commands.MapLegend
{
    public class CmdClearScaleRange : YutaiCommand
    {
        private IMapLegendView _view;

        public CmdClearScaleRange(IAppContext context, IMapLegendView view)
        {
            _context = context;
            _view = view;
            OnCreate();
        }

        public override bool Enabled
        {
            get
            {
                if (_view == null) return false;
                if (_view.SelectedMap == null)
                {
                    if (_view.SelectedLayer == null) return false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void OnCreate()
        {
            base.m_caption = "清除比例范围";
            base.m_category = "TOC";
            base.m_bitmap = null;
            base.m_name = "dropVisibleScaleRange.mnuClearScaleRange";
            base._key = "dropVisibleScaleRange.mnuClearScaleRange";
            base.m_toolTip = "清除比例范围";
            base.m_checked = false;
            base.m_enabled = true;
            base._itemType = RibbonItemType.Button;
        }

        public override void OnClick(object sender, EventArgs args)
        {
            OnClick();
        }

        public override void OnCreate(object hook)
        {
            OnCreate();
        }

        public void OnClick()
        {
            if (_view.SelectedItemType == esriTOCControlItem.esriTOCControlItemLayer)
            {
                _view.SelectedLayer.MaximumScale = 0.0;
                _view.SelectedLayer.MinimumScale = 0.0;
            }
        }
    }
}