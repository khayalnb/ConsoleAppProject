using HumanResourcesManagmentSystem.WarningMessages;
using System;
using System.Threading;


namespace HumanResourcesManagmentSystem.Services
{
    public static class appOpenService
    {
        public static void AppOpen()
        {
            int windowWidth1 = Console.WindowWidth +20;
            int windowWidth2 = Console.WindowWidth + 30;
            int windowWidth3 = Console.WindowWidth - 65;
            Console.WriteLine(String.Format("{0," + windowWidth2 / 2 + "}", TimeResultService.TimeResult()));
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine(String.Format("{0," + windowWidth1 / 2 + "}", WarningMessage.welcomeMessage));
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine(String.Format("{0," + windowWidth2 / 2 + "}", WarningMessage.waitMessage));
            Console.WriteLine();
            Thread.Sleep(500);
            Console.Write(String.Format("{0," + windowWidth3 / 2 + "}", ""));
            LoadingService.Loading();
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine(String.Format("{0," + windowWidth2 / 2 + "}", WarningMessage.systemName));
            Console.WriteLine();
        }
    }
}
