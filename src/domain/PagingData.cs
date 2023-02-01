namespace Neltic.Shared.Domain;
public class PagingData<T>
{
    public int TotalRowsCount { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int PageCount { get; set; }
    public int TotalPages { get; set; }
    public List<T> Data { get;}
}
