﻿using LenovoLegionToolkit.Lib;
using Wpf.Ui.Common;

namespace LenovoLegionToolkit.WPF.Controls.Dashboard
{
    public class FlipToStartControl : AbstractToggleFeatureCardControl<FlipToStartState>
    {
        protected override FlipToStartState OnState => FlipToStartState.On;

        protected override FlipToStartState OffState => FlipToStartState.Off;

        public FlipToStartControl()
        {
            Icon = SymbolRegular.Power24;
            Title = "Flip To Start";
            Subtitle = "Turn on the laptop when you open the lid.";
        }
    }
}
