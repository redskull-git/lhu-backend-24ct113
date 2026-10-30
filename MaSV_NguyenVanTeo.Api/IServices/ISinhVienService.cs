using MaSV_NguyenVanTeo.Api.Dto;

namespace MaSV_NguyenVanTeo.Api.IServices
{
    public interface ISinhVienService
    {
        Task<List<SinhVienDto>> GetAllAsync();
        Task<bool> AddAsync(SinhVienAddDto req);
        Task<bool> EditAsync(SinhVienEditDto req);
        Task<bool> DeleteAsync(int sinhVienId);
    }
}
