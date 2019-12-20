using System;

namespace SmobilerSamplesNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Smobiler.Core.MobileServer server = new Smobiler.Core.MobileServer();
            //服务起始界面
            server.StartUpForm = typeof(SmobilerSamplesNetFramework.SmobilerForm1);
            //绑定事件
            server.SessionStart += new Smobiler.Core.SmobilerSessionEventHandler(MobileGlobal.OnSessionStart);
            server.SessionStop += new Smobiler.Core.SmobilerSessionEventHandler(MobileGlobal.OnSessionStop);
            server.SessionConnect += new Smobiler.Core.SmobilerSessionEventHandler(MobileGlobal.OnSessionConnect);
            server.ClientPushOpened += new Smobiler.Core.ClientPushOpenedEventHandler(MobileGlobal.OnPushCallBack);
            //启用服务
            server.StartServer();
            MobileGlobal.OnServerStart(server);
            Console.WriteLine("Smobiler Server Running");
        }
    }
}
