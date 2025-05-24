using System;

namespace LIB_BLL
{
    internal class BLL_Inventaire
    {
        private int _depotNum;
        private string _articleRef;
        private decimal _invQte;

        // Constants for string lengths
        private const int MaxArticleRefLength = 20;

        public BLL_Inventaire(int depotNum, string articleRef, decimal invQte = 0)
        {
            // Assign depotNum
            _depotNum = depotNum;

            // Validate and assign articleRef
            if (articleRef.Length > MaxArticleRefLength)
                throw new ArgumentException($"Article reference cannot be longer than {MaxArticleRefLength} characters.", nameof(articleRef));
            _articleRef = articleRef;

            // Assign invQte with a default value of 0 if not provided
            _invQte = invQte;
        }

        public int DepotNum
        {
            get { return _depotNum; }
            set { _depotNum = value; }
        }

        public string ArticleRef
        {
            get { return _articleRef; }
            set
            {
                if (value.Length > MaxArticleRefLength)
                    throw new ArgumentException($"Article reference cannot be longer than {MaxArticleRefLength} characters.", nameof(value));
                _articleRef = value;
            }
        }

        public decimal InvQte
        {
            get { return _invQte; }
            set { _invQte = value; }
        }
    }
}
