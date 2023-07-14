using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen
{
    public partial class MainPage : ContentPage
    {
        public static List<Preguntas> listapreguntas = new List<Preguntas>
        {

          new Preguntas
            {
                Id = 1,
                Quest_ = "1.Qué es Xamari",
                resp1_ = "IDE",
                resp2_ = "FRAMEWORK",
                resp3_ = "LIBRERIA",
                resp4_ = "LENGUAJE DE PROGRAMACION",
                Correcto = "FRAMEWORK"

            },

            new Preguntas
            {
                Id = 2,
                Quest_ = "2. Xamari que plataforma usa:",
                resp1_ = "IOs",
                resp2_ = "Android",
                resp3_ = "Windows",
                resp4_ = "Multiplataforma",
                Correcto = "Multiplataforma",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "3.Qué lenguaje de programación  utiliza Xamari.",
                resp1_ = "Java",
                resp2_ = "Python",
                resp3_ = "C#",
                resp4_ = "JavaScript",
                Correcto = "C#"
            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "4. Xamari es destinado para aplicaciones:.",
                resp1_ = ".xml",
                resp2_ = ".java",
                resp3_ = ".apk",
                resp4_ = "moviles",
                Correcto = "moviles",

            },
            new Preguntas
            {
                Id = 5,
                Quest_ = "5. Qué herramienta se utiliza en Xamari para desarrollar intefaces graficas?.",
                resp1_ = "Logcat",
                resp2_ = "Debugger",
                resp3_ = "Xamari.Forms",
                resp4_ = "Emulador de Android",
                Correcto = "Xamari.Forms"

            },
            
        };
        int point = 1, score = 0;
        string RespuestaCorrecta;
        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        private string SetPregunta(int ID)
        {
            Preguntas list = listapreguntas.Where(a => a.Id == ID).SingleOrDefault();
            try
            {
                lblpreguntita.Text = list.Quest_;
                btn1.Text = list.resp1_;
                btn2.Text = list.resp2_;
                btn3.Text = list.resp3_;
                btn4.Text = list.resp4_;

                RespuestaCorrecta = list.Correcto;
            }
            catch (Exception)
            {

            }

            return RespuestaCorrecta;
        }
     
        private void btnresp1_Clicked(object sender, EventArgs e)
         {
            if (btn1.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btn1.IsVisible = true;
        }
        private void btnresp2_Clicked(object sender, EventArgs e)
        {
            if (btn2.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btn2.IsVisible = false;
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (btn3.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btn3.IsVisible = true;
        }


        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (btn4.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            


        }

        private void btnsalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        async void mostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("FINALIZACION", "LA NOTA OBTENIDA  ES DE: " + score + " / 5 puntos.", "OK");
        }
    }
}

                     
