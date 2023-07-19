using System;
using System.Collections.Generic;
using System.Text;

namespace Project11.Devices {
    internal abstract class Device {

        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);

    }
}
