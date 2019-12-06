using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab2
{
    class SubThread : Multithreading
    {
        ProgressBar pbr = new ProgressBar();
        Thread th;
        public SubThread(Thread th,ProgressBar pbr)
        {
            th = new Thread(new ThreadStart(this.Work));
            th.Name = "Sub Thread";
            this.th = th;
            this.pbr = pbr;
        }

        public SubThread(Thread th, ProgressBar pbr,string threadName)
        {
            th = new Thread(new ThreadStart(this.Work));
            th.Name = threadName;
            this.th = th;
            this.pbr = pbr;
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
                while(!kontrol)
                {
                    Thread.Sleep(1000);
                    kontrol = true;
                }
            }
        }

        public override void Work()
        {
            for (int i = 0; i < 5001; i++)
            {
                this.pbr.Value = i / 50;
            }
        }
    }
}
