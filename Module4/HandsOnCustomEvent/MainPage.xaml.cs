﻿using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HandsOnCustomEvent
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Circle_Click(object sender, MessageEventArgs e)
        {
            var dialog = new MessageDialog(e.Message, "Circle");
            await dialog.ShowAsync();
        }
    }
}
