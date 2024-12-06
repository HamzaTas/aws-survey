using System;
using System.Collections.Generic;
using System.Linq;
using GadgetsOnline.Models;
using Microsoft.AspNetCore.Http;

namespace GadgetsOnline.Services
{
    public class SurveyService : ISurveyService
    {
        public SurveyService()
        {
        }

        public List<SurveyQuestion> GetSurveyQuestions()
        {
            return new List<SurveyQuestion>
            {
                new SurveyQuestion
                {
                    Id = 1,
                    Question = "Odan�z�n temizli�i hakk�nda ne d���n�yorsunuz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 1, AnswerText = "�ok memnunum" },
                        new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 3, AnswerText = "Memnun de�ilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 2,
                    Question = "Otel personelinin ilgisi nas�ld�?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 4, AnswerText = "�ok memnunum" },
                        new SurveyAnswer { Id = 5, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 6, AnswerText = "Memnun de�ilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 3,
                    Question = "Yemeklerin kalitesini nas�l de�erlendirirsiniz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 7, AnswerText = "�ok memnunum" },
                        new SurveyAnswer { Id = 8, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 9, AnswerText = "Memnun de�ilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 4,
                    Question = "Otelin konumu ve ula��m kolayl��� hakk�nda ne d���n�yorsunuz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 10, AnswerText = "�ok memnunum" },
                        new SurveyAnswer { Id = 11, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 12, AnswerText = "Memnun de�ilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 5,
                    Question = "Genel olarak otelde ge�irdi�iniz zamandan ne kadar memnun kald�n�z?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 13, AnswerText = "�ok memnunum" },
                        new SurveyAnswer { Id = 14, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 15, AnswerText = "Memnun de�ilim" }
                    }
                }
            };
        }
    }
}