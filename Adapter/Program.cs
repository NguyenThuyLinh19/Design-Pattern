using Adapter;

class Program
{
    static void Main(string[] args)
    {
        // Client chỉ làm việc với IClient, nhưng ta muốn sử dụng OldService.
        OldService oldService = new OldService();
        IClient adapter = new adt(oldService);

        // Client sử dụng interface IClient mà không cần biết về OldService
        adapter.Request();
    }
}
