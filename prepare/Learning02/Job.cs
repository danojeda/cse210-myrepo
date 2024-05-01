public class Job
{
    public string _company;
    public string _jobTitle;
    public int _starYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_starYear} - {_endYear}");
    }

    
}


//House johnsonHome = new House();
//johnsonHome._owner = "Johnson Family";
//DisplayJobDetails

/*   // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }*/