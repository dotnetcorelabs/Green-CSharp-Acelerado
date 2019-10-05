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
            c.AcabouOCafe += C_OutOfBeans;
            c.FazerCafe();
        }

        private void C_OutOfBeans(Coffee coffee, CoffeEventArgs args)
        {
            //tratar problema do cafe
            if(args.Beans == 0)
            {
                //fazer tal coisa
            }
        }
    }

    public class CoffeEventArgs : EventArgs
    {
        public int Beans { get; private set; }

        public CoffeEventArgs(int beans)
        {
            Beans = beans;
        }
    }

    public class Coffee
    {
        private int beans = 0;

        public delegate void OutOfBeansHandler(Coffee coffee, CoffeEventArgs args);
        public event OutOfBeansHandler AcabouOCafe;

        public delegate void CafeRecebidoHandler(Coffee coffe, CoffeEventArgs args);
        public event CafeRecebidoHandler OnCafeRecebido;

        public void FazerCafe()
        {
            if (beans == 0)
            {
                if (AcabouOCafe != null)
                    AcabouOCafe.Invoke(this, new CoffeEventArgs(beans));
            }
        }

        public void AbastecerCafe(int beans)
        {
            this.beans = beans;

            AcabouOCafe?.Invoke(this, new CoffeEventArgs(beans));
        }
    }
}
