using WebApp.Services.Interfaces;
using Core.Models;
using System.Net.Http.Json;

namespace WebApp.Services
{
    public class QuestionService : IQuestionService

    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private string _url;

        public QuestionService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _url = configuration["base_api"];
        }

        public async Task<bool> checkValidity(AOnly answer)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"/api/questions/{answer.id}/{answer.answer}");
        }

        public async Task<Question> getQuestionById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Question>($"/api/questions/{id}");
        }

        public async Task<List<Question>> getQuestions()
        {
            return await _httpClient.GetFromJsonAsync<List<Question>>("/api/questions");
        }
    }
}
