﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Car
    {
        public bool isOn { get; set; }

        public void Start()
        {
            isOn = true;
        }
    }

}
