﻿using Crm.BusinessLayer.Abstract;
using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.EntityFrameWork;
using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Concrete
{
    public class RoleManager:IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void TDelete(Role t)
        {
            _roleDal.delete(t);
        }

        public Role TGetByID(int id)
        {
            return _roleDal.GetByID(id);
        }

        public List<Role> TGetListAll()
        {
            return _roleDal.GetListAll();
        }

        public void TInsert(Role t)
        {
            _roleDal.insert(t);
        }

        public void TUpdate(Role t)
        {
            _roleDal.update(t);
        }
    }
}
