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
        const float secondiSalitaPersona = 2;
        const float secondiDiscesaPersona = 1;
        int personeNelAscensore = 0;
        double altezzaGlobale;
        public MainWindow()
        {
            InitializeComponent();
            cabina.Margin = new Thickness(28, ALTEZZA_PIANO_1, 0, 0); //posizione di partenza
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            personeNelAscensore++;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lblPersoneAscensore.Content = personeNelAscensore;
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone1));
            t.Start();
        }
        public void MetodoThreadBottone1()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                 Scendendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiDiscesaPersona));
                personeNelAscensore--;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            personeNelAscensore++;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lblPersoneAscensore.Content = personeNelAscensore;
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone2));
            t.Start();
        }
        public void MetodoThreadBottone2()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                 Scendendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiDiscesaPersona));
                personeNelAscensore--;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            personeNelAscensore++;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lblPersoneAscensore.Content = personeNelAscensore;
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone3));
            t.Start();
        }
        public void MetodoThreadBottone3()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                 Scendendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiDiscesaPersona));
                personeNelAscensore--;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            personeNelAscensore++;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lblPersoneAscensore.Content = personeNelAscensore;
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone4));
            t.Start();
        }
        public void MetodoThreadBottone4()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                 Scendendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiDiscesaPersona));
                personeNelAscensore--;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            personeNelAscensore++;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lblPersoneAscensore.Content = personeNelAscensore;
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone5));
            t.Start();
        }
        public void MetodoThreadBottone5()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                 Scendendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiDiscesaPersona));
                personeNelAscensore--;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            personeNelAscensore++;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lblPersoneAscensore.Content = personeNelAscensore;
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottone6));
            t.Start();
        }
        public void MetodoThreadBottone6()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                 Scendendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiDiscesaPersona));
                personeNelAscensore--;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }
        private void btn1Piano_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottonePiano1));
            t.Start();
        }
        public void MetodoThreadBottonePiano1()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                        Salendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiSalitaPersona));
                personeNelAscensore++;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn2Piano_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottonePiano2));
            t.Start();
        }
        public void MetodoThreadBottonePiano2()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                        Salendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiSalitaPersona));
                personeNelAscensore++;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn3Piano_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottonePiano3));
            t.Start();
        }
        public void MetodoThreadBottonePiano3()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                        Salendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiSalitaPersona));
                personeNelAscensore++;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn4Piano_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottonePiano4));
            t.Start();
        }
        public void MetodoThreadBottonePiano4()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                        Salendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiSalitaPersona));
                personeNelAscensore++;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn5Piano_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottonePiano5));
            t.Start();
        }
        public void MetodoThreadBottonePiano5()
        {
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                        Salendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiSalitaPersona));
                personeNelAscensore++;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }

        private void btn6Piano_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                altezzaGlobale = cabina.Margin.Top;
            }));
            Thread t = new Thread(new ThreadStart(MetodoThreadBottonePiano6));
            t.Start();
        }
        public void MetodoThreadBottonePiano6()
        {
            lock (x)
            {this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "";
                }));
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
                }
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    cabina.Text = "                        Salendo";
                }));
                Thread.Sleep(TimeSpan.FromSeconds(secondiSalitaPersona));
                personeNelAscensore++;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPersoneAscensore.Content = personeNelAscensore;
                    cabina.Text = "";
                }));
            }
        }
    }
}
