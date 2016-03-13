using System;

namespace TopCat.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}