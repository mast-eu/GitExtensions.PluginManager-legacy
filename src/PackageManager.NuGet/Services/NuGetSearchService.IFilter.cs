﻿using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Services
{
    partial class NuGetSearchService
    {
        public interface IFilter
        {
            FilterResult IsPassed(IPackageSearchMetadata package);
        }

        public enum FilterResult
        {
            Ok,
            NotPassed,
            TryOlderVersion
        }
    }
}
