using System;
using System.Text;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        public int Id { get; private set; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
            
            
        // TODO: Done -- Task 3: Add the two necessary constructors.
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

        // TODO: Done -- Task 3: Generate Equals() and GetHashCode() methods.  

        public override bool Equals(object? obj)
        {
            return obj is Job job && job.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        private string GetValidString(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return "Data not available";
            }
            else
            {
                return s;
            }
        }


        // TODO: Task 5: Generate custom ToString() method.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine($"ID: {Id}");
            sb.AppendLine($"Name: {GetValidString(Name)}");
            sb.AppendLine($"Employer: {GetValidString(EmployerName.ToString())}");
            sb.AppendLine($"Location: {GetValidString(EmployerLocation.ToString())}");
            sb.AppendLine($"Position Type: {GetValidString(JobType.ToString())}");
            sb.AppendLine($"Core Competency: {GetValidString(JobCoreCompetency.ToString())}");

            return sb.ToString();

        }



    }
}

