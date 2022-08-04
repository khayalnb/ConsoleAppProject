using System;
using HumanResourcesManagmentSystem.Services;

namespace HumanResourcesManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            MenuService.Open();
            MenuService.Menu();
        }
    }
}
