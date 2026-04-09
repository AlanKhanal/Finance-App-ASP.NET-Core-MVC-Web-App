using FinanceApp.Models;

namespace FinanceApp.Data.Services
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetaAll();
        Task Add(Expense expense);
        IQueryable GetChartData();
    }
}
