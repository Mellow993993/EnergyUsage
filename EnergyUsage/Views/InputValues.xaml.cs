﻿using EnergyUsage.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace EnergyUsage.Views
{
    /// <summary>
    /// Interaktionslogik für InputValues.xaml
    /// </summary>
    public partial class InputValues : Window
    {
        public InputValues()
        {
            InitializeComponent();
        }


        public bool? Open()
        {
            return this.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }


}
