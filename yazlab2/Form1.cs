using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
/* Bu program calistiginda 1 i main 2 si sub olmak uzere 3 adet thread olmalı.
 * 1- Main Thread:
 * Main thread 10.000 istek kapasitesine sahip olmali.500ms lik delay ile 1-100 arasinda istek kabul etmelidir.200 ms aralikla da 1-50 arasinda isteklere cevap vermelidir.
 * 2- Sub Threadler:
 * 5000 kapasite,500 ms aralıkla 1-50 arasi istek kabulu,300 ms aralikla 1-50 arasi istege cevap(1-50 arasindan rastgele sayi secilmeli random classi)
 * Sub Thread Olusturucu:
 * Herhangi bir sub thread %70 oraninda dolarsa yeni bir sub thread olusturur.Herhangi bir sub thread %0 olursa onu kaldirir.Aktif olarak en az 2 sub thread olmali.
 * Thread Takibi:
 * Sistemdeki tum sunucularin bilgilerini gosterir.
 */
namespace yazlab2
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        Thread _mainTh;
        Thread _subTh,_subTh2;
        MainThread _mainThread;
        SubThread _subThread,_subThread2;
        bool _kontrol=true;
        //int mainRequest = _random.Next(1, 101);//1-100 arasi sayi uretir.
        //int subRequest = _random.Next(1, 51);//1-50
        //int response = _random.Next(1, 51);//1-50
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//Bunun degeri true oldugunda ayni anda iki threadin calismasina izin verilmez.Yapilan kontrolu engellemek ve
            //programa multithreading yaptigimizi belirtmek icin bunu yazdik.
        }
        //public void mainThLoop()
        //{
        //    //for (int i = 0; i < 100001; i++)
        //    //{
        //    //    for (int j = 0; j < 100001; j++)
        //    //    {
        //    //        if (_kontrol == true)
        //    //        {
        //    //            pbrMainThread.Value = j / 1000;
        //    //        }
        //    //        else
        //    //        {
        //    //            continue;
        //    //        }
        //    //    }
        //    //}
        //    //for (int i = 0; i < 1000001; i++)
        //    //{
        //    //    pbrMainThread.Value = i / 10000;     
        //    //}
        //    int i = 0;
        //    while(_kontrol && i<10000001)
        //    {
        //        if (_kontrol == true)
        //        {
        //            pbrMainThread.Value = i / 100000;
        //            i++;
        //        }
        //        else
        //        {
        //            continue;
        //        }
                
        //    }
        //}
        //public void subThLoop()
        //{
        //    //for (int i = 0; i < 5001; i++)
        //    //{
        //    //    pbrSubThread.Value = i / 50;
        //    //}
        //    int i = 0;
        //    while(_kontrol && i<50000001)
        //    {
        //        pbrSubThread.Value = i / 500000;
        //        i++;
        //    }
        //}
        //public void subThLoop2()
        //{
        //    //for (int i = 0; i < 5001; i++)
        //    //{
        //    //    pbrSubThread.Value = i / 50;
        //    //}
        //    int i = 0;
        //    while (_kontrol && i < 50000001)
        //    {
        //        pbrSubThread2.Value = i / 500000;
        //        i++;
        //    }
        //}
        //Thread olusumlari
        public void createMainThread()
        {
            //_mainTh = new Thread(mainThLoop);
            //_mainThread = new MainThread(_mainTh, pbrMainThread);
            _mainTh.Name = "Main Thread";
        }

        public void createSubThreads()
        {
            //_subTh = new Thread(subThLoop);
            ////_subThread = new SubThread(_subTh, pbrSubThread);
            //_subTh.Name = "1. Sub Thread";
            ////subThState = _subTh.ThreadState;
            //_subTh2 = new Thread(subThLoop2);
            //_subTh2.Name = "2. Sub Thread";
        }
        //

        private void Form1_Load(object sender, EventArgs e)
        {
            //createMainThread();
            //_mainThread = new MainThread(_mainTh, pbrMainThread);
            //createSubThreads();
            _mainThread = new MainThread(_mainTh,pbrMainThread);
            _subThread = new SubThread(_subTh, pbrSubThread);
            _subThread2 = new SubThread(_subTh2, pbrSubThread2,"Sub Thread 2");
        }

        private void btnMainThreadStart_Click(object sender, EventArgs e)
        {
            //_mainTh.Start();
            //_mainThread.startTh();
            _mainThread.startTh();
        }

        private void btnSubThreadStart_Click(object sender, EventArgs e)
        {
            _subThread.startTh();
            //_subThread.startTh();
        }

        private void btnMainThreadWait_Click(object sender, EventArgs e)
        {
            //if(_mainTh !=null && _kontrol == true)
            //{
            //    _kontrol = false;
            //}
            _kontrol = false;
            _mainThread.suspendTh(_kontrol);
        }

        private void btnSubThreadWait_Click(object sender, EventArgs e)
        {
            //if (_subTh != null )
            //{
            //    //_kontrol=false;
            //}
            _kontrol = false;
            _subThread.suspendTh(_kontrol);
        }

        private void btnSubThreadWait2_Click(object sender, EventArgs e)
        {
            //_subTh listini olusturduktan sonra suspend kullan
            _kontrol = false;
            _subThread2.suspendTh(_kontrol);
        }

        private void btnMainThreadContinue_Click(object sender, EventArgs e)
        {
            //if (_kontrol != true && _mainTh!=null)
            //{
            //    _kontrol = true;
            //}
            //MessageBox.Show(_kontrol.ToString());
            _mainThread.resumeTh();
        }

        private void btnSubThreadContinue_Click(object sender, EventArgs e)
        {
            //if (_subTh != null && _kontrol == false)
            //{
            //    _kontrol = true;
            //}
            _subThread.resumeTh();
        }

        private void btnSubThreadContinue2_Click(object sender, EventArgs e)
        {
            //Yukaridakilerin aynisini yap
            _subThread2.resumeTh();
        }

        private void btnSubThreadStart2_Click(object sender, EventArgs e)
        {
            _subThread2.startTh();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //main thread
                lblMainThName.Text = _mainThread.getThreadName();
                lblMainThCapacity.Text = pbrMainThread.Value.ToString();
                //var mainThState = _mainTh.ThreadState;
                lblMainThState.Text = _mainThread.getThreadState().ToString();
                //sub thread
                lblSubThNameValue.Text = _subThread.getThreadName();
                lblSubThCapacityValue.Text = pbrSubThread.Value.ToString();
                //var subThState1 = _subTh.ThreadState;
                lblSubThStateValue.Text = _subThread.getThreadState().ToString();
                //2. sub thread
                lblSubThNameValue2.Text = _subThread2.getThreadName();
                lblSubThCapacityValue2.Text = pbrSubThread2.Value.ToString();
                //var subThState2 = _subTh.ThreadState;
                lblSubThStateValue2.Text = _subThread2.getThreadState().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Threadlerden herhangi birnin herhangi bir değeri null olduğundan bilgiler gözükmemektedir.");
            }
        }
    }
}
