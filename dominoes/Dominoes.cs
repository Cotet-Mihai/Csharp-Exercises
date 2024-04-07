using System;
using System.Collections.Generic;
using System.Linq;

public class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        // Verificare specială pentru inputuri goale
        if (!dominoes.Any())
            return true;

        var visited = new HashSet<int>();
        var chain = new List<(int, int)>();

        // Helper function to check if the chain is valid
        bool IsValidChain()
        {
            return chain.First().Item1 == chain.Last().Item2;
        }

        // Recursive function to find the chain
        bool FindChain()
        {
            if (chain.Count == dominoes.Count())
                return IsValidChain();

            var lastStone = chain.Last().Item2;
            foreach (var domino in dominoes)
            {
                if (!visited.Contains(Array.IndexOf(dominoes.ToArray(), domino)) && domino.Item1 == lastStone)
                {
                    chain.Add(domino);
                    visited.Add(Array.IndexOf(dominoes.ToArray(), domino));
                    if (FindChain())
                        return true;
                    chain.Remove(domino);
                    visited.Remove(Array.IndexOf(dominoes.ToArray(), domino));
                }
                else if (!visited.Contains(Array.IndexOf(dominoes.ToArray(), domino)) && domino.Item2 == lastStone)
                {
                    chain.Add((domino.Item2, domino.Item1)); // reverse the domino
                    visited.Add(Array.IndexOf(dominoes.ToArray(), domino));
                    if (FindChain())
                        return true;
                    chain.Remove((domino.Item2, domino.Item1));
                    visited.Remove(Array.IndexOf(dominoes.ToArray(), domino));
                }
            }
            return false;
        }

        // Start searching for the chain
        foreach (var domino in dominoes)
        {
            chain.Add(domino);
            visited.Add(Array.IndexOf(dominoes.ToArray(), domino));
            if (FindChain())
                return true;
            chain.Clear();
            visited.Clear();
        }

        return false;
    }
}