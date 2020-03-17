namespace LeetCodeProjects.Contributions
{
    public class CountingValleys
    {
        public int CountValleys(string path)
        {
            if (path == null || path.Length <= 0)
            {
                return 0;
            }

            var altitudeMeter = 0;
            var valleyCounter = 0;
            
            foreach (var c in path)
            {
                if (c == 'U')
                {
                    altitudeMeter++;
                    if (altitudeMeter == 0)
                    {
                        valleyCounter++;
                    }
                }
                else
                {
                    altitudeMeter--;
                }
            }

            return valleyCounter;
        }
    }
}
