public class Resume
{
    public string _name = "";
    public List<Job> _jobList = new List<Job>();

    public Resume()
    {
        //
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (var jobs in _jobList)
        {
            jobs.Display();
        }
    }

}