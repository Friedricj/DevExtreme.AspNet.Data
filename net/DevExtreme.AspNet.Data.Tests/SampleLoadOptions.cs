﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data.Tests {

    class SampleLoadOptions : DataSourceLoadOptionsBase {

        public SampleLoadOptions() {
            UseQueryableOnce = true;
        }

    }

}
