﻿using Yutai.Pipeline.Editor.Views;
using Yutai.Plugins.Mvp;

namespace Yutai.Pipeline.Editor
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            //container.RegisterService<IQueryResultView, QueryResultView>()
            //     .RegisterSingleton<QueryResultPresenter>();
            //    .RegisterService<IGeometryInfoView, GeometryInfoView>()
            //     .RegisterService<IAttributeEditView, AttributeEditView>()
            //    .RegisterSingleton<EditTemplatePresenter>()
            //     .RegisterSingleton<GeometryInfoPresenter>()
            //     .RegisterSingleton<AttributeEditPresenter>();
            container.RegisterService<IIdentifyRoadNameView, IdentifyRoadNameDockPanel>()
                .RegisterSingleton<IdentifyRoadNamePresenter>();
        }
    }
}