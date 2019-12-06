using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace yazlab2
{
    abstract class Multithreading 
    {
        public abstract void startTh();
        public abstract void suspendTh(bool kontrol);
        public abstract void resumeTh();
        public abstract void Work();
    }
}
