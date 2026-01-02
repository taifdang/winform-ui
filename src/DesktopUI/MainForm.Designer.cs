namespace DesktopUI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dataSetBindingSource = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            accountBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            panel6 = new Panel();
            panel5 = new Panel();
            panel9 = new Panel();
            groupBox1 = new GroupBox();
            button10 = new Button();
            button11 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            auto = new DataGridViewCheckBoxColumn();
            isAutoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label9 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            textBox10 = new TextBox();
            label8 = new Label();
            textBox11 = new TextBox();
            label14 = new Label();
            textBox12 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            time = new Label();
            textBox13 = new TextBox();
            checkBox6 = new CheckBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            panel10 = new Panel();
            button1 = new Button();
            btnUnCheck = new Button();
            button3 = new Button();
            btnCheck = new Button();
            button5 = new Button();
            button6 = new Button();
            panel11 = new Panel();
            username = new TextBox();
            proxy = new TextBox();
            btnDelete = new Button();
            label20 = new Label();
            btnUpdate = new Button();
            is_format = new ComboBox();
            index_server = new ComboBox();
            label21 = new Label();
            btnAdd = new Button();
            label22 = new Label();
            password = new TextBox();
            label23 = new Label();
            label24 = new Label();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)dataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Infrastructure.Entity.Account);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(868, 606);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "License";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(11, 600);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(852, 600);
            panel5.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.Controls.Add(groupBox1);
            panel9.Location = new Point(224, 159);
            panel9.Name = "panel9";
            panel9.Size = new Size(415, 262);
            panel9.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(53, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 160);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = Color.WhiteSmoke;
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button10.ImeMode = ImeMode.NoControl;
            button10.Location = new Point(6, 129);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(296, 23);
            button10.TabIndex = 16;
            button10.Text = "Update / Reset";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.WhiteSmoke;
            button11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button11.ImeMode = ImeMode.NoControl;
            button11.Location = new Point(226, 100);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(76, 23);
            button11.TabIndex = 11;
            button11.Text = "Copy";
            button11.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(75, 73);
            label1.Name = "label1";
            label1.Size = new Size(217, 15);
            label1.TabIndex = 7;
            label1.Text = "__________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(75, 46);
            label2.Name = "label2";
            label2.Size = new Size(217, 15);
            label2.TabIndex = 6;
            label2.Text = "__________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(75, 19);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 5;
            label3.Text = "__________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(6, 46);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 2;
            label5.Text = "Product:";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(6, 100);
            textBox8.MaximumSize = new Size(215, 23);
            textBox8.MinimumSize = new Size(215, 23);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(215, 23);
            textBox8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 0;
            label6.Text = "Username:";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(855, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 600);
            panel4.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(868, 606);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Control";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2);
            panel1.Size = new Size(862, 600);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 596);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { auto, isAutoDataGridViewCheckBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.DataSource = accountBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(460, 596);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // auto
            // 
            auto.DataPropertyName = "auto";
            auto.FillWeight = 17.4291935F;
            auto.HeaderText = "#";
            auto.Name = "auto";
            auto.ReadOnly = true;
            auto.Width = 25;
            // 
            // isAutoDataGridViewCheckBoxColumn
            // 
            isAutoDataGridViewCheckBoxColumn.DataPropertyName = "IsAuto";
            isAutoDataGridViewCheckBoxColumn.HeaderText = "IsAuto";
            isAutoDataGridViewCheckBoxColumn.Name = "isAutoDataGridViewCheckBoxColumn";
            isAutoDataGridViewCheckBoxColumn.ReadOnly = true;
            isAutoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            dataGridViewTextBoxColumn1.HeaderText = "Username";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            dataGridViewTextBoxColumn2.HeaderText = "Password";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Server";
            dataGridViewTextBoxColumn3.HeaderText = "Server";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(462, 2);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(398, 596);
            panel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel11);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(5, 5);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(388, 586);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.AutoScroll = true;
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(checkBox1);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(textBox10);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(textBox11);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(textBox12);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(time);
            panel8.Controls.Add(textBox13);
            panel8.Controls.Add(checkBox6);
            panel8.Controls.Add(textBox14);
            panel8.Controls.Add(textBox15);
            panel8.Controls.Add(textBox16);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(checkBox7);
            panel8.Controls.Add(checkBox8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(5, 162);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(378, 337);
            panel8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(25, 33);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 13);
            label9.TabIndex = 62;
            label9.Text = "Port";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(215, 30);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 61;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            checkBox1.ImeMode = ImeMode.NoControl;
            checkBox1.Location = new Point(25, 194);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 17);
            checkBox1.TabIndex = 60;
            checkBox1.Text = "Goback";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.OrangeRed;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(21, 9);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 56;
            label7.Text = "Thời gian:";
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Window;
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.ForeColor = SystemColors.WindowText;
            textBox10.Location = new Point(215, 57);
            textBox10.Margin = new Padding(0);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(144, 23);
            textBox10.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(23, 168);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 13);
            label8.TabIndex = 51;
            label8.Text = "Danh sách ID quái";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.Window;
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Enabled = false;
            textBox11.Location = new Point(289, 84);
            textBox11.Margin = new Padding(0);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(70, 23);
            textBox11.TabIndex = 58;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label14.ImeMode = ImeMode.NoControl;
            label14.Location = new Point(23, 141);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(83, 13);
            label14.TabIndex = 46;
            label14.Text = "Map đánh quái";
            // 
            // textBox12
            // 
            textBox12.BackColor = SystemColors.Window;
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Enabled = false;
            textBox12.Location = new Point(215, 84);
            textBox12.Margin = new Padding(0);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(70, 23);
            textBox12.TabIndex = 57;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label15.ImeMode = ImeMode.NoControl;
            label15.Location = new Point(23, 60);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(78, 13);
            label15.TabIndex = 43;
            label15.Text = "Số luồng chạy";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(23, 114);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(149, 13);
            label16.TabIndex = 49;
            label16.Text = "Thời gian đánh tối đa (phút)";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            time.ForeColor = Color.OrangeRed;
            time.ImeMode = ImeMode.NoControl;
            time.Location = new Point(125, 9);
            time.Margin = new Padding(4, 0, 4, 0);
            time.Name = "time";
            time.Size = new Size(45, 19);
            time.TabIndex = 44;
            time.Text = "timer";
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.Window;
            textBox13.BorderStyle = BorderStyle.FixedSingle;
            textBox13.Enabled = false;
            textBox13.Location = new Point(130, 138);
            textBox13.Margin = new Padding(0);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(229, 23);
            textBox13.TabIndex = 52;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            checkBox6.ImeMode = ImeMode.NoControl;
            checkBox6.Location = new Point(25, 244);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(70, 17);
            checkBox6.TabIndex = 48;
            checkBox6.Text = "Vứt item";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            textBox14.BackColor = SystemColors.Window;
            textBox14.BorderStyle = BorderStyle.FixedSingle;
            textBox14.Enabled = false;
            textBox14.Location = new Point(215, 111);
            textBox14.Margin = new Padding(0);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(144, 23);
            textBox14.TabIndex = 50;
            // 
            // textBox15
            // 
            textBox15.BackColor = SystemColors.Window;
            textBox15.BorderStyle = BorderStyle.FixedSingle;
            textBox15.Location = new Point(25, 293);
            textBox15.Margin = new Padding(0);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(334, 23);
            textBox15.TabIndex = 55;
            // 
            // textBox16
            // 
            textBox16.BackColor = SystemColors.Window;
            textBox16.BorderStyle = BorderStyle.FixedSingle;
            textBox16.Enabled = false;
            textBox16.Location = new Point(130, 165);
            textBox16.Margin = new Padding(0);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(229, 23);
            textBox16.TabIndex = 53;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label18.ImeMode = ImeMode.NoControl;
            label18.Location = new Point(23, 87);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(139, 13);
            label18.TabIndex = 45;
            label18.Text = "Reset thời gian (giờ/phút)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label19.ImeMode = ImeMode.NoControl;
            label19.Location = new Point(57, 85);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(0, 15);
            label19.TabIndex = 42;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            checkBox7.ImeMode = ImeMode.NoControl;
            checkBox7.Location = new Point(25, 219);
            checkBox7.Margin = new Padding(4, 3, 4, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(108, 17);
            checkBox7.TabIndex = 47;
            checkBox7.Text = "Đổi khu ít người";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            checkBox8.ImeMode = ImeMode.NoControl;
            checkBox8.Location = new Point(25, 269);
            checkBox8.Margin = new Padding(4, 3, 4, 3);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(76, 17);
            checkBox8.TabIndex = 54;
            checkBox8.Text = "Nhặt item";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(button1);
            panel10.Controls.Add(btnUnCheck);
            panel10.Controls.Add(button3);
            panel10.Controls.Add(btnCheck);
            panel10.Controls.Add(button5);
            panel10.Controls.Add(button6);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(5, 499);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(378, 82);
            panel10.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(254, 5);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 16;
            button1.Text = "Mở folder";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnUnCheck
            // 
            btnUnCheck.BackColor = Color.WhiteSmoke;
            btnUnCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUnCheck.ImeMode = ImeMode.NoControl;
            btnUnCheck.Location = new Point(136, 7);
            btnUnCheck.Margin = new Padding(4, 2, 4, 2);
            btnUnCheck.Name = "btnUnCheck";
            btnUnCheck.Size = new Size(105, 30);
            btnUnCheck.TabIndex = 17;
            btnUnCheck.Text = "Bỏ auto";
            btnUnCheck.UseVisualStyleBackColor = false;
            btnUnCheck.Click += btnUnCheck_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlText;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(254, 39);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(105, 30);
            button3.TabIndex = 21;
            button3.Text = "Chức năng";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.WhiteSmoke;
            btnCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCheck.ImeMode = ImeMode.NoControl;
            btnCheck.Location = new Point(16, 5);
            btnCheck.Margin = new Padding(4, 2, 4, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(105, 30);
            btnCheck.TabIndex = 18;
            btnCheck.Text = "Chọn auto";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ControlText;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(136, 39);
            button5.Margin = new Padding(4, 2, 4, 2);
            button5.Name = "button5";
            button5.Size = new Size(105, 30);
            button5.TabIndex = 20;
            button5.Text = "Tắt";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.WhiteSmoke;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.DialogResult = DialogResult.OK;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ControlText;
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(16, 39);
            button6.Margin = new Padding(4, 2, 4, 2);
            button6.Name = "button6";
            button6.Size = new Size(105, 30);
            button6.TabIndex = 19;
            button6.Text = "Bật";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(username);
            panel11.Controls.Add(proxy);
            panel11.Controls.Add(btnDelete);
            panel11.Controls.Add(label20);
            panel11.Controls.Add(btnUpdate);
            panel11.Controls.Add(is_format);
            panel11.Controls.Add(index_server);
            panel11.Controls.Add(label21);
            panel11.Controls.Add(btnAdd);
            panel11.Controls.Add(label22);
            panel11.Controls.Add(password);
            panel11.Controls.Add(label23);
            panel11.Controls.Add(label24);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(5, 5);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(378, 157);
            panel11.TabIndex = 2;
            // 
            // username
            // 
            username.BackColor = SystemColors.Window;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.ForeColor = SystemColors.WindowText;
            username.Location = new Point(102, 12);
            username.Margin = new Padding(0);
            username.Name = "username";
            username.Size = new Size(257, 23);
            username.TabIndex = 20;
            // 
            // proxy
            // 
            proxy.BackColor = SystemColors.Window;
            proxy.BorderStyle = BorderStyle.FixedSingle;
            proxy.Enabled = false;
            proxy.Location = new Point(102, 93);
            proxy.Margin = new Padding(0);
            proxy.Name = "proxy";
            proxy.Size = new Size(257, 23);
            proxy.TabIndex = 23;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ImeMode = ImeMode.NoControl;
            btnDelete.Location = new Point(254, 122);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 30);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label20.ImeMode = ImeMode.NoControl;
            label20.Location = new Point(16, 96);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(36, 13);
            label20.TabIndex = 27;
            label20.Text = "Proxy";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.ImeMode = ImeMode.NoControl;
            btnUpdate.Location = new Point(136, 122);
            btnUpdate.Margin = new Padding(4, 2, 4, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 30);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // is_format
            // 
            is_format.AccessibleName = "";
            is_format.BackColor = SystemColors.Window;
            is_format.DropDownStyle = ComboBoxStyle.DropDownList;
            is_format.FlatStyle = FlatStyle.System;
            is_format.FormattingEnabled = true;
            is_format.Items.AddRange(new object[] { "HTTP", "SOCKS5" });
            is_format.Location = new Point(267, 66);
            is_format.Margin = new Padding(0);
            is_format.Name = "is_format";
            is_format.Size = new Size(92, 23);
            is_format.TabIndex = 28;
            is_format.Tag = "";
            // 
            // index_server
            // 
            index_server.AccessibleName = "";
            index_server.BackColor = SystemColors.Window;
            index_server.DropDownStyle = ComboBoxStyle.DropDownList;
            index_server.FormattingEnabled = true;
            index_server.Location = new Point(102, 66);
            index_server.Margin = new Padding(4, 2, 4, 2);
            index_server.Name = "index_server";
            index_server.Size = new Size(92, 23);
            index_server.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label21.ImeMode = ImeMode.NoControl;
            label21.Location = new Point(16, 15);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(55, 13);
            label21.TabIndex = 17;
            label21.Text = "Tài khoản";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(16, 122);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 30);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label22.ImeMode = ImeMode.NoControl;
            label22.Location = new Point(16, 70);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(49, 13);
            label22.TabIndex = 19;
            label22.Text = "Máy chủ";
            // 
            // password
            // 
            password.BackColor = SystemColors.Window;
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Location = new Point(102, 39);
            password.Margin = new Padding(0);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(257, 23);
            password.TabIndex = 21;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label23.ImeMode = ImeMode.NoControl;
            label23.Location = new Point(202, 70);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(61, 13);
            label23.TabIndex = 29;
            label23.Text = "Loại proxy";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label24.ImeMode = ImeMode.NoControl;
            label24.Location = new Point(16, 42);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(54, 13);
            label24.TabIndex = 18;
            label24.Text = "Mật khẩu";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(876, 634);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 4;
            // 
            // FormGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 644);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGUI";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Load += Setting_Load;
            ((System.ComponentModel.ISupportInitialize)dataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private BindingSource dataSetBindingSource;
        private DataGridViewCheckBoxColumn checkboxDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serverDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource;
        private TabPage tabPage2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel9;
        private GroupBox groupBox1;
        private Button button10;
        private Button button11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox8;
        private Label label6;
        private Panel panel4;
        private TabPage tabPage1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn auto;
        private DataGridViewCheckBoxColumn isAutoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private Label label9;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label7;
        private TextBox textBox10;
        private Label label8;
        private TextBox textBox11;
        private Label label14;
        private TextBox textBox12;
        private Label label15;
        private Label label16;
        private Label time;
        private TextBox textBox13;
        private CheckBox checkBox6;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label18;
        private Label label19;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Panel panel10;
        private Button button1;
        private Button btnUnCheck;
        private Button button3;
        private Button btnCheck;
        private Button button5;
        private Button button6;
        private Panel panel11;
        private TextBox username;
        private TextBox proxy;
        private Button btnDelete;
        private Label label20;
        private Button btnUpdate;
        private ComboBox is_format;
        private ComboBox index_server;
        private Label label21;
        private Button btnAdd;
        private Label label22;
        private TextBox password;
        private Label label23;
        private Label label24;
        private TabControl tabControl1;
    }
}