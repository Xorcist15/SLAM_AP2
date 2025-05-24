using System;

namespace LIB_BLL
{
    internal class BLL_Type
    {
        private string _id;
        private string _description;

        // Constants for character limits
        private const int MaxIdLength = 3;
        private const int MaxDescriptionLength = 50;

        public BLL_Type(string id, string description)
        {
            // Validate and assign the id
            if (id.Length > MaxIdLength)
                throw new ArgumentException($"ID cannot be longer than {MaxIdLength} characters.", nameof(id));
            _id = id;

            // Validate and assign the description
            if (description.Length > MaxDescriptionLength)
                throw new ArgumentException($"Description cannot be longer than {MaxDescriptionLength} characters.", nameof(description));
            _description = description;
        }

        public string Id
        {
            get { return _id; }
            set
            {
                if (value.Length > MaxIdLength)
                    throw new ArgumentException($"ID cannot be longer than {MaxIdLength} characters.", nameof(value));
                _id = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value.Length > MaxDescriptionLength)
                    throw new ArgumentException($"Description cannot be longer than {MaxDescriptionLength} characters.", nameof(value));
                _description = value;
            }
        }
    }
}

