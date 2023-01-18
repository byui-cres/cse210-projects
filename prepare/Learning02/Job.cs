public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0000;
    public int _endYear = 0000;
    public int _yearsOfService = 0;

    public Job()
    {

    }

    public void Display()
    {
        _yearsOfService =  _endYear - _startYear;
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
        Console.WriteLine($"Years of service = {_yearsOfService} years.");
    }

}