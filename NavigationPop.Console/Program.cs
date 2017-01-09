using System;
using System.Threading;
using Xamarin.Forms;

namespace NavigationPop.Console
{
    class MainClass
    {
        private static ManualResetEvent _mre = new ManualResetEvent(false);
        private static NavigationPage _nav = new NavigationPage();

        public static void Main(string[] args)
        {
            var iterationCount = 0;
            while (true)
            {
                iterationCount++;
                System.Console.WriteLine($"Attempt #{iterationCount} to trigger the thread issue");

                var page1 = new ContentPage { Content = new Label() };
                var page2 = new ContentPage { Content = new Label() };

                _nav.Navigation.PushAsync(page1).Wait();
                _nav.Navigation.PushAsync(page2).Wait();

                //var thread1 = new Thread(ThreadToPopNav);
                //var thread2 = new Thread(ThreadToPopNav);

                //thread1.Start();
                //thread2.Start();

                //Thread.Sleep(500);

                //_mre.Set();

                //thread1.Join();
                //thread2.Join();

                //_mre.Reset();
                _nav.Navigation.PopAsync().Wait();
                _nav.Navigation.PopAsync().Wait();
            }
        }

        private static void ThreadToPopNav()
        {
            // Wait for signal
            _mre.WaitOne();

            // Pop it like its hot
            _nav.Navigation.PopAsync().Wait();

            System.Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {DateTime.Now.Ticks}");
        }
    }
}
