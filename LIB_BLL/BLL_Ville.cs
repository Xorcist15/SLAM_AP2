using System;

namespace LIB_BLL
{
    internal class BLL_Ville
    {
        private string _villeNom;
        private string _paysNom;

        // Constants for character limits
        private const int MaxVilleNomLength = 50;
        private const int MaxPaysNomLength = 50;

        public BLL_Ville(string villeNom, string paysNom)
        {
            // Validate and assign the villeNom
            if (villeNom.Length > MaxVilleNomLength)
                throw new ArgumentException($"City name cannot be longer than {MaxVilleNomLength} characters.", nameof(villeNom));
            _villeNom = villeNom;

            // Validate and assign the paysNom
            if (paysNom.Length > MaxPaysNomLength)
                throw new ArgumentException($"Country name cannot be longer than {MaxPaysNomLength} characters.", nameof(paysNom));
            _paysNom = paysNom;
        }

        public string VilleNom
        {
            get { return _villeNom; }
            set
            {
                if (value.Length > MaxVilleNomLength)
                    throw new ArgumentException($"City name cannot be longer than {MaxVilleNomLength} characters.", nameof(value));
                _villeNom = value;
            }
        }

        public string PaysNom
        {
            get { return _paysNom; }
            set
            {
                if (value.Length > MaxPaysNomLength)
                    throw new ArgumentException($"Country name cannot be longer than {MaxPaysNomLength} characters.", nameof(value));
                _paysNom = value;
            }
        }
    }
}
