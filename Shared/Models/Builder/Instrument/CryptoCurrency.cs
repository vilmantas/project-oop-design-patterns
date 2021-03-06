﻿using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Builder.Instrument.Abstract;

namespace Shared.Models.Builder.Instruments
{
    public class CryptoCurrency : IInstrument
    {
        public string Name { get; set; }

        public CryptoCurrency()
        {

        }

        public CryptoCurrency(CryptoCurrency self)
        {
        }

        public IInstrument Clone()
        {
            return new CryptoCurrency(this);
        }

        public void Initialize()
        {
            Name = "Crypto instrument";
        }
    }
}
