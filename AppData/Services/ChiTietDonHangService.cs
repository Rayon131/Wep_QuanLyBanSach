using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class ChiTietDonHangService : IChiTietDonHangService
    {
        private readonly IChiTietDonHangRepository _chiTietDonHangRepository;

        public ChiTietDonHangService(IChiTietDonHangRepository chiTietDonHangRepository)
        {
            _chiTietDonHangRepository = chiTietDonHangRepository;
        }

        public async Task<IEnumerable<ChiTietDon>> GetAllChiTietDonHangAsync()
        {
            return await _chiTietDonHangRepository.GetAllChiTietDonHangAsync();
        }

        public async Task<ChiTietDon> GetChiTietDonHangByIdAsync(Guid id)
        {
            return await _chiTietDonHangRepository.GetChiTietDonHangByIdAsync(id);
        }

        public async Task AddChiTietDonHangAsync(ChiTietDon chiTietDonHang)
        {
            await _chiTietDonHangRepository.AddChiTietDonHangAsync(chiTietDonHang);
        }

        public async Task UpdateChiTietDonHangAsync(ChiTietDon chiTietDonHang)
        {
            await _chiTietDonHangRepository.UpdateChiTietDonHangAsync(chiTietDonHang);
        }

        public async Task DeleteChiTietDonHangAsync(Guid id)
        {
            await _chiTietDonHangRepository.DeleteChiTietDonHangAsync(id);
        }
    }

}
