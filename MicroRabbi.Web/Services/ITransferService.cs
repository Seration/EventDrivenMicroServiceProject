using MicroRabbi.Web.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbi.Web.Services
{
   public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
