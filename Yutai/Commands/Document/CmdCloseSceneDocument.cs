﻿using System;
using Yutai.Plugins.Concrete;
using Yutai.Plugins.Enums;
using Yutai.Plugins.Interfaces;

namespace Yutai.Commands.Document
{
    public class CmdCloseSceneDocument : YutaiCommand
    {
        public CmdCloseSceneDocument(IAppContext context)
        {
            OnCreate(context);
        }

        public override void OnClick()
        {
        }

        public override void OnClick(object sender, EventArgs args)
        {
            OnClick();
        }

        public override void OnCreate(object hook)
        {
            _context = hook as IAppContext;
            base.m_caption = "关闭三维文档";
            base.m_category = "Document";
            base.m_bitmap = Properties.Resources.icon_project_open;
            base.m_name = "File.Sxd.CloseSXD";
            base._key = "File_Sxd_CloseSXD";
            base.m_toolTip = "关闭三维文档";
            base.m_checked = false;
            base.m_enabled = true;
            base._itemType = RibbonItemType.Button;
        }
    }
}