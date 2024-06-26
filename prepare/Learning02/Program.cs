using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Epiq";
        job1._jobTitle = "Quality Assurance Engineer";
        job1._startYear = 2016;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "BMW Financial Services";
        job2._jobTitle = "Retailer Accounting Specialist";
        job2._startYear = 2005;
        job2._endYear = 2015;

		Resume myResume = new Resume();
        myResume._name = "Cris Altman";

		myResume._jobs.Add(job1);
		myResume._jobs.Add(job2);

        myResume.Display();
	}
}