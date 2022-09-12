using System.Text;

Console.WriteLine("--> Program Started...");

namespace StringSortingApp
{
    public class StringManipulation
    {
        public static string SortingOperations(object[] args)
        {
            var n = (int)args.FirstOrDefault();
            var strings = Array.ConvertAll(args.Skip(1).ToArray(), x => x.ToString());
            var sbOrderedRepeatedChars = new StringBuilder();
            var sbOrderedNonRepeatedChars = new StringBuilder();
            var charFrequency = new Dictionary<char, int>();
            var results = new string[n];

            if (strings.Length == 0 || n == 0)
            {
                return string.Empty;
            }
            else
            {
                for (var i = 0; i < n; i++)
                {
                    var orderedString = strings[i].OrderBy(x => x).ToArray();

                    foreach (var stringChar in orderedString)
                    {
                        if (charFrequency.ContainsKey(stringChar))
                        {
                            charFrequency[stringChar]++;
                        }
                        else
                        {
                            charFrequency[stringChar] = 1;
                        }
                    }

                    foreach (var charCount in charFrequency.OrderByDescending(cf => cf.Value).ToDictionary(cf => cf.Key, cf => cf.Value))
                    {
                        if (charCount.Value > 1)
                        {
                            for (int j = 0; j < charCount.Value; j++)
                            {
                                sbOrderedRepeatedChars.Append(charCount.Key);
                            }
                        }
                        else
                        {
                            sbOrderedNonRepeatedChars.Append(charCount.Key);
                        }
                    }

                    results[i] = string.Concat(sbOrderedRepeatedChars.ToString(), string.Concat(sbOrderedNonRepeatedChars.ToString().OrderBy(x => x)));
                    sbOrderedRepeatedChars.Clear();
                    sbOrderedNonRepeatedChars.Clear();
                    charFrequency.Clear();
                }

                return string.Join('\n', results);
            }
        }
    }
}