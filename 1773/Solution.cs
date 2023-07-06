﻿namespace _1773;

    public class Solution
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
        int result = 0;
        foreach (var item in items)
        {
            RuleKey key = (RuleKey)Enum.Parse(typeof(RuleKey), ruleKey);
            if (item[(int)key] == ruleValue)
            {
                result++;
            }

        }
        return result;
        }

    enum RuleKey
    {
        type,
        color,
        name
    }
    }
