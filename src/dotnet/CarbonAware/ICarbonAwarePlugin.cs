﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace CarbonAware
{
    public interface ICarbonAwarePlugin : ICarbonAwareBase, IConfigurable
    {
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
        object URL { get; }

    }
}
