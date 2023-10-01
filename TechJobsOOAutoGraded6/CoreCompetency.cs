using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency
	{
        private int id;
        private static int nextId = 1;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Value { get; set; }

        
        public CoreCompetency()
        {
            id = nextId;
            nextId++;

        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

