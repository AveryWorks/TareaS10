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
using System.IO;

namespace TareaS10
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

            DeleteTextFile("RegistroOp");
            CreateTextFile("RegistroOp", "");
            SumOp.Clicked += SumOp_Clicked;
            ResOp.Clicked += ResOp_Clicked;
            MulOp.Clicked += MulOp_Clicked;
            DivOp.Clicked += DivOp_Clicked;
            ClnOp.Clicked += ClnOp_Clicked;

        }

        private void ClnOp_Clicked(object sender, EventArgs e)
        {
            Value1.Text = "";
            Value2.Text = "";
            Result.Text = "0,00";
        }

        private void DivOp_Clicked(object sender, EventArgs e)
        {
            if (Value1.Text != "")
            {
                if (Value2.Text != "")
                {
                    var dato1 = int.Parse(Value1.Text);
                    var dato2 = int.Parse(Value2.Text);
                    if (dato1!=0 && dato2!=0)
                    {
                        var resultado = dato1/dato2;
                        AppendTextToFile("RegistroOP", (dato1 + "/" + dato2 + "" + resultado));

                    }
                    else
                    {
                        ShowCustomAlertDialog("No se puede divir 0");
                    }
                }
                else
                {
                    ShowCustomAlertDialog("Faltan datos en Espacio 2");

                }
            }
            else
            {
                ShowCustomAlertDialog("Faltan datos en Espacio 1");
            }
        }

        private void MulOp_Clicked(object sender, EventArgs e)
        {
            if (Value1.Text != "")
            {
                if (Value2.Text != "")
                {
                    var dato1 = int.Parse(Value1.Text);
                    var dato2 = int.Parse(Value2.Text);
                    var resultado = dato1*dato2;
                    AppendTextToFile("RegistroOP", (dato1 + "x" + dato2 + "" + resultado));
                }
                else
                {
                    ShowCustomAlertDialog("Faltan datos en Espacio 2");

                }
            }
            else
            {
                ShowCustomAlertDialog("Faltan datos en Espacio 1");
            }
        }

        private void ResOp_Clicked(object sender, EventArgs e)
        {
            if (Value1.Text != "")
            {
                if (Value2.Text != "")
                {
                    var dato1 = int.Parse(Value1.Text);
                    var dato2 = int.Parse(Value2.Text);
                    var resultado = dato1 - dato2;
                    AppendTextToFile("RegistroOP", (dato1 + "-" + dato2 + "" + resultado));
                }
                else
                {
                    ShowCustomAlertDialog("Faltan datos en Espacio 2");

                }
            }
            else
            {
                ShowCustomAlertDialog("Faltan datos en Espacio 1");
            }
        }
        private void SumOp_Clicked(object sender, EventArgs e)
        {
            if (Value1.Text != "")
            {
                if (Value2.Text != "")
                {
                    var dato1 = int.Parse(Value1.Text);
                    var dato2 = int.Parse(Value2.Text);
                    var resultado = dato1 + dato2;
                    AppendTextToFile("RegistroOP", (dato1 + "+" + dato2 + "" + resultado));
                }
                else
                {
                    ShowCustomAlertDialog("Faltan datos en Espacio 2");

                }
            }
            else
            {
                ShowCustomAlertDialog("Faltan datos en Espacio 1");
            }
        }

        public async void ShowCustomAlertDialog(string message)
        {
            await DisplayAlert("Error", message,"Entendido");
        }

        public static void CreateTextFile(string fileName, string content)
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, fileName);

            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }
        }
        public static void DeleteTextFile(string fileName)
        {
            
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        public static void AppendTextToFile(string fileName, string content)
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, fileName);

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(content);
            }
        }

    }
}
