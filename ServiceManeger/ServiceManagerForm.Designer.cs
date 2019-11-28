namespace ServiceManeger
{
    partial class ServiceManagerForm
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
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonStopSelected = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.paneldataGridView = new System.Windows.Forms.Panel();
            this.dataGridView = new ServiceManeger.Controls.SortedDataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.tablePanelButtom = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tablePanelLegend = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.checkShowColors = new System.Windows.Forms.CheckBox();
            this.tablePanelMain.SuspendLayout();
            this.paneldataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelButtom.SuspendLayout();
            this.tablePanelButtom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReload.AutoSize = true;
            this.buttonReload.Location = new System.Drawing.Point(28, 106);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(112, 46);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonStopSelected
            // 
            this.buttonStopSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStopSelected.AutoSize = true;
            this.buttonStopSelected.Location = new System.Drawing.Point(28, 154);
            this.buttonStopSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStopSelected.Name = "buttonStopSelected";
            this.buttonStopSelected.Size = new System.Drawing.Size(180, 46);
            this.buttonStopSelected.TabIndex = 3;
            this.buttonStopSelected.Text = "Stop Selected";
            this.buttonStopSelected.UseVisualStyleBackColor = true;
            this.buttonStopSelected.Click += new System.EventHandler(this.buttonStopSelected_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(947, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Legend";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(321, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(634, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanelMain
            // 
            this.tablePanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tablePanelMain.ColumnCount = 1;
            this.tablePanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMain.Controls.Add(this.paneldataGridView, 0, 0);
            this.tablePanelMain.Controls.Add(this.panelButtom, 0, 1);
            this.tablePanelMain.Location = new System.Drawing.Point(18, 18);
            this.tablePanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanelMain.Name = "tablePanelMain";
            this.tablePanelMain.RowCount = 2;
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelMain.Size = new System.Drawing.Size(1034, 598);
            this.tablePanelMain.TabIndex = 5;
            // 
            // paneldataGridView
            // 
            this.paneldataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneldataGridView.Controls.Add(this.dataGridView);
            this.paneldataGridView.Location = new System.Drawing.Point(3, 3);
            this.paneldataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.paneldataGridView.Name = "paneldataGridView";
            this.paneldataGridView.Size = new System.Drawing.Size(1028, 320);
            this.paneldataGridView.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Stop,
            this.DisplayName,
            this.ServiceName,
            this.Status,
            this.StartMode,
            this.Type,
            this.Empty});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(-8, -8);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1035, 328);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            this.dataGridView.Leave += new System.EventHandler(this.dataGridView_Leave);
            // 
            // Key
            // 
            this.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Key.HeaderText = "Key";
            this.Key.MinimumWidth = 8;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Visible = false;
            this.Key.Width = 150;
            // 
            // Stop
            // 
            this.Stop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stop.HeaderText = "Stop";
            this.Stop.MinimumWidth = 8;
            this.Stop.Name = "Stop";
            this.Stop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Stop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Stop.Width = 79;
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DisplayName.HeaderText = "Display Name";
            this.DisplayName.MinimumWidth = 8;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Width = 142;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ServiceName.HeaderText = "Name";
            this.ServiceName.MinimumWidth = 8;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 87;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 92;
            // 
            // StartMode
            // 
            this.StartMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartMode.HeaderText = "Start Mode";
            this.StartMode.MinimumWidth = 8;
            this.StartMode.Name = "StartMode";
            this.StartMode.ReadOnly = true;
            this.StartMode.Width = 124;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 79;
            // 
            // Empty
            // 
            this.Empty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empty.HeaderText = "";
            this.Empty.MinimumWidth = 8;
            this.Empty.Name = "Empty";
            this.Empty.ReadOnly = true;
            // 
            // panelButtom
            // 
            this.panelButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtom.AutoScroll = true;
            this.panelButtom.AutoSize = true;
            this.panelButtom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtom.Controls.Add(this.tablePanelButtom);
            this.panelButtom.Location = new System.Drawing.Point(3, 326);
            this.panelButtom.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(1028, 269);
            this.panelButtom.TabIndex = 6;
            // 
            // tablePanelButtom
            // 
            this.tablePanelButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelButtom.AutoSize = true;
            this.tablePanelButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelButtom.ColumnCount = 4;
            this.tablePanelButtom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanelButtom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanelButtom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanelButtom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelButtom.Controls.Add(this.textBoxDescription, 1, 1);
            this.tablePanelButtom.Controls.Add(this.label3, 3, 0);
            this.tablePanelButtom.Controls.Add(this.textBoxLog, 2, 1);
            this.tablePanelButtom.Controls.Add(this.label2, 1, 0);
            this.tablePanelButtom.Controls.Add(this.tablePanelLegend, 3, 1);
            this.tablePanelButtom.Controls.Add(this.label1, 2, 0);
            this.tablePanelButtom.Controls.Add(this.panelButtons, 0, 1);
            this.tablePanelButtom.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tablePanelButtom.Location = new System.Drawing.Point(2, 0);
            this.tablePanelButtom.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelButtom.Name = "tablePanelButtom";
            this.tablePanelButtom.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanelButtom.RowCount = 2;
            this.tablePanelButtom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelButtom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelButtom.Size = new System.Drawing.Size(1020, 265);
            this.tablePanelButtom.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.Location = new System.Drawing.Point(321, 42);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(305, 213);
            this.textBoxDescription.TabIndex = 9;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.BackColor = System.Drawing.Color.White;
            this.textBoxLog.ForeColor = System.Drawing.Color.Blue;
            this.textBoxLog.Location = new System.Drawing.Point(634, 42);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(305, 213);
            this.textBoxLog.TabIndex = 5;
            // 
            // tablePanelLegend
            // 
            this.tablePanelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelLegend.AutoSize = true;
            this.tablePanelLegend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelLegend.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanelLegend.ColumnCount = 1;
            this.tablePanelLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelLegend.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tablePanelLegend.Location = new System.Drawing.Point(947, 42);
            this.tablePanelLegend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePanelLegend.Name = "tablePanelLegend";
            this.tablePanelLegend.RowCount = 1;
            this.tablePanelLegend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tablePanelLegend.Size = new System.Drawing.Size(65, 165);
            this.tablePanelLegend.TabIndex = 10;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Controls.Add(this.checkShowColors);
            this.panelButtons.Controls.Add(this.buttonReload);
            this.panelButtons.Controls.Add(this.buttonStopSelected);
            this.panelButtons.Location = new System.Drawing.Point(4, 37);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(313, 223);
            this.panelButtons.TabIndex = 11;
            // 
            // checkShowColors
            // 
            this.checkShowColors.AutoSize = true;
            this.checkShowColors.Checked = true;
            this.checkShowColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowColors.Location = new System.Drawing.Point(28, 22);
            this.checkShowColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkShowColors.Name = "checkShowColors";
            this.checkShowColors.Size = new System.Drawing.Size(124, 24);
            this.checkShowColors.TabIndex = 4;
            this.checkShowColors.Text = "Show Colors";
            this.checkShowColors.UseVisualStyleBackColor = true;
            this.checkShowColors.CheckedChanged += new System.EventHandler(this.checkShowColors_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 635);
            this.Controls.Add(this.tablePanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1039, 662);
            this.Name = "Form1";
            this.Text = "Service Manager";
            this.tablePanelMain.ResumeLayout(false);
            this.tablePanelMain.PerformLayout();
            this.paneldataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelButtom.ResumeLayout(false);
            this.panelButtom.PerformLayout();
            this.tablePanelButtom.ResumeLayout(false);
            this.tablePanelButtom.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonStopSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tablePanelMain;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TableLayoutPanel tablePanelLegend;
        private System.Windows.Forms.TableLayoutPanel tablePanelButtom;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel paneldataGridView;
        private System.Windows.Forms.Panel panelButtom;
        private ServiceManeger.Controls.SortedDataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empty;
        private System.Windows.Forms.CheckBox checkShowColors;
    }
}

