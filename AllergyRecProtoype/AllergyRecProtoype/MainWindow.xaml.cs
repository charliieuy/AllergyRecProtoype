using AllergyrecPrototype;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Runtime.Serialization;
using Xceed.Wpf.Toolkit.Themes;

namespace AllergyRecProtoype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ScriptHelper helper = new ScriptHelper(this);

            this.Loaded += (s, e) => { this.DataContext = new MainWindowViewModel(); };

            this.reconcileButton.Click += (s,e) => { };

            this.closeButton.Click += (s, e) => { this.Close(); };
        }
    }
}
