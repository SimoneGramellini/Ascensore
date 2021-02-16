using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Ascensore
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static object x = new object();
        const double ALTEZZA_PIANO_1 = 665;
        const double ALTEZZA_PIANO_2 = 543;
        const double ALTEZZA_PIANO_3 = 410;
        const double ALTEZZA_PIANO_4 = 273;
        const double ALTEZZA_PIANO_5 = 143;
        const double ALTEZZA_PIANO_6 = 20;
        double altezzaGlobale;
        bool salireCabina1 = false;
        bool salireCabina2 = false;
        bool salireCabina3 = false;
        bool salireCabina4 = false;
        bool salireCabina5 = false;
        bool salireCabina6 = false;
        public MainWindow()
        {
            InitializeComponent();
            cabina.Margin = new Thickness(28, ALTEZZA_PIANO_2, 0, 0); //posizione di partenza
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            if (altezzaGlobale < ALTEZZA_PIANO_2)
            {
                salireCabina1 = false;
            }
            else
            {
                salireCabina1 = true;
            }
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone1));
            t.Start();
        }
        public void MetodoThreadBottone1()
        {
            lock (x)
            {
                if (altezzaGlobale < ALTEZZA_PIANO_1)
                {
                    while (altezzaGlobale < ALTEZZA_PIANO_1)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale += 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
                else
                {
                    while (altezzaGlobale > ALTEZZA_PIANO_1)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale -= 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            if (altezzaGlobale < ALTEZZA_PIANO_2)
            {
                salireCabina2 = false;
            }
            else
            {
                salireCabina2 = true;
            }
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone2));
            t.Start();
        }
        public void MetodoThreadBottone2()
        {
            lock (x)
            {
                if (altezzaGlobale < ALTEZZA_PIANO_2)
                {
                    while (altezzaGlobale < ALTEZZA_PIANO_2)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale += 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
                else
                {
                    while (altezzaGlobale > ALTEZZA_PIANO_2)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale -= 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone3));
            t.Start();
        }
        public void MetodoThreadBottone3()
        {
            lock (x)
            {
                if (altezzaGlobale < ALTEZZA_PIANO_3)
                {
                    while (altezzaGlobale < ALTEZZA_PIANO_3)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale += 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
                else
                {
                    while (altezzaGlobale > ALTEZZA_PIANO_3)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale -= 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            if (altezzaGlobale < ALTEZZA_PIANO_4)
            {
                salireCabina4 = false;
            }
            else
            {
                salireCabina4 = true;
            }
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone4));
            t.Start();
        }
        public void MetodoThreadBottone4()
        {
            lock (x)
            {
                if (altezzaGlobale < ALTEZZA_PIANO_4)
                {
                    while (altezzaGlobale < ALTEZZA_PIANO_4)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale += 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
                else
                {
                    while (altezzaGlobale > ALTEZZA_PIANO_4)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale -= 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            if (altezzaGlobale < ALTEZZA_PIANO_5)
            {
                salireCabina5 = false;
            }
            else
            {
                salireCabina5 = true;
            }
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone5));
            t.Start();
        }
        public void MetodoThreadBottone5()
        {
            lock (x)
            {
                if (altezzaGlobale < ALTEZZA_PIANO_5)
                {
                    while (altezzaGlobale < ALTEZZA_PIANO_5)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale += 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
                else
                {
                    while (altezzaGlobale > ALTEZZA_PIANO_5)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale -= 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            if (altezzaGlobale < ALTEZZA_PIANO_6)
            {
                salireCabina6 = false;
            }
            else
            {
                salireCabina6 = true;
            }
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone6));
            t.Start();
        }
        public void MetodoThreadBottone6()
        {
            lock (x)
            {
                if (altezzaGlobale < ALTEZZA_PIANO_6)
                {
                    while (altezzaGlobale < ALTEZZA_PIANO_6)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale += 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
                else
                {
                    while (altezzaGlobale > ALTEZZA_PIANO_6)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.01));
                        altezzaGlobale -= 2;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            cabina.Margin = new Thickness(28, altezzaGlobale, 0, 0);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(0.9));
                }
            }
        }
    }
}
