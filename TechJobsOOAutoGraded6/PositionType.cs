﻿using System;
using System.CodeDom.Compiler;

namespace TechJobsOOAutoGraded6
{
	public class PositionType
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Done -- Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override string ToString()
        {
            return this.Value;
        }

        public override bool Equals(object? obj)
        {
            return obj is PositionType pos && pos.Id == Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

