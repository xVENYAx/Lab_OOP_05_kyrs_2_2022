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

namespace Lab5
{
    public partial class Form1 : Form
    {
        List<Thread> myThreadsList = new List<Thread>();
        static string[] student_names = { "1", "2", "3", "4"};
        int students_count = student_names.Length;
        
        public Form1()
        {
            InitializeComponent();

            this.dateTimePicker_Start.Value = DateTime.Now;
            for (int a = 0; a < 100001; a++)
            {
                this.label_value.Text = a.ToString();
                if (a == 100000)
                {
                    this.dateTimePicker_Stop.Value = DateTime.Now;
                }
            }
            TimeSpan myTime = this.dateTimePicker_Stop.Value - this.dateTimePicker_Start.Value;
            this.label_TimeSpan.Text = myTime.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Control.CheckForIllegalCrossThreadCalls = false; // вимикаємо перевірку в Debug
            Thread currentThread = Thread.CurrentThread;
            this.Text = "Form" + currentThread.ManagedThreadId.ToString();
            //currentThread.Name = "1";

            label_ctn_Name.Text = currentThread.Name;
            label_ctn_IsAlive.Text = currentThread.IsAlive.ToString();
            label_ctn_MTId.Text = currentThread.ManagedThreadId.ToString();
            label_ctn_Priority.Text = currentThread.Priority.ToString();
            label_ctn_TState.Text = currentThread.ThreadState.ToString();
        }

        void show_new_Form()
        {
            Application.Run(new Form1());

        }
        
        private void button_start_newForm_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < students_count; i++)
            {
                Thread myThread = new Thread(show_new_Form);
                myThreadsList.Add(myThread);
                myThread.Start();
            }
        }


        private void button_stop_newForm_Click(object sender, EventArgs e)
        {
            if (myThreadsList.Count == 0)
            {
                return;
            }
            Thread myThread = myThreadsList.Last();
            myThread.Abort();
            myThreadsList.Remove(myThread);
        }

        private void button_value_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_Start.Value = DateTime.Now;
            for (int a = 0; a<100001; a++) 
            {
                this.label_value.Text = a.ToString();
                if (a == 100000) 
                {
                    
                    this.dateTimePicker_Stop.Value = DateTime.Now;
                }
            }
            TimeSpan myTime = this.dateTimePicker_Stop.Value - this.dateTimePicker_Start.Value;
            this.label_TimeSpan.Text = myTime.ToString();
        }
    }
}
