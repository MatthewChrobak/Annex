﻿using System;
using System.Diagnostics;

namespace Annex.Data.Shared
{
    [Serializable]
    [DebuggerDisplay("{Value}")]
    public class Int : Shared<int>
    {
        public Int() {

        }

        public Int(int value) : base(value) {

        }

        public static implicit operator Int(int value) {
            return new Int(value);
        }

        public static implicit operator int(Int instance) {
            return instance.Value;
        }
    }
}
