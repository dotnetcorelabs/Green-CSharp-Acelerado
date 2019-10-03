using System;
using System.Collections.Generic;
using System.Text;

namespace Basico02
{
    class _08Events
    {
        public _08Events()
        {
            Coffee c = new Coffee();
            c.AddCoffe();
        }
    }

    public class Coffee
    {
        public EventArgs e;
        public delegate void OutOfBeansHandler(Coffee coffee, EventArgs args);
        public event OutOfBeansHandler OutOfBeans;

        public void AddCoffe()
        {
            if (OutOfBeans != null)
                OutOfBeans.Invoke(this, new EventArgs());
        }
    }
}
