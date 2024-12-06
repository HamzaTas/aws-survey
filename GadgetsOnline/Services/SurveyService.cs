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
                    Question = "Odanýzýn temizliði hakkýnda ne düþünüyorsunuz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 1, AnswerText = "Çok memnunum" },
                        new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 3, AnswerText = "Memnun deðilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 2,
                    Question = "Otel personelinin ilgisi nasýldý?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 4, AnswerText = "Çok memnunum" },
                        new SurveyAnswer { Id = 5, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 6, AnswerText = "Memnun deðilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 3,
                    Question = "Yemeklerin kalitesini nasýl deðerlendirirsiniz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 7, AnswerText = "Çok memnunum" },
                        new SurveyAnswer { Id = 8, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 9, AnswerText = "Memnun deðilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 4,
                    Question = "Otelin konumu ve ulaþým kolaylýðý hakkýnda ne düþünüyorsunuz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 10, AnswerText = "Çok memnunum" },
                        new SurveyAnswer { Id = 11, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 12, AnswerText = "Memnun deðilim" }
                    }
                },
                new SurveyQuestion
                {
                    Id = 5,
                    Question = "Genel olarak otelde geçirdiðiniz zamandan ne kadar memnun kaldýnýz?",
                    Answers = new List<SurveyAnswer>
                    {
                        new SurveyAnswer { Id = 13, AnswerText = "Çok memnunum" },
                        new SurveyAnswer { Id = 14, AnswerText = "Memnunum" },
                        new SurveyAnswer { Id = 15, AnswerText = "Memnun deðilim" }
                    }
                }
            };
        }
    }
}