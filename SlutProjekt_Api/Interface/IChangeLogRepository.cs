using SlutProjekt_Api.Dto;
using SlutProjekt_ApiModels;

namespace SlutProjekt_Api.Interface
{
    public interface IChangeLogRepository
    {
        Task<IEnumerable<ChangeLogDto>> ChangeLogHistory();
    }
}
