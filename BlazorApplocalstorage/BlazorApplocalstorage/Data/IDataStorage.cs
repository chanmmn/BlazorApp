using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplocalstorage.Data
{
    public interface IDataStorage
    {
        public void SaveData(DataObject data);
        public List<DataObject> GetAll();
        //Task<List<DataObject>> GetAll();
    }
}
