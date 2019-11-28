using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Management;
using ServiceManeger;
using System.Diagnostics;
using System.Threading.Tasks;
using ServiceManeger.Extensions;
using ServiceManeger.Controls;

namespace ServiceManeger
{
    public partial class ServiceManagerForm : Form
    {
        // Holds colors for services (dataGridView rows) according to 
        // service StartupMode and service Status.
        private Dictionary<string,Color> ServiceColorDictionary =
            new Dictionary<string,Color>(){
            {"Disabled",           Color.FromArgb(170, 170, 170)},
            {"Manual and Stopped", Color.FromArgb(212, 212, 212)},
            {"Manual and Running", Color.FromArgb(170, 255, 170)},
            {"Auto and Stopped",   Color.FromArgb(255, 212, 212)},
            {"Auto and Running",   Color.FromArgb(255, 255, 255)},
            {"Other",              Color.FromArgb(255, 255, 0)},};

        // Get the color for a services (dataGridView rows)
        // from ColorDictionary.
        private Color GetServiceColor(CustomServiceController service)
        {
            if (service.StartupMode == "Disabled")
                return ServiceColorDictionary["Disabled"];
            if (service.StartupMode == "Manual" && service.Status == ServiceControllerStatus.Stopped)
                return ServiceColorDictionary["Manual and Stopped"];
            if (service.StartupMode == "Manual" && service.Status == ServiceControllerStatus.Running)
                return ServiceColorDictionary["Manual and Running"];
            if (service.StartupMode == "Auto" && service.Status == ServiceControllerStatus.Stopped)
                return ServiceColorDictionary["Auto and Stopped"];
            if (service.StartupMode == "Auto" && service.Status == ServiceControllerStatus.Running)
                return ServiceColorDictionary["Auto and Running"];

            return Color.Yellow;
        }

        // Get a Dictionary with Key = ID and Value = service
        readonly ServiceDictionary ServiceDictionary = new ServiceDictionary();

        public ServiceManagerForm()
        {
            InitializeComponent();

            this.EnebleDoubleBuffer();
            
            Text += " v" + FileVersionInfo.GetVersionInfo(
                System.Reflection.Assembly.GetExecutingAssembly().Location)
                .FileVersion;

            this.ActiveControl = buttonReload;

            // Set service color legend on the form problematically.
            InitLegend();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Load all services data on the current windows OS.
            LoadServices();
        }
        // Sets service color legend on the form problematically.
        private void InitLegend()
        {
            const int LabelColorPadding = 4;

            tablePanelLegend.Controls.Clear();
            tablePanelLegend.RowStyles.Clear();
            tablePanelLegend.ColumnStyles.Clear();

            tablePanelLegend.RowCount = ServiceColorDictionary.Count;
            tablePanelLegend.ColumnCount = 2;
            tablePanelLegend.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tablePanelLegend.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            Label labelName, labelColor;
            int row = 0;
            foreach (KeyValuePair<string, Color> color in ServiceColorDictionary)
            {
                labelName = new Label()
                {
                    Text = color.Key,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Anchor = AnchorStyles.Right,
                    AutoSize = true,
                    Margin = new Padding(LabelColorPadding)
                };

                labelColor = new Label()
                {
                    BackColor = color.Value,
                    BorderStyle = BorderStyle.FixedSingle,
                    Anchor = AnchorStyles.None,
                    AutoSize = false,
                    Margin = new Padding(LabelColorPadding)
                };

                labelColor.Width = labelColor.Height;

                tablePanelLegend.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tablePanelLegend.Controls.Add(labelName, 0, row);
                tablePanelLegend.Controls.Add(labelColor, 1, row);
                
                ++row;
            }

            // After initializing legend, do this to ensure that 
            // tablePanelButtom will auto resize bottom row according
            // To the legend cell
            AnchorStyles anchorStyles = AnchorStyles.None;

            textBoxDescription.Anchor = anchorStyles;
            textBoxDescription.Height = 0;
            textBoxLog.Anchor = anchorStyles;
            textBoxLog.Height = 0;
            panelButtons.Anchor = anchorStyles;
            panelButtons.Height = 0;

            anchorStyles =
                AnchorStyles.Top | AnchorStyles.Left |
                AnchorStyles.Bottom | AnchorStyles.Right;

            textBoxDescription.Anchor = anchorStyles;
            textBoxLog.Anchor = anchorStyles;
            panelButtons.Anchor = anchorStyles;
        }

        // Adjust the column width of dataGridView.
        // Called in dataGridView_Resize and OnLoad events.
        //private void dataGridViewResize()
        //{
        //    DataGridViewColumn lastColumn = dataGridView.Columns[dataGridView.ColumnCount - 1];
        //    int totalWidth = 0;
        //    lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        //    foreach (DataGridViewColumn column in dataGridView.Columns)
        //    {
        //        if (colomn.Visible)
        //            totalWidth += colomn.Width;
        //    }
        //    if (totalWidth < dataGridView.ClientSize.Width)
        //        lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //}

