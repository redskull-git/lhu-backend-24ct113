using MaSV_NguyenVanTeo.Api.Database.Entities;

namespace MaSV_NguyenVanTeo.Api.IServices
{
    public interface IJwtTokenService
    {
        string GenerateToken(NguoiDungEntity user, string? hoTen = null);
    }
}
