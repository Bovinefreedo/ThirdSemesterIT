using Core.Models;

namespace WebApp.Services
{
    public interface IQuestionService
    {
        Task<List<Question>> getQuestions();
        Task<Question> getQuestionById(int id);
        Task<Question> validateQuestion(AOnly answer);

    }
}
