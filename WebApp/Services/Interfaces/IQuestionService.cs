using Core.Models;

namespace WebApp.Services.Interfaces
{
    public interface IQuestionService
    {
        public Task<bool> checkValidity(AOnly answer);
        public Task<Question> getQuestionById(int id);
        public Task<List<Question>> getQuestions();
    }
}
