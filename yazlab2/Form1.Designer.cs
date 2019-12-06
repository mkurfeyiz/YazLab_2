namespace yazlab2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxThreads = new System.Windows.Forms.GroupBox();
            this.btnSubThreadContinue2 = new System.Windows.Forms.Button();
            this.btnSubThreadWait2 = new System.Windows.Forms.Button();
            this.btnSubThreadStart2 = new System.Windows.Forms.Button();
            this.pbrSubThread2 = new System.Windows.Forms.ProgressBar();
            this.lblSubThread2 = new System.Windows.Forms.Label();
            this.btnSubThreadContinue = new System.Windows.Forms.Button();
            this.btnSubThreadWait = new System.Windows.Forms.Button();
            this.btnSubThreadStart = new System.Windows.Forms.Button();
            this.pbrSubThread = new System.Windows.Forms.ProgressBar();
            this.lblSubThread = new System.Windows.Forms.Label();
            this.btnMainThreadContinue = new System.Windows.Forms.Button();
            this.btnMainThreadWait = new System.Windows.Forms.Button();
            this.btnMainThreadStart = new System.Windows.Forms.Button();
            this.pbrMainThread = new System.Windows.Forms.ProgressBar();
            this.lblMainThread = new System.Windows.Forms.Label();
            this.gbxThInfo = new System.Windows.Forms.GroupBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lblSubThStateValue2 = new System.Windows.Forms.Label();
            this.lblSubThCapacityValue2 = new System.Windows.Forms.Label();
            this.lblSubThNameValue2 = new System.Windows.Forms.Label();
            this.lblSubThState2 = new System.Windows.Forms.Label();
            this.lblSubThCapacity2 = new System.Windows.Forms.Label();
            this.lblSubThName2 = new System.Windows.Forms.Label();
            this.lblSubThStateValue = new System.Windows.Forms.Label();
            this.lblSubThCapacityValue = new System.Windows.Forms.Label();
            this.lblSubThNameValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubThState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubThCapacity = new System.Windows.Forms.Label();
            this.lblSubThName = new System.Windows.Forms.Label();
            this.lblMainThState = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblMainThCapacity = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblMainThName = new System.Windows.Forms.Label();
            this.lblThName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxThreads.SuspendLayout();
            this.gbxThInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxThreads
            // 
            this.gbxThreads.Controls.Add(this.btnSubThreadContinue2);
            this.gbxThreads.Controls.Add(this.btnSubThreadWait2);
            this.gbxThreads.Controls.Add(this.btnSubThreadStart2);
            this.gbxThreads.Controls.Add(this.pbrSubThread2);
            this.gbxThreads.Controls.Add(this.lblSubThread2);
            this.gbxThreads.Controls.Add(this.btnSubThreadContinue);
            this.gbxThreads.Controls.Add(this.btnSubThreadWait);
            this.gbxThreads.Controls.Add(this.btnSubThreadStart);
            this.gbxThreads.Controls.Add(this.pbrSubThread);
            this.gbxThreads.Controls.Add(this.lblSubThread);
            this.gbxThreads.Controls.Add(this.btnMainThreadContinue);
            this.gbxThreads.Controls.Add(this.btnMainThreadWait);
            this.gbxThreads.Controls.Add(this.btnMainThreadStart);
            this.gbxThreads.Controls.Add(this.pbrMainThread);
            this.gbxThreads.Controls.Add(this.lblMainThread);
            this.gbxThreads.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThreads.Location = new System.Drawing.Point(12, 12);
            this.gbxThreads.Name = "gbxThreads";
            this.gbxThreads.Size = new System.Drawing.Size(629, 246);
            this.gbxThreads.TabIndex = 0;
            this.gbxThreads.TabStop = false;
            this.gbxThreads.Text = "Threadlerin Ilerlemesi";
            // 
            // btnSubThreadContinue2
            // 
            this.btnSubThreadContinue2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubThreadContinue2.Location = new System.Drawing.Point(305, 193);
            this.btnSubThreadContinue2.Name = "btnSubThreadContinue2";
            this.btnSubThreadContinue2.Size = new System.Drawing.Size(102, 29);
            this.btnSubThreadContinue2.TabIndex = 14;
            this.btnSubThreadContinue2.Text = "Devam Et";
            this.btnSubThreadContinue2.UseVisualStyleBackColor = true;
            this.btnSubThreadContinue2.Click += new System.EventHandler(this.btnSubThreadContinue2_Click);
            // 
            // btnSubThreadWait2
            // 
            this.btnSubThreadWait2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubThreadWait2.Location = new System.Drawing.Point(198, 193);
            this.btnSubThreadWait2.Name = "btnSubThreadWait2";
            this.btnSubThreadWait2.Size = new System.Drawing.Size(101, 29);
            this.btnSubThreadWait2.TabIndex = 13;
            this.btnSubThreadWait2.Text = "Duraklat";
            this.btnSubThreadWait2.UseVisualStyleBackColor = true;
            this.btnSubThreadWait2.Click += new System.EventHandler(this.btnSubThreadWait2_Click);
            // 
            // btnSubThreadStart2
            // 
            this.btnSubThreadStart2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubThreadStart2.Location = new System.Drawing.Point(117, 193);
            this.btnSubThreadStart2.Name = "btnSubThreadStart2";
            this.btnSubThreadStart2.Size = new System.Drawing.Size(75, 29);
            this.btnSubThreadStart2.TabIndex = 12;
            this.btnSubThreadStart2.Text = "Baslat";
            this.btnSubThreadStart2.UseVisualStyleBackColor = true;
            this.btnSubThreadStart2.Click += new System.EventHandler(this.btnSubThreadStart2_Click);
            // 
            // pbrSubThread2
            // 
            this.pbrSubThread2.Location = new System.Drawing.Point(117, 168);
            this.pbrSubThread2.Name = "pbrSubThread2";
            this.pbrSubThread2.Size = new System.Drawing.Size(463, 19);
            this.pbrSubThread2.TabIndex = 11;
            // 
            // lblSubThread2
            // 
            this.lblSubThread2.AutoSize = true;
            this.lblSubThread2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThread2.Location = new System.Drawing.Point(7, 168);
            this.lblSubThread2.Name = "lblSubThread2";
            this.lblSubThread2.Size = new System.Drawing.Size(104, 19);
            this.lblSubThread2.TabIndex = 10;
            this.lblSubThread2.Text = "2. Alt Thread";
            // 
            // btnSubThreadContinue
            // 
            this.btnSubThreadContinue.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubThreadContinue.Location = new System.Drawing.Point(305, 126);
            this.btnSubThreadContinue.Name = "btnSubThreadContinue";
            this.btnSubThreadContinue.Size = new System.Drawing.Size(102, 29);
            this.btnSubThreadContinue.TabIndex = 9;
            this.btnSubThreadContinue.Text = "Devam Et";
            this.btnSubThreadContinue.UseVisualStyleBackColor = true;
            this.btnSubThreadContinue.Click += new System.EventHandler(this.btnSubThreadContinue_Click);
            // 
            // btnSubThreadWait
            // 
            this.btnSubThreadWait.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubThreadWait.Location = new System.Drawing.Point(198, 126);
            this.btnSubThreadWait.Name = "btnSubThreadWait";
            this.btnSubThreadWait.Size = new System.Drawing.Size(101, 29);
            this.btnSubThreadWait.TabIndex = 8;
            this.btnSubThreadWait.Text = "Duraklat";
            this.btnSubThreadWait.UseVisualStyleBackColor = true;
            this.btnSubThreadWait.Click += new System.EventHandler(this.btnSubThreadWait_Click);
            // 
            // btnSubThreadStart
            // 
            this.btnSubThreadStart.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubThreadStart.Location = new System.Drawing.Point(117, 126);
            this.btnSubThreadStart.Name = "btnSubThreadStart";
            this.btnSubThreadStart.Size = new System.Drawing.Size(75, 29);
            this.btnSubThreadStart.TabIndex = 7;
            this.btnSubThreadStart.Text = "Baslat";
            this.btnSubThreadStart.UseVisualStyleBackColor = true;
            this.btnSubThreadStart.Click += new System.EventHandler(this.btnSubThreadStart_Click);
            // 
            // pbrSubThread
            // 
            this.pbrSubThread.Location = new System.Drawing.Point(117, 101);
            this.pbrSubThread.Name = "pbrSubThread";
            this.pbrSubThread.Size = new System.Drawing.Size(463, 19);
            this.pbrSubThread.TabIndex = 6;
            // 
            // lblSubThread
            // 
            this.lblSubThread.AutoSize = true;
            this.lblSubThread.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThread.Location = new System.Drawing.Point(7, 101);
            this.lblSubThread.Name = "lblSubThread";
            this.lblSubThread.Size = new System.Drawing.Size(86, 19);
            this.lblSubThread.TabIndex = 5;
            this.lblSubThread.Text = "Alt Thread";
            // 
            // btnMainThreadContinue
            // 
            this.btnMainThreadContinue.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainThreadContinue.Location = new System.Drawing.Point(305, 55);
            this.btnMainThreadContinue.Name = "btnMainThreadContinue";
            this.btnMainThreadContinue.Size = new System.Drawing.Size(102, 29);
            this.btnMainThreadContinue.TabIndex = 4;
            this.btnMainThreadContinue.Text = "Devam Et";
            this.btnMainThreadContinue.UseVisualStyleBackColor = true;
            this.btnMainThreadContinue.Click += new System.EventHandler(this.btnMainThreadContinue_Click);
            // 
            // btnMainThreadWait
            // 
            this.btnMainThreadWait.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainThreadWait.Location = new System.Drawing.Point(198, 55);
            this.btnMainThreadWait.Name = "btnMainThreadWait";
            this.btnMainThreadWait.Size = new System.Drawing.Size(101, 29);
            this.btnMainThreadWait.TabIndex = 3;
            this.btnMainThreadWait.Text = "Duraklat";
            this.btnMainThreadWait.UseVisualStyleBackColor = true;
            this.btnMainThreadWait.Click += new System.EventHandler(this.btnMainThreadWait_Click);
            // 
            // btnMainThreadStart
            // 
            this.btnMainThreadStart.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainThreadStart.Location = new System.Drawing.Point(117, 55);
            this.btnMainThreadStart.Name = "btnMainThreadStart";
            this.btnMainThreadStart.Size = new System.Drawing.Size(75, 29);
            this.btnMainThreadStart.TabIndex = 2;
            this.btnMainThreadStart.Text = "Baslat";
            this.btnMainThreadStart.UseVisualStyleBackColor = true;
            this.btnMainThreadStart.Click += new System.EventHandler(this.btnMainThreadStart_Click);
            // 
            // pbrMainThread
            // 
            this.pbrMainThread.Location = new System.Drawing.Point(117, 30);
            this.pbrMainThread.Name = "pbrMainThread";
            this.pbrMainThread.Size = new System.Drawing.Size(463, 19);
            this.pbrMainThread.TabIndex = 1;
            // 
            // lblMainThread
            // 
            this.lblMainThread.AutoSize = true;
            this.lblMainThread.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainThread.Location = new System.Drawing.Point(7, 30);
            this.lblMainThread.Name = "lblMainThread";
            this.lblMainThread.Size = new System.Drawing.Size(95, 19);
            this.lblMainThread.TabIndex = 0;
            this.lblMainThread.Text = "Ana Thread";
            // 
            // gbxThInfo
            // 
            this.gbxThInfo.Controls.Add(this.btnShowInfo);
            this.gbxThInfo.Controls.Add(this.lblSubThStateValue2);
            this.gbxThInfo.Controls.Add(this.lblSubThCapacityValue2);
            this.gbxThInfo.Controls.Add(this.lblSubThNameValue2);
            this.gbxThInfo.Controls.Add(this.lblSubThState2);
            this.gbxThInfo.Controls.Add(this.lblSubThCapacity2);
            this.gbxThInfo.Controls.Add(this.lblSubThName2);
            this.gbxThInfo.Controls.Add(this.lblSubThStateValue);
            this.gbxThInfo.Controls.Add(this.lblSubThCapacityValue);
            this.gbxThInfo.Controls.Add(this.lblSubThNameValue);
            this.gbxThInfo.Controls.Add(this.label4);
            this.gbxThInfo.Controls.Add(this.lblSubThState);
            this.gbxThInfo.Controls.Add(this.label6);
            this.gbxThInfo.Controls.Add(this.lblSubThCapacity);
            this.gbxThInfo.Controls.Add(this.lblSubThName);
            this.gbxThInfo.Controls.Add(this.lblMainThState);
            this.gbxThInfo.Controls.Add(this.lblState);
            this.gbxThInfo.Controls.Add(this.lblMainThCapacity);
            this.gbxThInfo.Controls.Add(this.lblCapacity);
            this.gbxThInfo.Controls.Add(this.lblMainThName);
            this.gbxThInfo.Controls.Add(this.lblThName);
            this.gbxThInfo.Controls.Add(this.label1);
            this.gbxThInfo.Controls.Add(this.label2);
            this.gbxThInfo.Controls.Add(this.label3);
            this.gbxThInfo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThInfo.Location = new System.Drawing.Point(12, 275);
            this.gbxThInfo.Name = "gbxThInfo";
            this.gbxThInfo.Size = new System.Drawing.Size(629, 294);
            this.gbxThInfo.TabIndex = 1;
            this.gbxThInfo.TabStop = false;
            this.gbxThInfo.Text = "Threadlerin Bilgisi";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(509, 258);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(114, 30);
            this.btnShowInfo.TabIndex = 31;
            this.btnShowInfo.Text = "Göster";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lblSubThStateValue2
            // 
            this.lblSubThStateValue2.AutoSize = true;
            this.lblSubThStateValue2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThStateValue2.Location = new System.Drawing.Point(96, 246);
            this.lblSubThStateValue2.Name = "lblSubThStateValue2";
            this.lblSubThStateValue2.Size = new System.Drawing.Size(0, 17);
            this.lblSubThStateValue2.TabIndex = 30;
            // 
            // lblSubThCapacityValue2
            // 
            this.lblSubThCapacityValue2.AutoSize = true;
            this.lblSubThCapacityValue2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThCapacityValue2.Location = new System.Drawing.Point(99, 229);
            this.lblSubThCapacityValue2.Name = "lblSubThCapacityValue2";
            this.lblSubThCapacityValue2.Size = new System.Drawing.Size(0, 17);
            this.lblSubThCapacityValue2.TabIndex = 29;
            // 
            // lblSubThNameValue2
            // 
            this.lblSubThNameValue2.AutoSize = true;
            this.lblSubThNameValue2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThNameValue2.Location = new System.Drawing.Point(117, 212);
            this.lblSubThNameValue2.Name = "lblSubThNameValue2";
            this.lblSubThNameValue2.Size = new System.Drawing.Size(0, 17);
            this.lblSubThNameValue2.TabIndex = 28;
            // 
            // lblSubThState2
            // 
            this.lblSubThState2.AutoSize = true;
            this.lblSubThState2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThState2.Location = new System.Drawing.Point(17, 246);
            this.lblSubThState2.Name = "lblSubThState2";
            this.lblSubThState2.Size = new System.Drawing.Size(73, 17);
            this.lblSubThState2.TabIndex = 27;
            this.lblSubThState2.Text = "Durumu :";
            // 
            // lblSubThCapacity2
            // 
            this.lblSubThCapacity2.AutoSize = true;
            this.lblSubThCapacity2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThCapacity2.Location = new System.Drawing.Point(17, 229);
            this.lblSubThCapacity2.Name = "lblSubThCapacity2";
            this.lblSubThCapacity2.Size = new System.Drawing.Size(76, 17);
            this.lblSubThCapacity2.TabIndex = 26;
            this.lblSubThCapacity2.Text = "Kapasite :";
            // 
            // lblSubThName2
            // 
            this.lblSubThName2.AutoSize = true;
            this.lblSubThName2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThName2.Location = new System.Drawing.Point(17, 212);
            this.lblSubThName2.Name = "lblSubThName2";
            this.lblSubThName2.Size = new System.Drawing.Size(94, 17);
            this.lblSubThName2.TabIndex = 25;
            this.lblSubThName2.Text = "Thread Adı :";
            // 
            // lblSubThStateValue
            // 
            this.lblSubThStateValue.AutoSize = true;
            this.lblSubThStateValue.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThStateValue.Location = new System.Drawing.Point(96, 164);
            this.lblSubThStateValue.Name = "lblSubThStateValue";
            this.lblSubThStateValue.Size = new System.Drawing.Size(0, 17);
            this.lblSubThStateValue.TabIndex = 24;
            // 
            // lblSubThCapacityValue
            // 
            this.lblSubThCapacityValue.AutoSize = true;
            this.lblSubThCapacityValue.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThCapacityValue.Location = new System.Drawing.Point(99, 147);
            this.lblSubThCapacityValue.Name = "lblSubThCapacityValue";
            this.lblSubThCapacityValue.Size = new System.Drawing.Size(0, 17);
            this.lblSubThCapacityValue.TabIndex = 23;
            // 
            // lblSubThNameValue
            // 
            this.lblSubThNameValue.AutoSize = true;
            this.lblSubThNameValue.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThNameValue.Location = new System.Drawing.Point(117, 130);
            this.lblSubThNameValue.Name = "lblSubThNameValue";
            this.lblSubThNameValue.Size = new System.Drawing.Size(0, 17);
            this.lblSubThNameValue.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 21;
            // 
            // lblSubThState
            // 
            this.lblSubThState.AutoSize = true;
            this.lblSubThState.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThState.Location = new System.Drawing.Point(17, 164);
            this.lblSubThState.Name = "lblSubThState";
            this.lblSubThState.Size = new System.Drawing.Size(73, 17);
            this.lblSubThState.TabIndex = 20;
            this.lblSubThState.Text = "Durumu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 19;
            // 
            // lblSubThCapacity
            // 
            this.lblSubThCapacity.AutoSize = true;
            this.lblSubThCapacity.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThCapacity.Location = new System.Drawing.Point(17, 147);
            this.lblSubThCapacity.Name = "lblSubThCapacity";
            this.lblSubThCapacity.Size = new System.Drawing.Size(76, 17);
            this.lblSubThCapacity.TabIndex = 18;
            this.lblSubThCapacity.Text = "Kapasite :";
            // 
            // lblSubThName
            // 
            this.lblSubThName.AutoSize = true;
            this.lblSubThName.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThName.Location = new System.Drawing.Point(17, 130);
            this.lblSubThName.Name = "lblSubThName";
            this.lblSubThName.Size = new System.Drawing.Size(94, 17);
            this.lblSubThName.TabIndex = 17;
            this.lblSubThName.Text = "Thread Adı :";
            // 
            // lblMainThState
            // 
            this.lblMainThState.AutoSize = true;
            this.lblMainThState.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainThState.Location = new System.Drawing.Point(96, 83);
            this.lblMainThState.Name = "lblMainThState";
            this.lblMainThState.Size = new System.Drawing.Size(0, 17);
            this.lblMainThState.TabIndex = 16;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(17, 83);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(73, 17);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "Durumu :";
            // 
            // lblMainThCapacity
            // 
            this.lblMainThCapacity.AutoSize = true;
            this.lblMainThCapacity.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainThCapacity.Location = new System.Drawing.Point(99, 66);
            this.lblMainThCapacity.Name = "lblMainThCapacity";
            this.lblMainThCapacity.Size = new System.Drawing.Size(0, 17);
            this.lblMainThCapacity.TabIndex = 14;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(17, 66);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(76, 17);
            this.lblCapacity.TabIndex = 13;
            this.lblCapacity.Text = "Kapasite :";
            // 
            // lblMainThName
            // 
            this.lblMainThName.AutoSize = true;
            this.lblMainThName.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainThName.Location = new System.Drawing.Point(117, 49);
            this.lblMainThName.Name = "lblMainThName";
            this.lblMainThName.Size = new System.Drawing.Size(0, 17);
            this.lblMainThName.TabIndex = 12;
            // 
            // lblThName
            // 
            this.lblThName.AutoSize = true;
            this.lblThName.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThName.Location = new System.Drawing.Point(17, 49);
            this.lblThName.Name = "lblThName";
            this.lblThName.Size = new System.Drawing.Size(94, 17);
            this.lblThName.TabIndex = 11;
            this.lblThName.Text = "Thread Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "2. Alt Thread";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alt Thread";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ana Thread";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 593);
            this.Controls.Add(this.gbxThInfo);
            this.Controls.Add(this.gbxThreads);
            this.Name = "Form1";
            this.Text = "Sunucu Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxThreads.ResumeLayout(false);
            this.gbxThreads.PerformLayout();
            this.gbxThInfo.ResumeLayout(false);
            this.gbxThInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThreads;
        private System.Windows.Forms.Button btnSubThreadContinue2;
        private System.Windows.Forms.Button btnSubThreadWait2;
        private System.Windows.Forms.Button btnSubThreadStart2;
        private System.Windows.Forms.ProgressBar pbrSubThread2;
        private System.Windows.Forms.Label lblSubThread2;
        private System.Windows.Forms.Button btnSubThreadContinue;
        private System.Windows.Forms.Button btnSubThreadWait;
        private System.Windows.Forms.Button btnSubThreadStart;
        private System.Windows.Forms.ProgressBar pbrSubThread;
        private System.Windows.Forms.Label lblSubThread;
        private System.Windows.Forms.Button btnMainThreadContinue;
        private System.Windows.Forms.Button btnMainThreadWait;
        private System.Windows.Forms.Button btnMainThreadStart;
        private System.Windows.Forms.ProgressBar pbrMainThread;
        private System.Windows.Forms.Label lblMainThread;
        private System.Windows.Forms.GroupBox gbxThInfo;
        private System.Windows.Forms.Label lblMainThCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblMainThName;
        private System.Windows.Forms.Label lblThName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMainThState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSubThStateValue;
        private System.Windows.Forms.Label lblSubThCapacityValue;
        private System.Windows.Forms.Label lblSubThNameValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubThState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubThCapacity;
        private System.Windows.Forms.Label lblSubThName;
        private System.Windows.Forms.Label lblSubThStateValue2;
        private System.Windows.Forms.Label lblSubThCapacityValue2;
        private System.Windows.Forms.Label lblSubThNameValue2;
        private System.Windows.Forms.Label lblSubThState2;
        private System.Windows.Forms.Label lblSubThCapacity2;
        private System.Windows.Forms.Label lblSubThName2;
        private System.Windows.Forms.Button btnShowInfo;
    }
}

