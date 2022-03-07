using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonData;

namespace CommandeService.Commands.interfaces
{
    interface IFilialeCommend
{
        Task<FilialeCommandModel> AddFilialeAsync(FilialeCommandModel model);
        Task<bool> DeleteFilialeAsync(int id);
        Task<bool> UpdateFilialeAsync(FilialeCommandModel model);


}
}
