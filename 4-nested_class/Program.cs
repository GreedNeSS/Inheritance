using System;

namespace _4_nested_class
{
    class Home
    {
        public class Window
        {
            bool windowIsOpen = false;

            public void ShutWindow()
            {
                if (windowIsOpen)
                {
                    windowIsOpen = false;
                }
            }

            public void OpenWindow()
            {
                if (!windowIsOpen)
                {
                    windowIsOpen = true;
                }
            }

            public void ShowWindow()
            {
                if (windowIsOpen)
                {
                    Console.WriteLine("Окно открыто");
                }
                else
                {
                    Console.WriteLine("Окно закрыто");
                }
            }
        }

        Window window = new Window();

        public Window FrontWindow
        {
            get { return window; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            Console.WriteLine(home.FrontWindow);
            home.FrontWindow.ShowWindow();
            home.FrontWindow.OpenWindow();
            home.FrontWindow.ShowWindow();
            home.FrontWindow.ShutWindow();
            home.FrontWindow.ShowWindow();
        }
    }
}
