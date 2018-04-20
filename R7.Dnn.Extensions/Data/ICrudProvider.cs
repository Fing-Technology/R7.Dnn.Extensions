﻿namespace R7.Dnn.Extensions.Data
{
    public interface ICrudProvider<TItem>
        where TItem : class
    {
        TItem Get<TKey> (TKey itemId);

        void Add (TItem item);

        void Update (TItem item);

        void Delete (TItem item);
    }
}