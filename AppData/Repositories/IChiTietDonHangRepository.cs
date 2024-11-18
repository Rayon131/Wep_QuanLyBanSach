using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface IChiTietDonHangRepository
    {
        Task<IEnumerable<ChiTietDon>> GetAllChiTietDonHangAsync();
        Task<ChiTietDon> GetChiTietDonHangByIdAsync(Guid id);
        Task AddChiTietDonHangAsync(ChiTietDon chiTietDonHang);
        Task UpdateChiTietDonHangAsync(ChiTietDon chiTietDonHang);
        Task DeleteChiTietDonHangAsync(Guid id);
    }

}
