﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTFClassLibrary
{
    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
