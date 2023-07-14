using Examen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class PreguntasQuiz
    {
        protected PreguntasBuilder preguntas;

        public void SetPreguntasBuilder(PreguntasBuilder question) { preguntas = question; }

        public Preguntas Gettingpreguntas() { return preguntas.gettingQuestion(); }

        public void BuildingQuestions()
        {
            preguntas.CreandoInstancia();

        }

    }
}
