﻿namespace Sotsera.Blazor.Toaster.Core.Models
{
    public class ToasterConfiguration
    {
        public string ToastClass { get; set; }
        public ToastIconClasses IconClasses;
        public string PositionClass { get; set; }

        public decimal MaximumOpacity { get; set; } = 0.8m;

        public int VisibleStateDuration { get; set; } = 5000;
        public int ShowTransitionDuration { get; set; } = 1000;
        public int ShowStepDuration { get; set; } = 100;
        public int HideTransitionDuration { get; set; } = 2000;
        public int HideStepDuration { get; set; } = 100;

        public ToasterConfiguration()
        {
            ToastClass = Constants.Classes.Toast;
            IconClasses = new ToastIconClasses();
            PositionClass = Constants.Classes.Position.TopRight;
        }
    }
}