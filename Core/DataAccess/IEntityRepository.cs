using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // <T> : Bu interface oluşturulurken eklenecek class
    // T:class : T bir clas olmaz zorunda
    //IEntity: T bir IEntity interfacesi ile oluşturulan bir implement olmalı
    //new() : T new() lene bilen bir class olmalı böylelikle IEntity değil onun implementlerini kullanmaz zorunda
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GelAll(Expression<Func<T, bool>> filter = null); //"Expression<Func<T,bool>> filter=null" ile listelerde linq ile filtrelemeye yardıcı olurr "filter=null" filtre vermeye bilrisin
        T Get(Expression<Func<T, bool>> filter); // Tek bir bilginin detajına gitme
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
