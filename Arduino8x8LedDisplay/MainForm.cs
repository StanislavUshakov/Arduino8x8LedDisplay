using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino8x8LedDisplay
{
    public partial class MainForm : Form
    {
        private enum ArduinoStatus
        {
            Connected,
            Connecting,
            Disconnected
        }

        private SerialPort _arduinoPort;
        private ArduinoStatus _status;
        private int _count = 8;
        private int _size = 25;
        private Bitmap _image;
        private bool[,] _pixels;

        //fonts
        private FontFamily _pixelFont;

        public MainForm()
        {
            InitializeComponent();
            cbAvailablePorts.Items.AddRange(SerialPort.GetPortNames());
            cbAvailablePorts.SelectedIndex = 0;
            _status = ArduinoStatus.Disconnected;
            _image = new Bitmap(pbGrid.Size.Width, pbGrid.Size.Height);
            pbGrid.Image = _image;
            _pixels = new bool[_count, _count];

            SetupFont();
            ShowGrid();
        }

        #region Event Handlers

        private void btConnect_Click(object sender, EventArgs e)
        {
            _status = ArduinoStatus.Connecting;
            UpdateFormByStatus();
            _arduinoPort = new SerialPort(cbAvailablePorts.SelectedItem.ToString());
            try
            {
                _arduinoPort.Open();
                _status = ArduinoStatus.Connected;
                UpdateFormByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbStatus.Text = "Status: Error";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_status == ArduinoStatus.Connected)
            {
                _arduinoPort.Close();
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _arduinoPort.Close();
                _status = ArduinoStatus.Disconnected;
                UpdateFormByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbStatus.Text = "Status: Error";
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                for (int i = 0; i < tbInput.Text.Length; i++)
                {
                    Fill(false);
                    PrintCharacter(tbInput.Text[i]);
                    Thread.Sleep(500);
                }
            });
        }

        private void pbGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (_status != ArduinoStatus.Connected)
                return;

            int x = e.X / _size;
            int y = e.Y / _size;

            SetPixel(x, y);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Fill(false);
        }

        private void btFill_Click(object sender, EventArgs e)
        {
            Fill(true);
        }

        #endregion

        #region Private Methods

        private void UpdateFormByStatus()
        {
            switch (_status)
            {
                case ArduinoStatus.Connected:
                    lbStatus.Text = "Status: Successfully connected";
                    btConnect.Enabled = false;
                    btClear.Enabled = true;
                    btFill.Enabled = true;
                    btDisconnect.Enabled = true;
                    tbInput.Enabled = true;
                    btPrint.Enabled = true;
                    break;

                case ArduinoStatus.Connecting:
                    lbStatus.Text = "Status: Connecting";
                    break;

                case ArduinoStatus.Disconnected:
                    lbStatus.Text = "Status: Disconnected";
                    btConnect.Enabled = true;
                    btClear.Enabled = false;
                    btFill.Enabled = false;
                    btDisconnect.Enabled = false;
                    tbInput.Enabled = false;
                    btPrint.Enabled = false;
                    break;
            }
        }

        private void ShowGrid()
        {
            Graphics g = Graphics.FromImage(_image);
            Pen pen = new Pen(Color.Black);
            for (int i = 0; i <= _count; i++)
            {
                g.DrawLine(pen, i * _size, 0, i * _size, _image.Height);
                g.DrawLine(pen, 0, i * _size, _image.Width, i * _size);
            }
        }

        private void SetPixel(int x, int y, bool? on = null)
        {
            Graphics g = Graphics.FromImage(_image);
            Color color;

            if (on.HasValue)
            {
                _pixels[x, y] = on.Value;
            }
            else
            {
                _pixels[x, y] = !_pixels[x, y];
            }

            if (_pixels[x, y])
            {
                color = Color.Red;
            }
            else
            {
                color = Color.White;
            }

            SendToArduino((byte)x, (byte)y, _pixels[x, y]);
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, x * _size + 1, y * _size + 1, _size - 1, _size - 1);

            if (pbGrid.InvokeRequired)
            {
                pbGrid.Invoke((Action)(() => pbGrid.Refresh()));
            }
            else
            {
                pbGrid.Refresh();
            }
        }

        private void SendToArduino(byte x, byte y, bool turnOn)
        {
            byte[] buffer = new byte[3];
            buffer[0] = y;
            buffer[1] = x;
            buffer[2] = (byte)(turnOn ? 1 : 0);
            _arduinoPort.Write(buffer, 0, 3);
        }

        private void PrintCharacter(char ch)
        {
            //use pixel font
           Font regFont = new Font(_pixelFont, 8, FontStyle.Regular, GraphicsUnit.Pixel);
           Bitmap t = new Bitmap(8, 8);
           Graphics g = Graphics.FromImage(t);
           PointF pointF = new PointF(0, -1);
           g.DrawString(ch.ToString(), regFont, new SolidBrush(Color.Black), pointF);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var p = t.GetPixel(i, j);
                    if (t.GetPixel(i, j).A == 255)
                    {
                        SetPixel(i, j);
                    }
                }
            }
        }

        private void Fill(bool isOn)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    SetPixel(i, j, isOn);
                }
            }
        }

        private void SetupFont()
        {
            FontFamily[] fontFamilies;
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile(Directory.GetCurrentDirectory() + "\\Resources\\Minecraftia-Regular.ttf");
            fontFamilies = privateFontCollection.Families;
            _pixelFont = fontFamilies[0];
        }

        #endregion
    }
}
