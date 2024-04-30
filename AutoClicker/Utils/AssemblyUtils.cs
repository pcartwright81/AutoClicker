namespace AutoClicker.Utils
{
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Input;

    public static class AssemblyUtils
    {
        private static readonly Assembly assembly = Assembly.GetExecutingAssembly();

        public static AssemblyName GetAssemblyInfo()
            => assembly.GetName();

        public static Icon GetApplicationIcon()
            => Icon.ExtractAssociatedIcon(assembly.Location);

        public static string GetProjectURL()
            => assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

        public static Uri GetProjectUri()
            => new Uri(GetProjectURL());

        public static RoutedUICommand CreateCommand(Type windowType, string commandName, KeyGesture keyGesture = null)
#pragma warning disable IDE0028 // Simplify collection initialization
            => keyGesture == null
                ? new RoutedUICommand(commandName, commandName, windowType)
                : new RoutedUICommand(commandName, commandName, windowType, new InputGestureCollection() { keyGesture });
#pragma warning restore IDE0028 // Simplify collection initialization
    }
}
