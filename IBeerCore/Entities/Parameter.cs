using System;

namespace IBeerCore.Entities
{
    public class Parameter : Base
    {
        public String Description { get; set; }
        public String Value { get; set; }

        public Parameter SetParameter(string parameter, string value)
        {
            Description = parameter;
            Value = value;
            return this;
        }
        public Parameter SetSequentialId(int id)
        {
            Id = id;
            return this;
        }
    }
}
