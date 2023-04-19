using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StorytellingMobile.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavingThrowsLabel : ContentView
    {
        public SavingThrowsLabel()
        {
            InitializeComponent();
        }

        private static readonly BindableProperty TitleThrowProperty = 
            BindableProperty.Create(nameof(TitleThrow), typeof(string), typeof(SavingThrowsLabel), string.Empty);
        
        private static readonly BindableProperty ValueThrowProperty = 
            BindableProperty.Create(nameof(ValueThrow), typeof(string), typeof(SavingThrowsLabel), string.Empty);

        public string TitleThrow
        {
            get => (string)GetValue(TitleThrowProperty); 
            set => SetValue(TitleThrowProperty, value);
        }
        
        public string ValueThrow
        {
            get => (string)GetValue(ValueThrowProperty);
            set => SetValue(ValueThrowProperty, value);
        }

        protected override void OnPropertyChanged( [CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            
            if (propertyName == TitleThrowProperty.PropertyName)
                TitleLabel.Text = TitleThrow;
            
            if (propertyName == ValueThrowProperty.PropertyName)
                ValueLabel.Text = ValueThrow;
        }
    }
}