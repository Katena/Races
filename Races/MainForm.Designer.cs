namespace Races
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.start_btn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pause_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fifth_car_btn = new Races.ButtonCompare();
            this.fourth_car_btn = new Races.ButtonCompare();
            this.third_car_btn = new Races.ButtonCompare();
            this.second_car_btn = new Races.ButtonCompare();
            this.first_car_btn = new Races.ButtonCompare();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(23, 28);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(94, 26);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(161, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 26);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // stop_btn
            // 
            this.stop_btn.Enabled = false;
            this.stop_btn.Location = new System.Drawing.Point(296, 28);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(94, 26);
            this.stop_btn.TabIndex = 9;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stop_btn);
            this.groupBox1.Controls.Add(this.pause_btn);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.start_btn);
            this.groupBox1.Location = new System.Drawing.Point(162, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pause_btn
            // 
            this.pause_btn.Enabled = false;
            this.pause_btn.Location = new System.Drawing.Point(161, 28);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(94, 26);
            this.pause_btn.TabIndex = 8;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Races.Properties.Resources.finish_line;
            this.pictureBox1.Location = new System.Drawing.Point(661, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // fifth_car_btn
            // 
            this.fifth_car_btn.Image = global::Races.Properties.Resources.car05;
            this.fifth_car_btn.Location = new System.Drawing.Point(12, 234);
            this.fifth_car_btn.Name = "fifth_car_btn";
            this.fifth_car_btn.Size = new System.Drawing.Size(94, 50);
            this.fifth_car_btn.TabIndex = 11;
            this.fifth_car_btn.UseVisualStyleBackColor = true;
            // 
            // fourth_car_btn
            // 
            this.fourth_car_btn.Image = global::Races.Properties.Resources.car04;
            this.fourth_car_btn.Location = new System.Drawing.Point(12, 178);
            this.fourth_car_btn.Name = "fourth_car_btn";
            this.fourth_car_btn.Size = new System.Drawing.Size(94, 50);
            this.fourth_car_btn.TabIndex = 5;
            this.fourth_car_btn.UseVisualStyleBackColor = true;
            // 
            // third_car_btn
            // 
            this.third_car_btn.Image = global::Races.Properties.Resources.car03;
            this.third_car_btn.Location = new System.Drawing.Point(12, 122);
            this.third_car_btn.Name = "third_car_btn";
            this.third_car_btn.Size = new System.Drawing.Size(94, 50);
            this.third_car_btn.TabIndex = 4;
            this.third_car_btn.UseVisualStyleBackColor = true;
            // 
            // second_car_btn
            // 
            this.second_car_btn.Image = global::Races.Properties.Resources.car02;
            this.second_car_btn.Location = new System.Drawing.Point(12, 68);
            this.second_car_btn.Name = "second_car_btn";
            this.second_car_btn.Size = new System.Drawing.Size(94, 50);
            this.second_car_btn.TabIndex = 3;
            this.second_car_btn.UseVisualStyleBackColor = true;
            // 
            // first_car_btn
            // 
            this.first_car_btn.Image = global::Races.Properties.Resources.car01;
            this.first_car_btn.Location = new System.Drawing.Point(12, 12);
            this.first_car_btn.Name = "first_car_btn";
            this.first_car_btn.Size = new System.Drawing.Size(94, 50);
            this.first_car_btn.TabIndex = 2;
            this.first_car_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fifth_car_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fourth_car_btn);
            this.Controls.Add(this.third_car_btn);
            this.Controls.Add(this.second_car_btn);
            this.Controls.Add(this.first_car_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Races";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonCompare first_car_btn;
        private ButtonCompare second_car_btn;
        private ButtonCompare third_car_btn;
        private ButtonCompare fourth_car_btn;
        private ButtonCompare fifth_car_btn;

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

