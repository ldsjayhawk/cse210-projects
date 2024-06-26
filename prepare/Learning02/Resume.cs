public class Resume
{
    // Displays the job information in the format "Job Title (Company) StartYear-EndYear"
    // for example: "Software Engineer (Microsoft) 2019-2022".
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
      Console.WriteLine($"{_name}");
      Console.WriteLine("Jobs: ");

      foreach (Job job in _jobs)
        job.Display();
    }
}
