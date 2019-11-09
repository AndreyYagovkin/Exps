using AutoMapper;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ExpenseTypeModel, ExpenseTypeView>();
            CreateMap<ExpenseModel, ExpenseView>();
            CreateMap<JournalModel, JournalView>();
        }
    }
}