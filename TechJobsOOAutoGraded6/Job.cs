using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        public override bool Equals(object obj)
        {
            return obj is Job name &&
                   Id == name.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {

            string JobFields = Environment.NewLine + "" + Environment.NewLine;

            if (Name == "" || Name == null)
            {
                Name  = "Data not available";
            }
            else
            {
                JobFields += "Name: " + Name;
            }
            if (EmployerName == null)
            {
                EmployerName.Value = "Data not available";
            }
            else
            {
                JobFields += "Employer: " + EmployerName;
            }
            if (EmployerLocation == null)
            {
               EmployerLocation.Value = "Data not available";
            }
            else
            {
                JobFields += "Location: " + EmployerLocation;
            }
            if (JobType == null)
            {
                JobType.Value = "Data not available";
            }
            else
            {
                JobFields += "Position Type: " + JobType;
            }
            if (JobCoreCompetency == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }
            else
            {
                JobFields += "Core Competency: " + JobCoreCompetency;
            }
            
             JobFields = Environment.NewLine + "ID: " + Id + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Employer: " + EmployerName.Value + Environment.NewLine + "Location: " + EmployerLocation.Value + Environment.NewLine + "Position Type: " + JobType.Value + Environment.NewLine + "Core Competency: " + JobCoreCompetency.Value + Environment.NewLine;

            return JobFields;
        }
    }
}





// TODO: Task 3: Generate Equals() and GetHashCode() methods.  

// TODO: Task 5: Generate custom ToString() method.
//Until you create this method, you will not be able to print a job to the console.






