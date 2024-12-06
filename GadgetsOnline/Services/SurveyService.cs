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
                    new SurveyAnswer { Id = 1, AnswerText = "Çok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun deðilim" }
                }
            },
            new SurveyQuestion
            {
                Id = 3,
                Question = "Yemeklerin kalitesini nasýl deðerlendirirsiniz?",
                Answers = new List<SurveyAnswer>
                {
                    new SurveyAnswer { Id = 1, AnswerText = "Çok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun deðilim" }
                }
            },
            new SurveyQuestion
            {
                Id = 4,
                Question = "Otelin konumu ve ulaþým kolaylýðý hakkýnda ne düþünüyorsunuz?",
                Answers = new List<SurveyAnswer>
                {
                    new SurveyAnswer { Id = 1, AnswerText = "Çok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun deðilim" }
                }
            },
            new SurveyQuestion
            {
                Id = 5,
                Question = "Genel olarak otelde geçirdiðiniz zamandan ne kadar memnun kaldýnýz?",
                Answers = new List<SurveyAnswer>
                {
                    new SurveyAnswer { Id = 1, AnswerText = "Çok memnunum" },
                    new SurveyAnswer { Id = 2, AnswerText = "Memnunum" },
                    new SurveyAnswer { Id = 3, AnswerText = "Memnun deðilim" }
                }
            }
        };

        private readonly ApplicationDbContext applicationDbContext;

        public SurveyService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
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

        public bool SendQuestionData(List<SurveyAnswerResponse> data)
        {
            try
            {
                applicationDbContext.SurveyAnswerData.AddRange(data);
                applicationDbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SurveyAnswerResponse> GenerateRandomData()
        {
            Random rnd = new Random();
            List<SurveyAnswerResponse> dataList = new List<SurveyAnswerResponse>();
            for (int i = 0; i <= 1; i++)
            {
                var hotel = this.hotels[rnd.Next(hotels.Count)];
                foreach (var question in this.surveyQuestions)
                {
                    var data = new SurveyAnswerResponse() { HotelId = hotel.Id };
                    data.QuestionId = question.Id;
                    data.AnswerId = question.Answers[rnd.Next(question.Answers.Count)].Id;
                    data.EmotionalValue = rnd.Next(1, 10);
                    dataList.Add(data);
                }
            }

            applicationDbContext.SurveyAnswerData.AddRange(dataList);
            applicationDbContext.SaveChanges();

            return dataList;
        }

        private Hotel GetRandomHotel(List<Hotel> hotels)
        {
            Random random = new Random();
            int index = random.Next(hotels.Count);
            return hotels[index];
        }
    }
}