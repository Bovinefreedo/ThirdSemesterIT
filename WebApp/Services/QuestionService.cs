using Core.Models;

namespace WebApp.Services
{
    public class QuestionService : IQuestionService
    {
        private HttpClient _httpClient;
        private string _baseAPI;
        public QuestionService(HttpClient httpClient, IConfiguration config) { 
            _httpClient = httpClient;
            _baseAPI = config["baseAPI"];
        }    
        public Task<Question> getQuestionById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Question>> getQuestions()
        {
            throw new NotImplementedException();
        }

        public Task<Question> validateQuestion(AOnly answer)
        {
            throw new NotImplementedException();
        }
    }
}
