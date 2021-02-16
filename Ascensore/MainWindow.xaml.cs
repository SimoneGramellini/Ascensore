﻿using System;
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
        const int ALTEZZA_PIANO_1 = 665;
        const int ALTEZZA_PIANO_2 = 543;
        const int ALTEZZA_PIANO_3 = 410;
        const int ALTEZZA_PIANO_4 = 273;
        const int ALTEZZA_PIANO_5 = 143;
        const int ALTEZZA_PIANO_6 = 22;
        int altezzaDaRaggiungere = 0;
        bool salire = false;
        int posizioneCabinaTop = 0;
        public MainWindow()
        {
            InitializeComponent();
            cabina.Margin = new Thickness(28, ALTEZZA_PIANO_3, 0, 0); //posizione di partenza
        }

        public void MuoviAscensore()
        {
            if (!salire) //devo scendere
            {
                for (int i = posizioneCabinaTop; i < altezzaDaRaggiungere; i += 2)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.01));
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        cabina.Margin = new Thickness(28, i, 0, 0);
                    }));
                }
            }
            else //salgo
            {
                for (int i = posizioneCabinaTop; i > altezzaDaRaggiungere; i -= 2)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.01));
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        cabina.Margin = new Thickness(28, i, 0, 0);
                    }));
                }
            }
        }
        public void GestisciPiano()
        {
            if ((int)cabina.Margin.Top <= altezzaDaRaggiungere)
            {
                salire = false;
            }
            else
            {
                salire = true;
            }
            posizioneCabinaTop = (int)cabina.Margin.Top;
            Thread t = new Thread(new ThreadStart(MuoviAscensore));
            t.Start();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            altezzaDaRaggiungere = ALTEZZA_PIANO_1;
            GestisciPiano();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            altezzaDaRaggiungere = ALTEZZA_PIANO_2;
            GestisciPiano();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            altezzaDaRaggiungere = ALTEZZA_PIANO_3;
            GestisciPiano();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            altezzaDaRaggiungere = ALTEZZA_PIANO_4;
            GestisciPiano();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            altezzaDaRaggiungere = ALTEZZA_PIANO_5;
            GestisciPiano();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            altezzaDaRaggiungere = ALTEZZA_PIANO_6;
            GestisciPiano();
        }
    }
}
