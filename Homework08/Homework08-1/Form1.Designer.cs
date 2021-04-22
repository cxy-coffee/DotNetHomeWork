namespace Homework08_1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1_Price6 = new System.Windows.Forms.Label();
            this.label_Quantity6 = new System.Windows.Forms.Label();
            this.label1_Price5 = new System.Windows.Forms.Label();
            this.label_Quantity5 = new System.Windows.Forms.Label();
            this.label1_Price4 = new System.Windows.Forms.Label();
            this.label_Quantity4 = new System.Windows.Forms.Label();
            this.label1_Price3 = new System.Windows.Forms.Label();
            this.label_Quantity3 = new System.Windows.Forms.Label();
            this.label1_Price2 = new System.Windows.Forms.Label();
            this.label_Quantity2 = new System.Windows.Forms.Label();
            this.label1_Price1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Quantity1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_OrderPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_OrderId = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.selectToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 21);
            this.toolStripMenuItem1.Text = "New";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.byIdToolStripMenuItem,
            this.byPriceToolStripMenuItem,
            this.byProductToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // byIdToolStripMenuItem
            // 
            this.byIdToolStripMenuItem.Name = "byIdToolStripMenuItem";
            this.byIdToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.byIdToolStripMenuItem.Text = "ById";
            this.byIdToolStripMenuItem.Click += new System.EventHandler(this.byIdToolStripMenuItem_Click);
            // 
            // byPriceToolStripMenuItem
            // 
            this.byPriceToolStripMenuItem.Name = "byPriceToolStripMenuItem";
            this.byPriceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.byPriceToolStripMenuItem.Text = "ByPrice";
            this.byPriceToolStripMenuItem.Click += new System.EventHandler(this.byPriceToolStripMenuItem_Click);
            // 
            // byProductToolStripMenuItem
            // 
            this.byProductToolStripMenuItem.Name = "byProductToolStripMenuItem";
            this.byProductToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.byProductToolStripMenuItem.Text = "ByProduct";
            this.byProductToolStripMenuItem.Click += new System.EventHandler(this.byProductToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byIdToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // byIdToolStripMenuItem1
            // 
            this.byIdToolStripMenuItem1.Name = "byIdToolStripMenuItem1";
            this.byIdToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.byIdToolStripMenuItem1.Text = "ById";
            this.byIdToolStripMenuItem1.Click += new System.EventHandler(this.byIdToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.orderDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(996, 494);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 1;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(332, 494);
            this.orderDataGridView.TabIndex = 0;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1_Price6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_Quantity6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1_Price5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_Quantity5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1_Price4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Quantity4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1_Price3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Quantity3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1_Price2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Quantity2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1_Price1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Quantity1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 374);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1_Price6
            // 
            this.label1_Price6.AutoSize = true;
            this.label1_Price6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_Price6.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Price6.Location = new System.Drawing.Point(442, 317);
            this.label1_Price6.Name = "label1_Price6";
            this.label1_Price6.Size = new System.Drawing.Size(214, 56);
            this.label1_Price6.TabIndex = 20;
            this.label1_Price6.Text = "0";
            this.label1_Price6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Quantity6
            // 
            this.label_Quantity6.AutoSize = true;
            this.label_Quantity6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quantity6.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity6.Location = new System.Drawing.Point(223, 317);
            this.label_Quantity6.Name = "label_Quantity6";
            this.label_Quantity6.Size = new System.Drawing.Size(212, 56);
            this.label_Quantity6.TabIndex = 19;
            this.label_Quantity6.Text = "0";
            this.label_Quantity6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Price5
            // 
            this.label1_Price5.AutoSize = true;
            this.label1_Price5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_Price5.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Price5.Location = new System.Drawing.Point(442, 264);
            this.label1_Price5.Name = "label1_Price5";
            this.label1_Price5.Size = new System.Drawing.Size(214, 52);
            this.label1_Price5.TabIndex = 18;
            this.label1_Price5.Text = "0";
            this.label1_Price5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Quantity5
            // 
            this.label_Quantity5.AutoSize = true;
            this.label_Quantity5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quantity5.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity5.Location = new System.Drawing.Point(223, 264);
            this.label_Quantity5.Name = "label_Quantity5";
            this.label_Quantity5.Size = new System.Drawing.Size(212, 52);
            this.label_Quantity5.TabIndex = 17;
            this.label_Quantity5.Text = "0";
            this.label_Quantity5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Price4
            // 
            this.label1_Price4.AutoSize = true;
            this.label1_Price4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_Price4.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Price4.Location = new System.Drawing.Point(442, 211);
            this.label1_Price4.Name = "label1_Price4";
            this.label1_Price4.Size = new System.Drawing.Size(214, 52);
            this.label1_Price4.TabIndex = 16;
            this.label1_Price4.Text = "0";
            this.label1_Price4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Quantity4
            // 
            this.label_Quantity4.AutoSize = true;
            this.label_Quantity4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quantity4.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity4.Location = new System.Drawing.Point(223, 211);
            this.label_Quantity4.Name = "label_Quantity4";
            this.label_Quantity4.Size = new System.Drawing.Size(212, 52);
            this.label_Quantity4.TabIndex = 15;
            this.label_Quantity4.Text = "0";
            this.label_Quantity4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Price3
            // 
            this.label1_Price3.AutoSize = true;
            this.label1_Price3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_Price3.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Price3.Location = new System.Drawing.Point(442, 158);
            this.label1_Price3.Name = "label1_Price3";
            this.label1_Price3.Size = new System.Drawing.Size(214, 52);
            this.label1_Price3.TabIndex = 14;
            this.label1_Price3.Text = "0";
            this.label1_Price3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Quantity3
            // 
            this.label_Quantity3.AutoSize = true;
            this.label_Quantity3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quantity3.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity3.Location = new System.Drawing.Point(223, 158);
            this.label_Quantity3.Name = "label_Quantity3";
            this.label_Quantity3.Size = new System.Drawing.Size(212, 52);
            this.label_Quantity3.TabIndex = 13;
            this.label_Quantity3.Text = "0";
            this.label_Quantity3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Price2
            // 
            this.label1_Price2.AutoSize = true;
            this.label1_Price2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_Price2.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Price2.Location = new System.Drawing.Point(442, 105);
            this.label1_Price2.Name = "label1_Price2";
            this.label1_Price2.Size = new System.Drawing.Size(214, 52);
            this.label1_Price2.TabIndex = 12;
            this.label1_Price2.Text = "0";
            this.label1_Price2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Quantity2
            // 
            this.label_Quantity2.AutoSize = true;
            this.label_Quantity2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quantity2.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity2.Location = new System.Drawing.Point(223, 105);
            this.label_Quantity2.Name = "label_Quantity2";
            this.label_Quantity2.Size = new System.Drawing.Size(212, 52);
            this.label_Quantity2.TabIndex = 11;
            this.label_Quantity2.Text = "0";
            this.label_Quantity2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Price1
            // 
            this.label1_Price1.AutoSize = true;
            this.label1_Price1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_Price1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_Price1.Location = new System.Drawing.Point(442, 52);
            this.label1_Price1.Name = "label1_Price1";
            this.label1_Price1.Size = new System.Drawing.Size(214, 52);
            this.label1_Price1.TabIndex = 10;
            this.label1_Price1.Text = "0";
            this.label1_Price1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "黄焖鸡(20元)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 18F);
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "鸡公煲(25元)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("宋体", 18F);
            this.label5.Location = new System.Drawing.Point(4, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 52);
            this.label5.TabIndex = 2;
            this.label5.Text = "麻辣香锅(30元)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("宋体", 18F);
            this.label6.Location = new System.Drawing.Point(4, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 52);
            this.label6.TabIndex = 3;
            this.label6.Text = "麻辣烫(15元)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("宋体", 18F);
            this.label7.Location = new System.Drawing.Point(4, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 52);
            this.label7.TabIndex = 4;
            this.label7.Text = "奶茶(18元)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("宋体", 18F);
            this.label8.Location = new System.Drawing.Point(4, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 56);
            this.label8.TabIndex = 5;
            this.label8.Text = "饮料(5元)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 50);
            this.label9.TabIndex = 6;
            this.label9.Text = "商品名称";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("宋体", 24F);
            this.label10.Location = new System.Drawing.Point(223, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 50);
            this.label10.TabIndex = 7;
            this.label10.Text = "商品数量";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("宋体", 24F);
            this.label11.Location = new System.Drawing.Point(442, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 50);
            this.label11.TabIndex = 8;
            this.label11.Text = "商品总价";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Quantity1
            // 
            this.label_Quantity1.AutoSize = true;
            this.label_Quantity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Quantity1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity1.Location = new System.Drawing.Point(223, 52);
            this.label_Quantity1.Name = "label_Quantity1";
            this.label_Quantity1.Size = new System.Drawing.Size(212, 52);
            this.label_Quantity1.TabIndex = 9;
            this.label_Quantity1.Text = "0";
            this.label_Quantity1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_OrderPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 60);
            this.panel2.TabIndex = 2;
            // 
            // label_OrderPrice
            // 
            this.label_OrderPrice.AutoSize = true;
            this.label_OrderPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_OrderPrice.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderPrice.Location = new System.Drawing.Point(616, 0);
            this.label_OrderPrice.Name = "label_OrderPrice";
            this.label_OrderPrice.Size = new System.Drawing.Size(44, 48);
            this.label_OrderPrice.TabIndex = 1;
            this.label_OrderPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "订单总价：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_OrderId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "订单ID：";
            // 
            // label_OrderId
            // 
            this.label_OrderId.AutoSize = true;
            this.label_OrderId.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_OrderId.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderId.Location = new System.Drawing.Point(616, 0);
            this.label_OrderId.Name = "label_OrderId";
            this.label_OrderId.Size = new System.Drawing.Size(44, 48);
            this.label_OrderId.TabIndex = 0;
            this.label_OrderId.Text = "0";
            this.label_OrderId.TextChanged += new System.EventHandler(this.label_OrderId_TextChanged);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Homework05_1.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_OrderId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_OrderPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1_Price6;
        private System.Windows.Forms.Label label_Quantity6;
        private System.Windows.Forms.Label label1_Price5;
        private System.Windows.Forms.Label label_Quantity5;
        private System.Windows.Forms.Label label1_Price4;
        private System.Windows.Forms.Label label_Quantity4;
        private System.Windows.Forms.Label label1_Price3;
        private System.Windows.Forms.Label label_Quantity3;
        private System.Windows.Forms.Label label1_Price2;
        private System.Windows.Forms.Label label_Quantity2;
        private System.Windows.Forms.Label label1_Price1;
        private System.Windows.Forms.Label label_Quantity1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIdToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}

