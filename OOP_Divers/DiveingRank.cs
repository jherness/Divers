namespace Ex_Divers_OPP_17_12_21
{
    class DiveingRank
    {
        protected int rank;

        public DiveingRank(int rank)
        {
            SetRank(rank);
        }

        public int GetRank() { return rank; }

        public void SetRank(int rank) { this.rank = rank; }

        public override string ToString()
        {
            return $"{rank}";
        }
    }
}
