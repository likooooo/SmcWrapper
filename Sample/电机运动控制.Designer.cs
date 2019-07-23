namespace Sample
{
    partial class MotorControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotorControl));
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.labZ = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.labX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labU = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXReset = new System.Windows.Forms.Button();
            this.btnXStop = new System.Windows.Forms.Button();
            this.btnXRight = new System.Windows.Forms.Button();
            this.btnXLeft = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabX = new System.Windows.Forms.TabPage();
            this.tabY = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnYReset = new System.Windows.Forms.Button();
            this.btnYStop = new System.Windows.Forms.Button();
            this.btnYRight = new System.Windows.Forms.Button();
            this.btnYLeft = new System.Windows.Forms.Button();
            this.tabZ = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZReset = new System.Windows.Forms.Button();
            this.btnZStop = new System.Windows.Forms.Button();
            this.btnZLeft = new System.Windows.Forms.Button();
            this.btnZRight = new System.Windows.Forms.Button();
            this.tabU = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUReset = new System.Windows.Forms.Button();
            this.btnUStop = new System.Windows.Forms.Button();
            this.btnULeft = new System.Windows.Forms.Button();
            this.btnURight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.steptext = new System.Windows.Forms.TextBox();
            this.btnAutoMove = new System.Windows.Forms.Button();
            this.btnGetPointcloud = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabX.SuspendLayout();
            this.tabY.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabZ.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabU.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("宋体", 15F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "点位移动",
            "持续移动"});
            this.cmbStatus.Location = new System.Drawing.Point(172, 12);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbStatus.TabIndex = 21;
            this.cmbStatus.Text = "点位移动";
            // 
            // cmbPorts
            // 
            this.cmbPorts.Font = new System.Drawing.Font("宋体", 15F);
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(12, 12);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(121, 28);
            this.cmbPorts.TabIndex = 20;
            this.cmbPorts.TextChanged += new System.EventHandler(this.cmbPorts_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.76836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.23164F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labZ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labU, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(132, 220);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(7, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "U:";
            // 
            // labZ
            // 
            this.labZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labZ.AutoSize = true;
            this.labZ.Font = new System.Drawing.Font("宋体", 15F);
            this.labZ.Location = new System.Drawing.Point(87, 127);
            this.labZ.Name = "labZ";
            this.labZ.Size = new System.Drawing.Size(0, 20);
            this.labZ.TabIndex = 5;
            // 
            // labY
            // 
            this.labY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labY.AutoSize = true;
            this.labY.Font = new System.Drawing.Font("宋体", 15F);
            this.labY.Location = new System.Drawing.Point(87, 72);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(0, 20);
            this.labY.TabIndex = 4;
            // 
            // labX
            // 
            this.labX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labX.AutoSize = true;
            this.labX.Font = new System.Drawing.Font("宋体", 15F);
            this.labX.Location = new System.Drawing.Point(87, 17);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(0, 20);
            this.labX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z:";
            // 
            // labU
            // 
            this.labU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labU.AutoSize = true;
            this.labU.Font = new System.Drawing.Font("宋体", 15F);
            this.labU.Location = new System.Drawing.Point(87, 182);
            this.labU.Name = "labU";
            this.labU.Size = new System.Drawing.Size(0, 20);
            this.labU.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnXReset, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnXStop, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnXRight, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXLeft, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 195);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // btnXReset
            // 
            this.btnXReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXReset.Image = ((System.Drawing.Image)(resources.GetObject("btnXReset.Image")));
            this.btnXReset.Location = new System.Drawing.Point(45, 100);
            this.btnXReset.Name = "btnXReset";
            this.btnXReset.Size = new System.Drawing.Size(100, 92);
            this.btnXReset.TabIndex = 15;
            this.btnXReset.Text = "X Reset";
            this.btnXReset.UseVisualStyleBackColor = true;
            this.btnXReset.Click += new System.EventHandler(this.btnXReset_Click);
            // 
            // btnXStop
            // 
            this.btnXStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXStop.Image = ((System.Drawing.Image)(resources.GetObject("btnXStop.Image")));
            this.btnXStop.Location = new System.Drawing.Point(235, 100);
            this.btnXStop.Name = "btnXStop";
            this.btnXStop.Size = new System.Drawing.Size(100, 92);
            this.btnXStop.TabIndex = 10;
            this.btnXStop.UseVisualStyleBackColor = true;
            this.btnXStop.Click += new System.EventHandler(this.btnXStop_Click);
            // 
            // btnXRight
            // 
            this.btnXRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXRight.Image = ((System.Drawing.Image)(resources.GetObject("btnXRight.Image")));
            this.btnXRight.Location = new System.Drawing.Point(45, 3);
            this.btnXRight.Name = "btnXRight";
            this.btnXRight.Size = new System.Drawing.Size(100, 91);
            this.btnXRight.TabIndex = 3;
            this.btnXRight.UseVisualStyleBackColor = true;
            this.btnXRight.Click += new System.EventHandler(this.btnXRight_Click);
            // 
            // btnXLeft
            // 
            this.btnXLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnXLeft.Image")));
            this.btnXLeft.Location = new System.Drawing.Point(235, 3);
            this.btnXLeft.Name = "btnXLeft";
            this.btnXLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXLeft.Size = new System.Drawing.Size(100, 91);
            this.btnXLeft.TabIndex = 2;
            this.btnXLeft.UseVisualStyleBackColor = true;
            this.btnXLeft.Click += new System.EventHandler(this.btnXLeft_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabX);
            this.tabControl1.Controls.Add(this.tabY);
            this.tabControl1.Controls.Add(this.tabZ);
            this.tabControl1.Controls.Add(this.tabU);
            this.tabControl1.Location = new System.Drawing.Point(139, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 224);
            this.tabControl1.TabIndex = 29;
            // 
            // tabX
            // 
            this.tabX.Controls.Add(this.tableLayoutPanel2);
            this.tabX.Location = new System.Drawing.Point(4, 22);
            this.tabX.Name = "tabX";
            this.tabX.Padding = new System.Windows.Forms.Padding(3);
            this.tabX.Size = new System.Drawing.Size(381, 198);
            this.tabX.TabIndex = 0;
            this.tabX.Text = "X轴水平移动";
            this.tabX.UseVisualStyleBackColor = true;
            // 
            // tabY
            // 
            this.tabY.Controls.Add(this.tableLayoutPanel3);
            this.tabY.Location = new System.Drawing.Point(4, 22);
            this.tabY.Name = "tabY";
            this.tabY.Padding = new System.Windows.Forms.Padding(3);
            this.tabY.Size = new System.Drawing.Size(381, 198);
            this.tabY.TabIndex = 1;
            this.tabY.Text = "y轴竖直移动";
            this.tabY.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnYReset, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnYStop, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnYRight, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnYLeft, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 195);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // btnYReset
            // 
            this.btnYReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYReset.Image = ((System.Drawing.Image)(resources.GetObject("btnYReset.Image")));
            this.btnYReset.Location = new System.Drawing.Point(45, 100);
            this.btnYReset.Name = "btnYReset";
            this.btnYReset.Size = new System.Drawing.Size(100, 92);
            this.btnYReset.TabIndex = 16;
            this.btnYReset.Text = "Y Reset";
            this.btnYReset.UseVisualStyleBackColor = true;
            this.btnYReset.Click += new System.EventHandler(this.btnYReset_Click);
            // 
            // btnYStop
            // 
            this.btnYStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYStop.Image = ((System.Drawing.Image)(resources.GetObject("btnYStop.Image")));
            this.btnYStop.Location = new System.Drawing.Point(235, 100);
            this.btnYStop.Name = "btnYStop";
            this.btnYStop.Size = new System.Drawing.Size(100, 92);
            this.btnYStop.TabIndex = 17;
            this.btnYStop.UseVisualStyleBackColor = true;
            this.btnYStop.Click += new System.EventHandler(this.btnYStop_Click);
            // 
            // btnYRight
            // 
            this.btnYRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYRight.Image = ((System.Drawing.Image)(resources.GetObject("btnYRight.Image")));
            this.btnYRight.Location = new System.Drawing.Point(45, 3);
            this.btnYRight.Name = "btnYRight";
            this.btnYRight.Size = new System.Drawing.Size(100, 91);
            this.btnYRight.TabIndex = 5;
            this.btnYRight.UseVisualStyleBackColor = true;
            this.btnYRight.Click += new System.EventHandler(this.btnYRight_Click);
            // 
            // btnYLeft
            // 
            this.btnYLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnYLeft.Image")));
            this.btnYLeft.Location = new System.Drawing.Point(235, 3);
            this.btnYLeft.Name = "btnYLeft";
            this.btnYLeft.Size = new System.Drawing.Size(100, 91);
            this.btnYLeft.TabIndex = 4;
            this.btnYLeft.UseVisualStyleBackColor = true;
            this.btnYLeft.Click += new System.EventHandler(this.btnYLeft_Click);
            // 
            // tabZ
            // 
            this.tabZ.Controls.Add(this.tableLayoutPanel4);
            this.tabZ.Location = new System.Drawing.Point(4, 22);
            this.tabZ.Name = "tabZ";
            this.tabZ.Padding = new System.Windows.Forms.Padding(3);
            this.tabZ.Size = new System.Drawing.Size(381, 198);
            this.tabZ.TabIndex = 2;
            this.tabZ.Text = "相机旋转";
            this.tabZ.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnZReset, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnZStop, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnZLeft, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnZRight, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(380, 195);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // btnZReset
            // 
            this.btnZReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZReset.Image = ((System.Drawing.Image)(resources.GetObject("btnZReset.Image")));
            this.btnZReset.Location = new System.Drawing.Point(45, 100);
            this.btnZReset.Name = "btnZReset";
            this.btnZReset.Size = new System.Drawing.Size(100, 92);
            this.btnZReset.TabIndex = 17;
            this.btnZReset.Text = "Z Reset";
            this.btnZReset.UseVisualStyleBackColor = true;
            this.btnZReset.Click += new System.EventHandler(this.btnZReset_Click);
            // 
            // btnZStop
            // 
            this.btnZStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZStop.Image = ((System.Drawing.Image)(resources.GetObject("btnZStop.Image")));
            this.btnZStop.Location = new System.Drawing.Point(235, 100);
            this.btnZStop.Name = "btnZStop";
            this.btnZStop.Size = new System.Drawing.Size(100, 92);
            this.btnZStop.TabIndex = 12;
            this.btnZStop.UseVisualStyleBackColor = true;
            this.btnZStop.Click += new System.EventHandler(this.btnZStop_Click);
            // 
            // btnZLeft
            // 
            this.btnZLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnZLeft.Image")));
            this.btnZLeft.Location = new System.Drawing.Point(45, 3);
            this.btnZLeft.Name = "btnZLeft";
            this.btnZLeft.Size = new System.Drawing.Size(100, 91);
            this.btnZLeft.TabIndex = 6;
            this.btnZLeft.UseVisualStyleBackColor = true;
            this.btnZLeft.Click += new System.EventHandler(this.btnZLeft_Click);
            // 
            // btnZRight
            // 
            this.btnZRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZRight.Image = ((System.Drawing.Image)(resources.GetObject("btnZRight.Image")));
            this.btnZRight.Location = new System.Drawing.Point(235, 3);
            this.btnZRight.Name = "btnZRight";
            this.btnZRight.Size = new System.Drawing.Size(100, 91);
            this.btnZRight.TabIndex = 13;
            this.btnZRight.UseVisualStyleBackColor = true;
            this.btnZRight.Click += new System.EventHandler(this.btnZRight_Click);
            // 
            // tabU
            // 
            this.tabU.Controls.Add(this.tableLayoutPanel5);
            this.tabU.Location = new System.Drawing.Point(4, 22);
            this.tabU.Name = "tabU";
            this.tabU.Padding = new System.Windows.Forms.Padding(3);
            this.tabU.Size = new System.Drawing.Size(381, 198);
            this.tabU.TabIndex = 3;
            this.tabU.Text = "圆盘旋转";
            this.tabU.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnUReset, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnUStop, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnULeft, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnURight, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(380, 195);
            this.tableLayoutPanel5.TabIndex = 30;
            // 
            // btnUReset
            // 
            this.btnUReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUReset.Image = ((System.Drawing.Image)(resources.GetObject("btnUReset.Image")));
            this.btnUReset.Location = new System.Drawing.Point(45, 100);
            this.btnUReset.Name = "btnUReset";
            this.btnUReset.Size = new System.Drawing.Size(100, 92);
            this.btnUReset.TabIndex = 18;
            this.btnUReset.Text = "U Reset";
            this.btnUReset.UseVisualStyleBackColor = true;
            this.btnUReset.Click += new System.EventHandler(this.btnUReset_Click);
            // 
            // btnUStop
            // 
            this.btnUStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUStop.Image = ((System.Drawing.Image)(resources.GetObject("btnUStop.Image")));
            this.btnUStop.Location = new System.Drawing.Point(235, 100);
            this.btnUStop.Name = "btnUStop";
            this.btnUStop.Size = new System.Drawing.Size(100, 92);
            this.btnUStop.TabIndex = 13;
            this.btnUStop.UseVisualStyleBackColor = true;
            this.btnUStop.Click += new System.EventHandler(this.btnUStop_Click);
            // 
            // btnULeft
            // 
            this.btnULeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnULeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnULeft.Image = ((System.Drawing.Image)(resources.GetObject("btnULeft.Image")));
            this.btnULeft.Location = new System.Drawing.Point(45, 3);
            this.btnULeft.Name = "btnULeft";
            this.btnULeft.Size = new System.Drawing.Size(100, 91);
            this.btnULeft.TabIndex = 8;
            this.btnULeft.UseVisualStyleBackColor = true;
            this.btnULeft.Click += new System.EventHandler(this.btnULeft_Click);
            // 
            // btnURight
            // 
            this.btnURight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnURight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnURight.Image = ((System.Drawing.Image)(resources.GetObject("btnURight.Image")));
            this.btnURight.Location = new System.Drawing.Point(235, 3);
            this.btnURight.Name = "btnURight";
            this.btnURight.Size = new System.Drawing.Size(100, 91);
            this.btnURight.TabIndex = 9;
            this.btnURight.UseVisualStyleBackColor = true;
            this.btnURight.Click += new System.EventHandler(this.btnURight_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(471, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // steptext
            // 
            this.steptext.Font = new System.Drawing.Font("宋体", 15F);
            this.steptext.Location = new System.Drawing.Point(308, 12);
            this.steptext.Name = "steptext";
            this.steptext.Size = new System.Drawing.Size(66, 30);
            this.steptext.TabIndex = 31;
            this.steptext.Text = "5";
            this.steptext.Visible = false;
            // 
            // btnAutoMove
            // 
            this.btnAutoMove.Location = new System.Drawing.Point(391, 13);
            this.btnAutoMove.Name = "btnAutoMove";
            this.btnAutoMove.Size = new System.Drawing.Size(75, 23);
            this.btnAutoMove.TabIndex = 32;
            this.btnAutoMove.Text = "autoMove";
            this.btnAutoMove.UseVisualStyleBackColor = true;
            this.btnAutoMove.Visible = false;
            this.btnAutoMove.Click += new System.EventHandler(this.btnAutoMove_Click);
            // 
            // btnGetPointcloud
            // 
            this.btnGetPointcloud.Location = new System.Drawing.Point(472, 13);
            this.btnGetPointcloud.Name = "btnGetPointcloud";
            this.btnGetPointcloud.Size = new System.Drawing.Size(75, 23);
            this.btnGetPointcloud.TabIndex = 33;
            this.btnGetPointcloud.Text = "采集当前点云";
            this.btnGetPointcloud.UseVisualStyleBackColor = true;
            this.btnGetPointcloud.Visible = false;
            this.btnGetPointcloud.Click += new System.EventHandler(this.BtnGetPointcloud_Click);
            // 
            // MotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 293);
            this.Controls.Add(this.btnGetPointcloud);
            this.Controls.Add(this.btnAutoMove);
            this.Controls.Add(this.steptext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbPorts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MotorControl";
            this.Text = "电机运动控制";
            this.Load += new System.EventHandler(this.MotorControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabX.ResumeLayout(false);
            this.tabY.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabZ.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabU.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labZ;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabX;
        private System.Windows.Forms.TabPage tabY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage tabU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnXRight;
        private System.Windows.Forms.Button btnXStop;
        private System.Windows.Forms.Button btnXReset;
        private System.Windows.Forms.Button btnYLeft;
        private System.Windows.Forms.Button btnYRight;
        private System.Windows.Forms.Button btnYReset;
        private System.Windows.Forms.Button btnYStop;
        private System.Windows.Forms.Button btnZLeft;
        private System.Windows.Forms.Button btnZStop;
        private System.Windows.Forms.Button btnZRight;
        private System.Windows.Forms.Button btnZReset;
        private System.Windows.Forms.Button btnULeft;
        private System.Windows.Forms.Button btnURight;
        private System.Windows.Forms.Button btnUStop;
        private System.Windows.Forms.Button btnUReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXLeft;
        public System.Windows.Forms.TextBox steptext;
        public System.Windows.Forms.Button btnGetPointcloud;
        public System.Windows.Forms.Button btnAutoMove;
    }
}