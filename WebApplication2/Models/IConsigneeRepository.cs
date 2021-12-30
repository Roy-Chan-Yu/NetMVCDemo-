using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    interface IConsigneeRepository : IDisposable
    {
        void Create(consignee_manageme entity);
        void Update(consignee_manageme entity);
        void Delete(consignee_manageme entity);
        consignee_manageme Get(consignee_manageme entity);
        IQueryable<consignee_manageme> GetAll();

        void SaveChange();
    }
}
