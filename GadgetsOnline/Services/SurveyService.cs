using System;
using System.Collections.Generic;
using System.Linq;
using GadgetsOnline.Models;
using Microsoft.AspNetCore.Http;

namespace GadgetsOnline.Services
{
    public class SurveyService : ISurveyService
    {
        private List<Hotel> hotels = new List<Hotel>
        {
            new Hotel { Id = 101, Name = "Azure Haven Resort" },
            new Hotel { Id = 102, Name = "Golden Sand Suites" },
            new Hotel { Id = 103, Name = "Crystal Peak Hotel" }
        };

        private List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>
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
                    new SurveyAnswer { Id = 1, AnswerText = "�ok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun de�ilim" }
                }
            },
            new SurveyQuestion
            {
                Id = 3,
                Question = "Yemeklerin kalitesini nas�l de�erlendirirsiniz?",
                Answers = new List<SurveyAnswer>
                {
                    new SurveyAnswer { Id = 1, AnswerText = "�ok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun de�ilim" }
                }
            },
            new SurveyQuestion
            {
                Id = 4,
                Question = "Otelin konumu ve ula��m kolayl��� hakk�nda ne d���n�yorsunuz?",
                Answers = new List<SurveyAnswer>
                {
                    new SurveyAnswer { Id = 1, AnswerText = "�ok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun de�ilim" }
                }
            },
            new SurveyQuestion
            {
                Id = 5,
                Question = "Genel olarak otelde ge�irdi�iniz zamandan ne kadar memnun kald�n�z?",
                Answers = new List<SurveyAnswer>
                {
                    new SurveyAnswer { Id = 1, AnswerText = "�ok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun de�ilim" }
                }
            }
        };

        public SurveyService()
        {
        }

        public Hotel GetRandomHotel()
        {
            var randomHotel = GetRandomHotel(hotels);
            return randomHotel;
        }

        public SurveyMainModel GetHotelSurveyQuestions()
        {
            var hotel = GetRandomHotel();

            var response = new SurveyMainModel()
            {
                HotelId = hotel.Id,
                HotelName = hotel.Name,
                SurveyQuestions = this.surveyQuestions
            };

            return response;
        }

        private Hotel GetRandomHotel(List<Hotel> hotels)
        {
            Random random = new Random();
            int index = random.Next(hotels.Count);
            return hotels[index];
        }
    }
}