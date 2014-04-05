namespace RockPaperScissors
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paperstd = new System.Windows.Forms.Button();
            this.scissorsstd = new System.Windows.Forms.Button();
            this.rockstd = new System.Windows.Forms.Button();
            this.countstd = new System.Windows.Forms.Label();
            this.labelcountstd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 227);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.info);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.paperstd);
            this.tabPage1.Controls.Add(this.scissorsstd);
            this.tabPage1.Controls.Add(this.rockstd);
            this.tabPage1.Controls.Add(this.countstd);
            this.tabPage1.Controls.Add(this.labelcountstd);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(890, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стандартная игра";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(7, 462);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(345, 32);
            this.info.TabIndex = 6;
            this.info.Text = "Нажмите кнопку, чтобы начать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(640, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "???";
            // 
            // paperstd
            // 
            this.paperstd.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paperstd.Location = new System.Drawing.Point(13, 327);
            this.paperstd.Name = "paperstd";
            this.paperstd.Size = new System.Drawing.Size(260, 95);
            this.paperstd.TabIndex = 4;
            this.paperstd.Text = "Бумага!";
            this.paperstd.UseVisualStyleBackColor = true;
            this.paperstd.Click += new System.EventHandler(this.paperstd_Click);
            // 
            // scissorsstd
            // 
            this.scissorsstd.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scissorsstd.Location = new System.Drawing.Point(13, 226);
            this.scissorsstd.Name = "scissorsstd";
            this.scissorsstd.Size = new System.Drawing.Size(260, 95);
            this.scissorsstd.TabIndex = 3;
            this.scissorsstd.Text = "Ножницы!";
            this.scissorsstd.UseVisualStyleBackColor = true;
            this.scissorsstd.Click += new System.EventHandler(this.scissorsstd_Click);
            // 
            // rockstd
            // 
            this.rockstd.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rockstd.Location = new System.Drawing.Point(13, 125);
            this.rockstd.Name = "rockstd";
            this.rockstd.Size = new System.Drawing.Size(260, 95);
            this.rockstd.TabIndex = 2;
            this.rockstd.Text = "Камень!";
            this.rockstd.UseVisualStyleBackColor = true;
            this.rockstd.Click += new System.EventHandler(this.rockstd_Click);
            // 
            // countstd
            // 
            this.countstd.AutoSize = true;
            this.countstd.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countstd.Location = new System.Drawing.Point(7, 30);
            this.countstd.Name = "countstd";
            this.countstd.Size = new System.Drawing.Size(27, 32);
            this.countstd.TabIndex = 1;
            this.countstd.Text = "0";
            // 
            // labelcountstd
            // 
            this.labelcountstd.AutoSize = true;
            this.labelcountstd.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcountstd.Location = new System.Drawing.Point(7, 5);
            this.labelcountstd.Name = "labelcountstd";
            this.labelcountstd.Size = new System.Drawing.Size(51, 25);
            this.labelcountstd.TabIndex = 0;
            this.labelcountstd.Text = "Счет";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(890, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "...Ящерица, Спок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "RockPaperScissors";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 802);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "RockPaperScissors";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paperstd;
        private System.Windows.Forms.Button scissorsstd;
        private System.Windows.Forms.Button rockstd;
        private System.Windows.Forms.Label countstd;
        private System.Windows.Forms.Label labelcountstd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer;
    }
}

