using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class MemoriaRamRepository : BaseRepository<MemoriaRam>
    {
        //public void Create(MemoriaRam model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.MemoriaRam.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<MemoriaRam> Read()
        //{
        //    List<MemoriaRam> list = new List<MemoriaRam>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.MemoriaRam.ToList();
        //    }
        //    return list;
        //}
        //public MemoriaRam Read(int id)
        //{
        //    MemoriaRam model = new MemoriaRam();
        //    using (var context = new CompContext())
        //    {
        //        model = context.MemoriaRam.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(MemoriaRam model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<MemoriaRam>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<MemoriaRam>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}