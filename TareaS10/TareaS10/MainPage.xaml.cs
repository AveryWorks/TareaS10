using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.Runtime;

namespace TareaS10
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            

            SumOp.Clicked += SumOp_Clicked;
            ResOp.Clicked += ResOp_Clicked;
            MulOp.Clicked += MulOp_Clicked;
            DivOp.Clicked += DivOp_Clicked;
            ClnOp.Clicked += ClnOp_Clicked;

        }

        private void ClnOp_Clicked(object sender, EventArgs e)
        {
            if (Value1.Text!="")
            {
                if (Value2.Text!="")
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void DivOp_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MulOp_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ResOp_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SumOp_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void MistakeEntry(string message)
        {
            var msg = message;
            var aqui= Android.App.Application.Context;
            var duration = ((int)message.Length);
            Toast.MakeText(aqui, duration);
        }
            
    }
}
