using AutoMapper;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ExpenseTypeModel, ExpenseTypeView>()
                .ForMember(x => x.ExpenseTypeName, s => s.MapFrom(x => x.Name));
            CreateMap<ExpenseModel, ExpenseView>();
            CreateMap<JournalModel, JournalView>();
        }
    }
}