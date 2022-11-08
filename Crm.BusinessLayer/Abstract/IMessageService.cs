using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> GetReceiverMessageList(string mail);
    }
}
