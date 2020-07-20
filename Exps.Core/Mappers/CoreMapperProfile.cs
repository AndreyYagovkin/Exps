using AutoMapper;
using Exps.Core.Entities;
using Exps.Core.Logic.Journal;

namespace Exps.Core
{
    public class CoreMapperProfile : Profile
    {
        public CoreMapperProfile()
        {
            CreateMap<Journal, GetJournalRecordsView>();
        }
    }
}