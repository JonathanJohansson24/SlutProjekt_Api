using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SlutProjekt_Api.Data;
using SlutProjekt_Api.Dto;
using SlutProjekt_Api.Interface;
using SlutProjekt_ApiModels;

namespace SlutProjekt_Api.Repository
{
    public class ChangeLogRepository : IChangeLogRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper; 

        public ChangeLogRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChangeLogDto>> ChangeLogHistory()
        {
            var changeLogs = await _context.ChangeLogs.ToListAsync();

            return _mapper.Map<IEnumerable<ChangeLogDto>>(changeLogs);
        }

    }
}
