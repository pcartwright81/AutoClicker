namespace AutoClicker.Models
{
    using System;
    using AutoClicker.Enums;

    public class HotkeyChangedEventArgs : EventArgs
    {
        public KeyMapping Hotkey { get; set; }
        public Operation Operation { get; set; }
    }
}
