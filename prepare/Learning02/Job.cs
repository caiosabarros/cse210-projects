namespace Program
{
    class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {

    }
    public void Display()
    {
        System.Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    static void Main(string[] args)
    {
     Job job = new Job();
     job._company = "Microsoft";
     job._endYear = 2023;
     job._startYear = 2020;
     job._jobTitle = "Blockchain Engineer";
     job.Display();
    }
}
}