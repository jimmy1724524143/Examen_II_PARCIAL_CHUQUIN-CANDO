using Examen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public abstract class PreguntasBuilder
    {
        protected Preguntas QuestionQuiz;
        public Preguntas gettingQuestion() { return QuestionQuiz; }

        public void CreandoInstancia() { QuestionQuiz = new Preguntas(); }

        public abstract void Building(Preguntas pregunta);

    }
}
