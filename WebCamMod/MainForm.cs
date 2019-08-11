using AForge.Video.DirectShow;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamMod.FiltersFactory;

namespace WebCamMod
{
    public partial class Form1 : Form
    {
        private string _initVideoFilePath;
        private string _audioFilePath;
        private VideoCaptureDevice _device;
        private Dictionary<string, IFilter> _allFilters;

        public Form1()
        {
            InitializeComponent();
            try
            {
                cmbVideoSourceDeviceSelected.DataSource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmbVideoSourceDeviceSelected.SelectedIndex = 0;
                cmbVideoSourceDeviceSelected.DisplayMember = "Name";
                _device = null;
                if (cmbVideoSourceDeviceSelected.Items.Count > 0)
                {
                    var filter = cmbVideoSourceDeviceSelected.SelectedItem as FilterInfo;
                    _device = new VideoCaptureDevice(filter.MonikerString);
                    foreach (var cap in _device.VideoCapabilities)
                    {
                        cmbVideoCapabilities.Items.Add($"{cap.FrameSize.Width}X{cap.FrameSize.Height}");
                    }
                    cmbVideoCapabilities.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка определения устройств воспроизведения:{ex.Message}");
            }

            try
            {
                _allFilters = GetClassByType();
                cmbFilter1.Items.Add("нет");
                cmbFilter1.SelectedIndex = 0;
                cmbFilter2.Items.Add("нет");
                cmbFilter2.SelectedIndex = 0;
                cmbFilter3.Items.Add("нет");
                cmbFilter3.SelectedIndex = 0;
                cmbFilter4.Items.Add("нет");
                cmbFilter4.SelectedIndex = 0;
                cmbFilter5.Items.Add("нет");
                cmbFilter5.SelectedIndex = 0;
                cmbFilter6.Items.Add("нет");
                cmbFilter6.SelectedIndex = 0;
                cmbFilter7.Items.Add("нет");
                cmbFilter7.SelectedIndex = 0;
                cmbFilter8.Items.Add("нет");
                cmbFilter8.SelectedIndex = 0;
                cmbFilter1.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter2.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter3.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter4.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter5.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter6.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter7.Items.AddRange(_allFilters.Keys.ToArray());
                cmbFilter8.Items.AddRange(_allFilters.Keys.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dictionary<string, IFilter> GetClassByType()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IFilter).IsAssignableFrom(p) && !p.IsAbstract && !p.IsInterface).ToList()
                .Select(c => (IFilter)Activator.CreateInstance(c))
                .ToDictionary(c => c.NameUnique(), d => (IFilter)d);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_device != null)
            {
                VideoPlayForm playForm = new VideoPlayForm();
                _device.VideoResolution = _device.VideoCapabilities[cmbVideoCapabilities.SelectedIndex];
                playForm.Device = _device;
                playForm.IsPlayerForFileVisible = false;
                playForm.IsPlayerForWebCamIsVisible = true;
                playForm.IsChangeFilter = chkbxChangeNextFilter.Checked;
                playForm.TimeFilter = Decimal.ToInt32(nudFilterInterval.Value);

                List<IFilter> needFilter = new List<IFilter>();

                if (cmbFilter1.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter1.SelectedItem.ToString()]);
                if (cmbFilter2.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter2.SelectedItem.ToString()]);
                if (cmbFilter3.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter3.SelectedItem.ToString()]);
                if (cmbFilter4.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter4.SelectedItem.ToString()]);
                if (cmbFilter5.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter5.SelectedItem.ToString()]);
                if (cmbFilter6.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter6.SelectedItem.ToString()]);
                if (cmbFilter7.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter7.SelectedItem.ToString()]);
                if (cmbFilter8.SelectedIndex != 0)
                    needFilter.Add(_allFilters[cmbFilter8.SelectedItem.ToString()]);

                playForm.FilterList = needFilter;

                if (!string.IsNullOrEmpty(_initVideoFilePath))
                {
                    playForm.InitVideoFilePath = _initVideoFilePath;
                    playForm.IsPlayerForFileVisible = true;
                    playForm.IsPlayerForWebCamIsVisible = false;
                }
                if(!string.IsNullOrEmpty(_audioFilePath))
                {
                    playForm.AudioFilePath = _audioFilePath;
                }
                playForm.ShowDialog();
            }
        }

        private void btnInitVideoFilePathOpen_Click(object sender, EventArgs e)
        {
            var openFileDlg = new OpenFileDialog();
            if(openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _initVideoFilePath = tbInitVideoFilePath.Text = openFileDlg.FileName;
            }
        }

        private void btnAudioFilePathOpen_Click(object sender, EventArgs e)
        {
            var openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {

                _audioFilePath = tbAudioFilePath.Text = openFileDlg.FileName;
            }
        }
    }
}
