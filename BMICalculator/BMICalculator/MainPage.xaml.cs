﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace BMICalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Btn_Clicked(object sender, System.EventArgs e)
        {
            int weight = Int32.Parse(Inp_weight.Text);
            int height = Int32.Parse(Inp_height.Text);
            int bmi = (weight * 703) / (height * height);
            Lbl_BMI.Text = $"Your BMI is {bmi}.";
        }
    }
}