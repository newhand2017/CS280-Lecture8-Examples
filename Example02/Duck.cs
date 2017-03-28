using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Duck
    {
        public string Name { get; set; }

        //-------------------------------------------------
        // 飛行模式
        //-------------------------------------------------
        //public IFlyBehavior FlyBehavior;
        private IFlyBehavior FlyBehavior;

        public void Fly()
        {
            if (FlyBehavior == null)
                Console.WriteLine("我不會飛。");
            else
                FlyBehavior.Fly();
        }

        //裝上飛行動作
        public void Equip(IFlyBehavior iterm)
        {
            this.FlyBehavior = iterm;
        }

        //-------------------------------------------------
    }
}