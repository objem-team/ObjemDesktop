using System;
using ObjemDesktop.window;

namespace ObjemDesktop.FaderValue
{
    public class FaderItems
    {
        public event EventHandler<FaderItemChangeEventArg> OnChangeItems;
        private FaderItem _item0;
        private FaderItem _item1;

        public FaderItem Item0
        {
            get => _item0;
            set
            {
                _item0 = value;
                var arg = new FaderItemChangeEventArg(0, Item0);
                OnChangeItems?.Invoke(this, arg);
            }
        }

        public FaderItem Item1
        {
            get => _item1;
            set
            {
                _item1 = value;
                var arg = new FaderItemChangeEventArg(1, Item1);
                OnChangeItems?.Invoke(this, arg);
            }
        }

        public FaderItem this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Item0;
                    case 1:
                        return Item1;
                    default:
                        return Item0;
                }
            }
        }
    }
}