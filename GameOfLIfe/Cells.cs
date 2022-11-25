public class Cell
    {
        public bool IsAlive;
        public readonly List<Cell> neighbors = new List<Cell>();

        private bool IsAliveNext;
        public void DetermineNextLiveState()
        {
            //live cells with less than two live neighbors die
            //live cells with more than three live neighbors die
            //dead cells with three live neighbors come alive

            int liveNeighbors = neighbors.Where(x => x.IsAlive).Count();

            if(IsAlive)
            {
                IsAliveNext = liveNeighbors == 2 || liveNeighbors == 3;
            }
            else
            {
                IsAlive = liveNeighbors == 3;
            }
        }

        public void Advance()
        {
            IsAlive = IsAliveNext;
        }
    }