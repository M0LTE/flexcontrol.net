using System;

namespace flexcontrol.net
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn = new FlexKnob();
            fn.OnButtonPush += ButtonPushHandler;
            fn.OnRotate += RotateHandler;
            fn.Run();
        }

        static void ButtonPushHandler(Button which, TapType how)
        {
            Console.WriteLine($"{which} {how}");
        }

        static void RotateHandler(Direction dir, int speed)
        {
            Console.WriteLine($"{dir} {speed}");
        }
    }
}
