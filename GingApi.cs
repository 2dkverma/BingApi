namespace BingApi;

public class BingApi
{
    public int  Id {get;set;}
    public string? LocationName {get;set;}
    public DateTime OpeningTime { get; set; }
    public DateTime EndingTime { get; set; }

    public BingApi(int id, string location, DateTime open, DateTime end)
    {
        Id = id;
        LocationName = location;
        OpeningTime = open;
        EndingTime = end;
    }
   
}
