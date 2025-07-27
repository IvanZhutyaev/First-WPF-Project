using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstWPFProject
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand TestMes = new RoutedUICommand(
            "Test Message", "TestMes", typeof(CustomCommands), new InputGestureCollection
            {
                new KeyGesture(Key.C, ModifierKeys.Control)
            });
    }
}
