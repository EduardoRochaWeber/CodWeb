using MvcDBO.Context;
using MvcDBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDBO.Repository
{
    public class PlacaDeVideoRepository : BaseRepository<PlacaDeVideo>
    {
        //public void Create(PlacaDeVideo model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.PlacaDeVideo.Add(model);
        //        context.SaveChanges();
        //    }
        //}
        //public List<PlacaDeVideo> Read()
        //{
        //    List<PlacaDeVideo> list = new List<PlacaDeVideo>();
        //    using (var context = new CompContext())
        //    {
        //        list = context.PlacaDeVideo.ToList();
        //    }
        //    return list;
        //}
        //public PlacaDeVideo Read(int id)
        //{
        //    PlacaDeVideo model = new PlacaDeVideo();
        //    using (var context = new CompContext())
        //    {
        //        model = context.PlacaDeVideo.Find(id);
        //    }
        //    return model;
        //}
        //public void Update(PlacaDeVideo model)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<PlacaDeVideo>(model).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        //public void Delete(int id)
        //{
        //    using (var context = new CompContext())
        //    {
        //        context.Entry<PlacaDeVideo>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}