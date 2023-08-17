using System;
using System.Collections;

namespace Neltic.Identity.Domain.Criteria;

public class Filters : CollectionBase
{
    public IList Items { get => List; }

    public Filters()
    {

    }

    #region Public Methods

    public int IndexOf(Filter item)
        => item is not null ? List.IndexOf(item) : -1;
    

    public int Add(Filter item)
        => item is not null ? List.Add(item) : -1;
    

    public void Remove(Filter customerItem)
        => InnerList.Remove(customerItem);

    public void AddRange(Filters collection) 
    {
        if (collection is not null)
            InnerList.AddRange(collection);
        
    }

    public void Insert(int index, Filter item)
    {
        if (index <= List.Count && item is not null)
            List.Insert(index, item);
        
    }

    public bool Contains(Filter item)
        => List.Contains(item);
    

    #endregion
}
