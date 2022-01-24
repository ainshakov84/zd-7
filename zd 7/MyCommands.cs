using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace zd_7
{
    internal class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs=new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "CTRL+T"));
            Exit = new RoutedUICommand("Выход","Exit",typeof(MyCommands),inputs);
        }

    }
}
