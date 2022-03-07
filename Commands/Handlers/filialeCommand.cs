using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandeService.Commands.interfaces;
using CommonData;

namespace CommandeService.Commands.Handlers
{
    public class filialeCommand : IFilialeCommend
    {


        PolinaDBContext _db;
        public filialeCommand (PolinaDBContext db)
        {
            _db = db;
        }
        public async Task<FilialeCommandModel> AddFilialeAsync(FilialeCommandModel model)
        {
            Filiale filiale = new Filiale { FilialId = model.FilialId, filialName = model.filialName }; _db.fliales.Add(filiale); await _db.SaveChangesAsync(); model.FilialId = filiale.FilialId;
            return model;
        }
 

        public async Task<bool> DeleteFilialeAsync(int id) { Filiale filiale = _db.fliales.Find(id); 
            if (filiale!= null) { 
                _db.fliales.Remove(filiale); 
                await _db.SaveChangesAsync(); 
                return true;
            } else
                return false; }

         
        public async Task<bool> UpdateFilialeAsync(FilialeCommandModel model){
            try{ 
                 Filiale filiale = new Filiale
                     { FilialId =model.FilialId, filialName = model.filialName };
                  _db.fliales.Update(filiale); await _db.SaveChangesAsync();
                       model.FilialId=filiale.FilialId;
                         return true;
                }catch (Exception ex){
                return false;}}

         
    }
}
