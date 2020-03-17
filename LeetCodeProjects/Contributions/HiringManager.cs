using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Contributions
{
    public class HiringManager
    {
        public class Solution
        {
            private List<string> _result;

            public List<string> FindCandidates(List<string> requiredSkills, Dictionary<string, List<string>> candidates)
            {
                if (!requiredSkills.Any() || (requiredSkills.Any() && !candidates.Any()))
                {
                    return new List<string>();
                }

                var skills = new HashSet<string>();
                foreach (var skill in requiredSkills)
                {
                    skills.Add(skill);
                }

                _result = Enumerable.Repeat("dummy_candidate", candidates.Count + 1).ToList();

                Helper(skills, candidates, new HashSet<string>());

                return _result.Count > candidates.Count ? new List<string>() : _result;
            }

            private void Helper(HashSet<string> skills, Dictionary<string, List<string>> candidates, HashSet<string> selected)
            {
                if (selected.Count >= _result.Count)
                {
                    return;
                }

                if (!skills.Any())
                {
                    if (selected.Count < _result.Count)
                    {
                        _result = selected.ToList();
                    }

                    return;
                }

                foreach (var candidate in candidates)
                {
                    if (selected.Contains(candidate.Key))
                    {
                        continue;
                    }

                    var removed = new List<string>();
                    foreach (var skill in candidate.Value)
                    {
                        if (skills.Remove(skill))
                        {
                            removed.Add(skill);
                        }
                    }

                    selected.Add(candidate.Key);
                    Helper(skills, candidates, selected);

                    foreach (var skill in removed)
                    {
                        skills.Add(skill);
                    }

                    selected.Remove(candidate.Key);
                }
            }
        }
    }
}
