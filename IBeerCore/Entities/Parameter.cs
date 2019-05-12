using System;

namespace IBeerCore.Entities
{
    public class Parameter : Base
    {
        public String Description { get; private set; }
        public String Value { get; private set; }

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
