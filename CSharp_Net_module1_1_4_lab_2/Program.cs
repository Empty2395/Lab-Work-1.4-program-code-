using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    public struct Computer_Game
    {
        private string Monitor, Keyboard, mouse, processor;

        private int money;

        public void SetValue(string Monitor, string Keyboard,string mouse, string processor, int money)
        {
            this.Monitor = Monitor;
            this.Keyboard = Keyboard;
            this.mouse = mouse;
            this.processor = processor;
            this.money = money;
        }
        public void Print()
        {
            Console.WriteLine(this.Monitor+ "Стоимость Монитора:" + this.money);
            Console.ReadLine();
        }

    }
}