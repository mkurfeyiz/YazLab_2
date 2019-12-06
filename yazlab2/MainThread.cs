using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab2
{
    class MainThread : Multithreading
    {
        ProgressBar pbr=new ProgressBar();
        Thread th;
        public MainThread(Thread th, ProgressBar pbr)
        {
            th = new Thread(new ThreadStart(this.Work));
            th.Name = "Main Thread";
            this.th = th;
            this.pbr = pbr;
        }

        public override void resumeTh()
        {
            this.th.Interrupt();
        }

        public override void startTh()
        {
            this.th.Start();
        }

        public override void suspendTh(bool kontrol)
        {
            lock (this.th)
            {
                while (!kontrol)
                {
                    Thread.Sleep(1000);
                    kontrol = true;
                }
            }
        }

        public ThreadState getThreadState()
        {
            var threadState = this.th.ThreadState;
            return threadState;
        }

        public string getThreadName()
        {
            return this.th.Name;
        }

        public override void Work()
        {
            for (int i = 0; i < 10001; i++)
            {
                this.pbr.Value = i / 100;
            }
        }
    }
}
