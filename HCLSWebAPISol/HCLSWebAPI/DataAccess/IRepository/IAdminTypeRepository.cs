﻿using HCLSWebAPI.DataAccess.Repository;
using HCLSWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCLSWebAPI.DataAccess.IRepository
{
    public interface IAdminTypeRepository
    {
        public Task<List<AdminType>> AllAdminTypes();
        public Task<AdminType> GetAdminTypeById(int AdminTypeId);
        public Task<List<AdminType>> GetAdminTypeByName(string AdminTypeName);
        public Task<int> InsertAdminType(AdminType Adminty);
        public Task<int> UpdateAdminType(AdminType Adminty);
        public Task<int> DeleteAdminType(int AdminTypeId);

    }
}
