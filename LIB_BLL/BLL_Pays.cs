using System;

namespace LIB_BLL
{
    internal class BLL_Pays
    {
        private string _nom;

        // Constant for character limit
        private const int MaxNomLength = 50;

        public BLL_Pays(string nom)
        {
            // Validate and assign the nom
            if (nom.Length > MaxNomLength)
                throw new ArgumentException($"Nom cannot be longer than {MaxNomLength} characters.", nameof(nom));
            _nom = nom;
        }

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (value.Length > MaxNomLength)
                    throw new ArgumentException($"Nom cannot be longer than {MaxNomLength} characters.", nameof(value));
                _nom = value;
            }
        }
    }
}

