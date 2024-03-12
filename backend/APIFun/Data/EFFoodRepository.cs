
using SQLitePCL;

namespace APIFun.Data
{
    public class EFFoodRepository : IFoodRepository
    {
        private FoodContext _context;
        public EFFoodRepository(FoodContext temp) {
            _context = temp;
        }
        public IEnumerable<MarriottFood> Foods => _context.Foods;
    }
}
