﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex102.Domain.Contracts.Matches
{
    public interface IRegexMatcher
    {
        bool IsMatch(string input, string pattern);
    }
}
