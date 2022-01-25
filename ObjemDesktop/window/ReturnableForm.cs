using System;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public class ReturnableValueForm<T> : Form
    {
        internal readonly Action<T> Callback;
        protected ReturnableValueForm(Action<T> callback)
        {
            Callback = callback;
        }
    }
}