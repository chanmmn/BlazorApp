
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApplocalstorage.Data
{
    public class DataStorage //: IDataStorage
    {
        public static MemoryCache cache = MemoryCache.Default;
        //public void SaveData(DataObject data)
        //{
        //    CacheItemPolicy itemPolicy = new CacheItemPolicy();
        //    cache.Add(data.Id, data, itemPolicy);
        //}

        public Task<List<DataObject>> GetAll()
        {
            List<DataObject> lst = new List<DataObject>();

            foreach (var item in cache)
            {
                DataObject data = new DataObject();
                data = (DataObject)cache.Get(item.Key);                
            }

            //return lst;
            Task<List<DataObject>> task = Task.FromResult(lst);
            return task;
        }

    }
}
