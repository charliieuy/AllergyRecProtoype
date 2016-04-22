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
        private MainWindowViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();

            ScriptHelper helper = new ScriptHelper(this);

            this.Loaded += (s, e) => {
                _viewModel = new MainWindowViewModel();
                this.DataContext = _viewModel;
            };

            this.reconcileButton.Click += (s,e) => {
                foreach(var allergyRec in _viewModel.AllergyRecVMList)
                {
                    Console.WriteLine(allergyRec.SelectedAllergen.Name);
                }
            };

            this.closeButton.Click += (s, e) => { this.Close(); };
        }
    }
}
