using System;

namespace LIB_BLL
{
    internal class BLL_MvtStock
    {
        private int _mvtId;
        private DateTime _mvtDateHeure;
        private decimal _mvtQte;
        private string _typeId;
        private string _articleRef;
        private int _depotNum;

        // Constants for string lengths
        private const int MaxTypeIdLength = 3;
        private const int MaxArticleRefLength = 20;

        public BLL_MvtStock(int mvtId, DateTime mvtDateHeure, decimal mvtQte, string typeId, string articleRef, int depotNum)
        {
            // Assign mvtId (no length limit as it's an identity field)
            _mvtId = mvtId;

            // Assign mvtDateHeure
            _mvtDateHeure = mvtDateHeure;

            // Assign mvtQte
            _mvtQte = mvtQte;

            // Validate and assign typeId
            if (typeId.Length > MaxTypeIdLength)
                throw new ArgumentException($"Type ID cannot be longer than {MaxTypeIdLength} characters.", nameof(typeId));
            _typeId = typeId;

            // Validate and assign articleRef
            if (articleRef.Length > MaxArticleRefLength)
                throw new ArgumentException($"Article reference cannot be longer than {MaxArticleRefLength} characters.", nameof(articleRef));
            _articleRef = articleRef;

            // Assign depotNum
            _depotNum = depotNum;
        }

        public int MvtId
        {
            get { return _mvtId; }
            set { _mvtId = value; }
        }

        public DateTime MvtDateHeure
        {
            get { return _mvtDateHeure; }
            set { _mvtDateHeure = value; }
        }

        public decimal MvtQte
        {
            get { return _mvtQte; }
            set { _mvtQte = value; }
        }

        public string TypeId
        {
            get { return _typeId; }
            set
            {
                if (value.Length > MaxTypeIdLength)
                    throw new ArgumentException($"Type ID cannot be longer than {MaxTypeIdLength} characters.", nameof(value));
                _typeId = value;
            }
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

        public int DepotNum
        {
            get { return _depotNum; }
            set { _depotNum = value; }
        }
    }
}
