using MaSV_NguyenVanTeo.Api.Dto;

namespace MaSV_NguyenVanTeo.Api.IServices
{
    public interface IMonHocService
    {
        Task<List<MonHocDto>> GetAllAsync();

        Task<bool> AddAsync(MonHocAddDto req);

        Task<bool> EditAsync(MonHocEditDto req);

        Task<bool> DeleteAsync(int monHocId);
    }
}
