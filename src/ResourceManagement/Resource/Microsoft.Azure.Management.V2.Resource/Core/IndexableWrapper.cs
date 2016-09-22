﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.V2.Resource.Core
{
    public class IndexableWrapper<InnerT> :
        Indexable,
        IWrapper<InnerT>

    {
        protected IndexableWrapper(String name, InnerT innerObject) : base(name)
        {
            Inner = innerObject;
        }

        public InnerT Inner
        {
            get; private set;
            
        }
    }
}