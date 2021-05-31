using castagnino_rodrigo_lppa_parcial1.Data.Services;
using castagnino_rodrigo_lppa_parcial1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace castagnino_rodrigo_lppa_parcial1.Business
{
    public class AfiliadosBiz
    {
        public void Agregar(Afiliados model)
        {
            var db = new BaseDataService<Afiliados>();
            db.Create(model);

        }

        public List<Afiliados> Listar()
        {
            var db = new BaseDataService<Afiliados>();
            var lista = db.Get();
            return lista;
        }

        public Afiliados Get(int id)
        {
            var db = new BaseDataService<Afiliados>();
            return db.GetById(id);
        }

        public void Eliminar(Afiliados model)
        {
            var db = new BaseDataService<Afiliados>();
            db.Delete(model);
        }

        public void Update(Afiliados model)
        {
            var db = new BaseDataService<Afiliados>();
            db.Update(model);
        }
    }
}