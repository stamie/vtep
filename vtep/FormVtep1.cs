using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetID;
namespace vtep
{
    public partial class FormVtep : Form
    {
        private const string NotGood = "Nem megfelelő";
        private const string Good = "Megfelelő";
        private const string Pattern = @"^[A-Z][0-9]{4}$";
        private bool stopButtonClicked = false;
        private bool goButtonClicked = false;
        private bool saveButtonClicked = false;
        private BackgroundWorker backgroundWorkerGoEvent = new BackgroundWorker();
        private BackgroundWorker backgroundWorkerSaveTextEvent = new BackgroundWorker();
        private GetID.GetID Ids;
        public PropertyChangedEventHandler ValueChanged2;
        private string textVtepForm = "";
        public FormVtep()
        {
            InitializeComponent();
            backgroundWorkerGoEvent.DoWork += backgroundWorkerGoEvent_DoWork;
            backgroundWorkerGoEvent.WorkerReportsProgress = true;
            backgroundWorkerSaveTextEvent.DoWork += backgroundWorkerSaveTextEvent_DoWork;
            backgroundWorkerSaveTextEvent.WorkerReportsProgress = true;
        }
        private string isIdValidToString(string value)
        {
            Regex regex = new Regex(Pattern);
            if (regex.IsMatch(value))
            {
                return " " + Good;
            }
            else
            {
                return " " + NotGood;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (this.Ids == null)
            {
                this.Ids = new GetID.GetID();
            }
            if (!backgroundWorkerGoEvent.IsBusy && !this.goButtonClicked) {
                this.Ids.Go();
                this.stopButtonClicked = false;
                this.goButtonClicked = true;
                MessageBox.Show("Go button clicked");
                backgroundWorkerGoEvent.RunWorkerAsync();
            }

        }
        public void backgroundWorkerGoEvent_DoWork(object sender, DoWorkEventArgs e)
        {
            while (this.goButtonClicked)
            {
                Thread.Sleep(50);
                this.Ids_ValueChanged();
                if (this.stopButtonClicked)
                {
                    this.goButtonClicked = false;
                    return;
                }
            }
            return;
        }
        private void Ids_ValueChanged()
        {
            try
            {
                string value = this.Ids.Value;
                if (value != null)
                {
                    this.textVtepForm += Environment.NewLine + value + this.isIdValidToString(value.Trim());
                    this.textVtepForm = this.textVtepForm.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (!this.stopButtonClicked)
            {
                MessageBox.Show("Stop button clicked");
                this.stopButtonClicked = true;
                this.goButtonClicked = false;
                this.textBoxVtep1.Text = this.textVtepForm;
                this.buttonSaveTextBoxVtep1.Enabled = true;
                this.buttonSaveTextBoxVtep1.Visible = true;
                this.Ids.Stop();
            }
        }
        public void backgroundWorkerSaveTextEvent_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileName = "vtep.txt";
                System.IO.File.WriteAllText(fileName, this.textVtepForm);
                MessageBox.Show("File saved as " + fileName);
                this.saveButtonClicked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.saveButtonClicked = false;
            }

            return;
        }
        private void buttonSaveText_Click(object sender, EventArgs e)
        {
            if (!this.saveButtonClicked)
            {
                DialogResult dialogResultSave = MessageBox.Show("Save button clicked");
                this.saveButtonClicked = true;
                backgroundWorkerSaveTextEvent.RunWorkerAsync();
            }
        }
        private void FormVtep_Load(object sender, EventArgs e)
        {

        }

    }
}
