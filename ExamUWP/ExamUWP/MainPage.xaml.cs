﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExamUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.MainFrame.Navigate(typeof(AddFile));
        }
        private void View(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(typeof(ShowFile));
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(typeof(AddFile));
        }

        private void TextBlock_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {

        }

       
    }
}
