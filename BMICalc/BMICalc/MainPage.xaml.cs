using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMICalc
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        private void Btn_Clicked(object sender, System.EventArgs e)
        {
            int weight = Int32.Parse(Weight.Text);
            int height = Int32.Parse(Height.Text);
            double bmi = (weight * 703 / (height * height));
            Lbl_BMI.Text = $"Your BMI is {bmi}.";
        }
    }
}
