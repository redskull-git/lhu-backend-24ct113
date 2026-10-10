using MaSV_NguyenVanTeo.Api.Dto;

namespace MaSV_NguyenVanTeo.Api.IServices
{
    public interface ILopHocPhanService
    {
        Task<List<LopHocPhanDto>> GetAllAsync();

        Task<bool> AddAsync(LopHocPhanAddDto req);

        Task<bool> EditAsync(LopHocPhanEditDto req);

        Task<bool> DeleteAsync(int lopHocPhanId);
    }
}
