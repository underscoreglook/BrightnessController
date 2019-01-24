using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrightnessController {

    /**
     * This is a very simple program that adjusts the brightness depending on the sunset/sunrise of your zip code.
     * Liberally uses the code from https://www.codeproject.com/Articles/47355/Setting-Screen-Brightness-in-C
     * and from https://www.codeproject.com/Articles/29306/C-Class-for-Calculating-Sunrise-and-Sunset-Times
     * under Licence CPOL 1.02.
     */
    public partial class FormMain : Form {

        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);

        private bool m_initialized = false;
        private Int32 m_hdc;
        private TimeSpan kBufferTime = new TimeSpan(0, 30, 0);
        private string kSavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string kSaveFile = "BrightnessController.dat";

        private void InitializeClass() {
            if (m_initialized)
                return;

            //Get the hardware device context of the screen, we can do
            //this by getting the graphics object of null (IntPtr.Zero)
            //then getting the HDC and converting that to an Int32.
            m_hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();

            m_initialized = true;
        }

        private unsafe bool SetBrightness(short brightness) {
            InitializeClass();

            if (brightness > 255)
                brightness = 255;

            if (brightness < 0)
                brightness = 0;

            tkbBrightness.Value = brightness;

            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;

            for (int j = 0; j < 3; j++) {
                for (int i = 0; i < 256; i++) {
                    int arrayVal = i * (brightness + 128);

                    if (arrayVal > 65535)
                        arrayVal = 65535;

                    *idx = (short)arrayVal;
                    idx++;
                }
            }

            //For some reason, this always returns false?
            bool retVal = SetDeviceGammaRamp(m_hdc, gArray);

            //Memory allocated through stackalloc is automatically free'd
            //by the CLR.

            return retVal;
        }

        private void AutoAdjustBrightness() {
            DateTime date = DateTime.Today;
            bool isSunrise = false;
            bool isSunset = false;
            DateTime sunrise = DateTime.Now;
            DateTime sunset = DateTime.Now;

            var latitude = new SunTimes.LatitudeCoords(0, 0, 0,
                radNorth.Checked ? SunTimes.LatitudeCoords.Direction.North : SunTimes.LatitudeCoords.Direction.South);
            var longitude = new SunTimes.LongitudeCoords(0, 0, 0,
                radWest.Checked ? SunTimes.LongitudeCoords.Direction.West : SunTimes.LongitudeCoords.Direction.East);
            int.TryParse(txtDegLat.Text, out latitude.mDegrees);
            int.TryParse(txtMinLat.Text, out latitude.mMinutes);
            int.TryParse(txtSecLat.Text, out latitude.mSeconds);
            int.TryParse(txtDegLong.Text, out longitude.mDegrees);
            int.TryParse(txtMinLong.Text, out longitude.mMinutes);
            int.TryParse(txtSecLong.Text, out longitude.mSeconds);

            SunTimes.Instance.CalculateSunRiseSetTimes(latitude, longitude, date,
                ref sunrise, ref sunset, ref isSunrise, ref isSunset);

            date = DateTime.Now;
            int brightAmount = 0;
            if (date < sunrise - kBufferTime || date > sunset + kBufferTime) {
                // Night
                brightAmount = tkbNight.Value;
            } else if (sunrise + kBufferTime < date && date < sunset - kBufferTime) {
                // Day
                brightAmount = tkbDay.Value;
            } else {
                // During
                brightAmount = tkbDuring.Value;
            }
            SetBrightness((short)brightAmount);
        }

        private void Toggle(bool isEnabled) {
            tmrMain.Enabled = isEnabled;
            if (!isEnabled) {
                SetBrightness((short)tkbBrightness.Maximum);
            } else {
                AutoAdjustBrightness();
            }
            tkbBrightness.Enabled = !isEnabled;
        }

        public FormMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void btnToTray_Click(object sender, EventArgs e) {
            Hide();
            this.WindowState = FormWindowState.Minimized;
            icoNotify.Icon = new Icon(chkEnable.Checked ? "icon.ico" : "off.ico");
            icoNotify.Visible = true;
        }

        private void FormMain_Load(object sender, EventArgs e) {
            try {
                using (FileStream fs = File.OpenRead(Path.Combine(kSavePath, kSaveFile))) {
                    txtDegLat.Text = fs.ReadByte().ToString();
                    txtMinLat.Text = fs.ReadByte().ToString();
                    txtSecLat.Text = fs.ReadByte().ToString();
                    txtDegLong.Text = fs.ReadByte().ToString();
                    txtMinLong.Text = fs.ReadByte().ToString();
                    txtSecLong.Text = fs.ReadByte().ToString();
                    int datum = fs.ReadByte();
                    radNorth.Checked = datum == 0;
                    radSouth.Checked = datum != 0;
                    datum = fs.ReadByte();
                    radWest.Checked = datum == 0;
                    radEast.Checked = datum != 0;
                    datum = fs.ReadByte();
                    tkbNight.Value = datum;
                    datum = fs.ReadByte();
                    tkbDay.Value = datum;
                    datum = fs.ReadByte();
                    tkbDuring.Value = datum;
                    datum = fs.ReadByte();
                    chkEnable.Checked = datum == 1;
                }
            } catch (FileNotFoundException ex) {
            } catch (DirectoryNotFoundException ex) { }
            
            if (!chkEnable.Checked) {
                SetBrightness((short)tkbBrightness.Maximum);
            } else {
                AutoAdjustBrightness();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            using (FileStream fs = File.Create(Path.Combine(kSavePath, kSaveFile))) {
                byte datum;
                byte.TryParse(txtDegLat.Text, out datum);
                fs.WriteByte(datum);
                byte.TryParse(txtMinLat.Text, out datum);
                fs.WriteByte(datum);
                byte.TryParse(txtSecLat.Text, out datum);
                fs.WriteByte(datum);
                byte.TryParse(txtDegLong.Text, out datum);
                fs.WriteByte(datum);
                byte.TryParse(txtMinLong.Text, out datum);
                fs.WriteByte(datum);
                byte.TryParse(txtSecLong.Text, out datum);
                fs.WriteByte(datum);
                datum = (byte)(radNorth.Checked ? 0 : 1);
                fs.WriteByte(datum);
                datum = (byte)(radWest.Checked ? 0 : 1);
                fs.WriteByte(datum);
                fs.WriteByte((byte)tkbNight.Value);
                fs.WriteByte((byte)tkbDay.Value);
                fs.WriteByte((byte)tkbDuring.Value);
                fs.WriteByte((byte)(chkEnable.Checked ? 1 : 0));
            }
            SetBrightness((short)tkbBrightness.Maximum);
        }
        
        private void tmrMain_Tick(object sender, EventArgs e) {
            AutoAdjustBrightness();
        }

        private void tkbBrightness_Scroll(object sender, EventArgs e) {
            SetBrightness((short)tkbBrightness.Value);
        }

        private void brightnessScroll(object sender, EventArgs e) {
            if (chkEnable.Checked)
                AutoAdjustBrightness();
        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e) {
            Toggle(chkEnable.Checked);
        }

        private void icoNotify_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                chkEnable.Checked = !chkEnable.Checked;
                Toggle(chkEnable.Checked);
                icoNotify.Icon = new Icon(chkEnable.Checked ? "icon.ico" : "off.ico");
            } else {
                Show();
                this.WindowState = FormWindowState.Normal;
                icoNotify.Visible = false;
            }
        }
    }
}
