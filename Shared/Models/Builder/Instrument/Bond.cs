﻿using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Instrument.Abstract;

namespace Shared.Models.Builder.Instruments
{
    public class Bond : IInstrument
    {
        public string Name { get; set; }
    }
}
