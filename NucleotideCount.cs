using System;
using System.Collections.Generic;

public static class NucleotideCount
{      
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotides = new Dictionary<char, int>
        {
            {'A', 0 }, {'C', 0 }, {'G', 0 }, {'T', 0 }
        }; 

        foreach(char nucleotide in sequence)
        {
            AddNucleotideToDict(nucleotide, nucleotides);   
        }
        return nucleotides;
    }

    private static void AddNucleotideToDict(char c, Dictionary<char, int> nucleotides)
    {
        if (nucleotides.ContainsKey(c))
        {
            nucleotides[c]++;
        }
        else
        {
            throw new System.ArgumentException($"Nucleotide {c} does not exist");
        }
    }
}