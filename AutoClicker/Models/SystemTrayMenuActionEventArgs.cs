namespace AutoClicker.Models
{
    using System;
    using AutoClicker.Enums;

    public class SystemTrayMenuActionEventArgs : EventArgs
    {
        public SystemTrayMenuAction Action { get; set; }
    }
}
