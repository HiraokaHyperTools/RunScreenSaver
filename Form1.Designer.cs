namespace RunScreenSaver
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.screenSavers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.testStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.waitLabel = new System.Windows.Forms.Label();
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timerAutoHide = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RunScreenSaver";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.screenSavers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "スクリーンセーバーを選択";
            // 
            // screenSavers
            // 
            this.screenSavers.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RunScreenSaver.Properties.Settings.Default, "SelectedScreenSaver", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.screenSavers.FormattingEnabled = true;
            this.screenSavers.Location = new System.Drawing.Point(6, 28);
            this.screenSavers.Name = "screenSavers";
            this.screenSavers.Size = new System.Drawing.Size(292, 29);
            this.screenSavers.TabIndex = 1;
            this.screenSavers.Text = global::RunScreenSaver.Properties.Settings.Default.SelectedScreenSaver;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waitLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "起動するまでの時間";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "分";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::RunScreenSaver.Properties.Settings.Default, "WaitMinutes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(6, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 29);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = global::RunScreenSaver.Properties.Settings.Default.WaitMinutes;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Location = new System.Drawing.Point(12, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(74, 42);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timerWait
            // 
            this.timerWait.Enabled = true;
            this.timerWait.Interval = 15000;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // testStart
            // 
            this.testStart.AutoSize = true;
            this.testStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testStart.Location = new System.Drawing.Point(118, 182);
            this.testStart.Name = "testStart";
            this.testStart.Padding = new System.Windows.Forms.Padding(5);
            this.testStart.Size = new System.Drawing.Size(112, 42);
            this.testStart.TabIndex = 3;
            this.testStart.Text = "試し起動";
            this.testStart.UseVisualStyleBackColor = true;
            this.testStart.Click += new System.EventHandler(this.testStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "起動まで、";
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.Location = new System.Drawing.Point(262, 30);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(22, 22);
            this.waitLabel.TabIndex = 3;
            this.waitLabel.Text = "...";
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(132, 54);
            // 
            // showMenu
            // 
            this.showMenu.Name = "showMenu";
            this.showMenu.Size = new System.Drawing.Size(131, 22);
            this.showMenu.Text = "設定画面...";
            this.showMenu.Click += new System.EventHandler(this.showMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(131, 22);
            this.exitMenu.Text = "終了";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // timerAutoHide
            // 
            this.timerAutoHide.Enabled = true;
            this.timerAutoHide.Tick += new System.EventHandler(this.timerAutoHide_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.testStart);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunScreenSaver";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox screenSavers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Button testStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label waitLabel;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem showMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Timer timerAutoHide;
    }
}

