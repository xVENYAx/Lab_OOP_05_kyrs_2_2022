
namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ctn_TState = new System.Windows.Forms.Label();
            this.label_ctn_Priority = new System.Windows.Forms.Label();
            this.label_ctn_MTId = new System.Windows.Forms.Label();
            this.label_ctn_IsAlive = new System.Windows.Forms.Label();
            this.label_ctn_Name = new System.Windows.Forms.Label();
            this.button_start_newForm = new System.Windows.Forms.Button();
            this.button_stop_newForm = new System.Windows.Forms.Button();
            this.label_TimeSpan = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.label_value = new System.Windows.Forms.Label();
            this.dateTimePicker_Stop = new System.Windows.Forms.DateTimePicker();
            this.button_value = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_ctn_TState);
            this.groupBox1.Controls.Add(this.label_ctn_Priority);
            this.groupBox1.Controls.Add(this.label_ctn_MTId);
            this.groupBox1.Controls.Add(this.label_ctn_IsAlive);
            this.groupBox1.Controls.Add(this.label_ctn_Name);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Thread";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "ThreadState:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "ManagedThreadld:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "IsAlive:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name:";
            // 
            // label_ctn_TState
            // 
            this.label_ctn_TState.AutoSize = true;
            this.label_ctn_TState.Location = new System.Drawing.Point(142, 103);
            this.label_ctn_TState.Name = "label_ctn_TState";
            this.label_ctn_TState.Size = new System.Drawing.Size(115, 17);
            this.label_ctn_TState.TabIndex = 4;
            this.label_ctn_TState.Text = "label_ctn_TState";
            // 
            // label_ctn_Priority
            // 
            this.label_ctn_Priority.AutoSize = true;
            this.label_ctn_Priority.Location = new System.Drawing.Point(142, 86);
            this.label_ctn_Priority.Name = "label_ctn_Priority";
            this.label_ctn_Priority.Size = new System.Drawing.Size(117, 17);
            this.label_ctn_Priority.TabIndex = 3;
            this.label_ctn_Priority.Text = "label_ctn_Priority";
            // 
            // label_ctn_MTId
            // 
            this.label_ctn_MTId.AutoSize = true;
            this.label_ctn_MTId.Location = new System.Drawing.Point(142, 69);
            this.label_ctn_MTId.Name = "label_ctn_MTId";
            this.label_ctn_MTId.Size = new System.Drawing.Size(104, 17);
            this.label_ctn_MTId.TabIndex = 2;
            this.label_ctn_MTId.Text = "label_ctn_MTId";
            // 
            // label_ctn_IsAlive
            // 
            this.label_ctn_IsAlive.AutoSize = true;
            this.label_ctn_IsAlive.Location = new System.Drawing.Point(142, 52);
            this.label_ctn_IsAlive.Name = "label_ctn_IsAlive";
            this.label_ctn_IsAlive.Size = new System.Drawing.Size(113, 17);
            this.label_ctn_IsAlive.TabIndex = 1;
            this.label_ctn_IsAlive.Text = "label_ctn_IsAlive";
            // 
            // label_ctn_Name
            // 
            this.label_ctn_Name.AutoSize = true;
            this.label_ctn_Name.Location = new System.Drawing.Point(142, 35);
            this.label_ctn_Name.Name = "label_ctn_Name";
            this.label_ctn_Name.Size = new System.Drawing.Size(110, 17);
            this.label_ctn_Name.TabIndex = 0;
            this.label_ctn_Name.Text = "label_ctn_Name";
            // 
            // button_start_newForm
            // 
            this.button_start_newForm.Location = new System.Drawing.Point(312, 21);
            this.button_start_newForm.Name = "button_start_newForm";
            this.button_start_newForm.Size = new System.Drawing.Size(105, 54);
            this.button_start_newForm.TabIndex = 1;
            this.button_start_newForm.Text = "Start new Form";
            this.button_start_newForm.UseVisualStyleBackColor = true;
            this.button_start_newForm.Click += new System.EventHandler(this.button_start_newForm_Click);
            // 
            // button_stop_newForm
            // 
            this.button_stop_newForm.Location = new System.Drawing.Point(312, 81);
            this.button_stop_newForm.Name = "button_stop_newForm";
            this.button_stop_newForm.Size = new System.Drawing.Size(105, 58);
            this.button_stop_newForm.TabIndex = 2;
            this.button_stop_newForm.Text = "Stop new Form";
            this.button_stop_newForm.UseVisualStyleBackColor = true;
            this.button_stop_newForm.Click += new System.EventHandler(this.button_stop_newForm_Click);
            // 
            // label_TimeSpan
            // 
            this.label_TimeSpan.AutoSize = true;
            this.label_TimeSpan.Location = new System.Drawing.Point(19, 207);
            this.label_TimeSpan.Name = "label_TimeSpan";
            this.label_TimeSpan.Size = new System.Drawing.Size(110, 17);
            this.label_TimeSpan.TabIndex = 6;
            this.label_TimeSpan.Text = "label_TimeSpan";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(13, 147);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(94, 22);
            this.dateTimePicker_Start.TabIndex = 7;
            this.dateTimePicker_Start.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(212, 207);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(80, 17);
            this.label_value.TabIndex = 9;
            this.label_value.Text = "label_value";
            // 
            // dateTimePicker_Stop
            // 
            this.dateTimePicker_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Stop.Location = new System.Drawing.Point(13, 176);
            this.dateTimePicker_Stop.Name = "dateTimePicker_Stop";
            this.dateTimePicker_Stop.Size = new System.Drawing.Size(94, 22);
            this.dateTimePicker_Stop.TabIndex = 8;
            this.dateTimePicker_Stop.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // button_value
            // 
            this.button_value.Location = new System.Drawing.Point(312, 149);
            this.button_value.Name = "button_value";
            this.button_value.Size = new System.Drawing.Size(105, 49);
            this.button_value.TabIndex = 10;
            this.button_value.Text = "button1";
            this.button_value.UseVisualStyleBackColor = true;
            this.button_value.Click += new System.EventHandler(this.button_value_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 233);
            this.Controls.Add(this.button_value);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.dateTimePicker_Stop);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.label_TimeSpan);
            this.Controls.Add(this.button_stop_newForm);
            this.Controls.Add(this.button_start_newForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ctn_TState;
        private System.Windows.Forms.Label label_ctn_Priority;
        private System.Windows.Forms.Label label_ctn_MTId;
        private System.Windows.Forms.Label label_ctn_IsAlive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_start_newForm;
        private System.Windows.Forms.Button button_stop_newForm;
        private System.Windows.Forms.Label label_ctn_Name;
        private System.Windows.Forms.Label label_TimeSpan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Stop;
        private System.Windows.Forms.Button button_value;
    }
}