        // Loads all services data on the current windows OS
        private void LoadServices()
        {
            textBoxLog.Text = "Loading service data...";
  
            textBoxLog.Refresh();
            dataGridView.Rows.Clear();
            Refresh();
            this.Cursor = Cursors.WaitCursor;

            Task loadSerivicesTask = new Task(new Action(() =>
            {
                ServiceDictionary.Load();

                this.BeginInvoke(new Action( ()=>
                {
                    DisplayServices();
                    this.Cursor = Cursors.Default;
                }));
            }));

            loadSerivicesTask.Start();
        }

        private void DisplayServices()
        {
            dataGridView.SuspendLayout();

            // Fore better performance, set all columns AutoSizeMode to ColumnHeader
            // before reloading dataGridView.
            for (int i = 0; i < dataGridView.ColumnCount - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            int RowIndex;

            foreach (KeyValuePair<int, CustomServiceController> service in ServiceDictionary)
            {
                RowIndex = dataGridView.Rows.Add();
                dataGridView[Key.Name, RowIndex].Value = service.Key;
                dataGridView[Stop.Name, RowIndex].Value = false;
                dataGridView[DisplayName.Name, RowIndex].Value = service.Value.DisplayName;
                dataGridView[ServiceName.Name, RowIndex].Value = service.Value.ServiceName;
                dataGridView[Status.Name, RowIndex].Value = service.Value.Status;
                dataGridView[StartMode.Name, RowIndex].Value = service.Value.StartupMode;
                dataGridView[Type.Name, RowIndex].Value = service.Value.ServiceType;
            }

            // Reset all columns to desired AutoSizeMode.
            for (int i = 0; i < dataGridView.ColumnCount - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dataGridView.Sort(DisplayName, ListSortDirection.Ascending);
            dataGridView.Sort(StartMode, ListSortDirection.Ascending);

            dataGridView.ResumeLayout(true);

            textBoxLog.Text = "";

            Refresh();
        }

        // Gets the checked services from dataGridView and stops them.
        private void StopSelected()
        {
            // Put the checked services in stopList.
            List<CustomServiceController> stopList = new List<CustomServiceController>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if ( (bool)dataGridView[Stop.Index, i].Value )
                {
                    int key = (int)dataGridView[Key.Index, i].Value;
                    stopList.Add(ServiceDictionary[key]);
                }
            }

            // Stop the services in stopList.
            foreach (CustomServiceController service in stopList)
            {
                if (service.CanStop)
                {
                    service.Stop();
                    textBoxLog.Text = "Stoping service " + service.ServiceName + "...";
                    this.Refresh();
                    service.WaitForStatus(ServiceControllerStatus.Stopped,new TimeSpan(0,0,30));
                }
                textBoxLog.Text = "";
                this.Refresh();
            }
        }

        // Claers selected row and description text-box
        //(Used when dataGridView lost focus or dataGridView loaded)
        private void ClearSelection()
        {
            dataGridView.ClearSelection();
            textBoxDescription.Text = "";
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void buttonStopSelected_Click(object sender, EventArgs e)
        {
            StopSelected();
            LoadServices();
        }

        // Paint celles acordig to service color.
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (checkShowColors.Checked)
            {
                if (e.RowIndex > -1 && dataGridView[Key.Index, e.RowIndex].Value != null)
                {
                    int key = (int)dataGridView[Key.Index, e.RowIndex].Value;
                    CustomServiceController service = ServiceDictionary[key];
                    e.CellStyle.BackColor = GetServiceColor(service);
                }
            }
        }

        // Clear dataGridView selected row when ataGridView losesfocos.
        private void dataGridView_Leave(object sender, EventArgs e)
        {
            ClearSelection();
        }

        // When a valid row is selected, show service disctiption in the disctiption text-box.
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.Focused &&
                dataGridView.SelectedRows.Count == 1 &&
                dataGridView.SelectedRows[0].Cells[Key.Index].Value != null)
            {
                int key = (int)dataGridView.SelectedRows[0].Cells[Key.Index].Value;
                textBoxDescription.Text = ServiceDictionary[key].Description;
            }
            else
            {
                ClearSelection();

            }
        }

        // If checkShowColors is checked, dataGridView celles are painted
        // acording to service colors (in dataGridView_CellPainting event).
        // If checkShowColors is unchecked, dataGridView celles are painted
        // withe dataGridView's defualt. When checkShowColors changes,
        // dataGridView is refreshed to get the desired effect.
        private void checkShowColors_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView.Refresh();
        }
        
    }
}
