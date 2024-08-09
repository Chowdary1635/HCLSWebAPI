using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdminRepository
    {
        public Task<List<Admin>> AllOperationalAdmins();
        public Task<Admin> AdminByAdminEmail(string Email);
        public Task<int> AdminRegistration(Admin admin);
        public Task<int> UpdateAdmin(Admin admin);
        public Task<int> DeleteAdmin(int AdminId);
    }
}
