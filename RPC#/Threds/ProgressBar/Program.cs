using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp21
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new MyForm(800, 600));
        }
    }

    class MyForm : Form
    {
        private Button buttonStart, buttonStop;
        private CustomProgressBar pb;
        private TextBox tb;
        private MyThread progressBarThread;
        public MyForm(int w, int h)
        {
            this.Text = "My Form";
            this.Size = new Size(w, h);

            buttonStart = new Button();
            buttonStart.Text = "Start";
            buttonStart.SetBounds(10, 10, 100, 25);
            buttonStart.Click += OnClick;

            buttonStop = new Button();
            buttonStop.Text = "Stop";
            buttonStop.SetBounds(130, 10, 100, 25);
            buttonStop.Click += OnClick;

            pb = new CustomProgressBar();
            pb.SetBounds(10, 50, 220, 25);
            pb.Value = 0;
            pb.DisplayStyle = CustomProgressBar.ProgressBarDisplayText.Percentage;

            tb = new TextBox();
            tb.Multiline = true;
            tb.SetBounds(250, 10, 400, 400);

            progressBarThread = new MyThread(buttonStart, pb, tb, Thread.CurrentThread);
            this.FormClosing += FormOnClosing;
            this.Controls.Add(buttonStart);
            this.Controls.Add(buttonStop);
            this.Controls.Add(pb);
            this.Controls.Add(tb);
        }

        public void FormOnClosing(object sender, EventArgs e)
        {
            Console.WriteLine("Form closing and " + progressBarThread.GetThreadState().ToString());
            progressBarThread.halt();
            //progressBarThread.Join();
            //System.Environment.Exit(0);
        }

        public void OnClick(object sender, EventArgs e)
        {
            if (sender == buttonStart)
            {
                if (!progressBarThread.start())
                {
                    if (progressBarThread.GetThreadState() == ThreadState.Running)
                        progressBarThread.halt();
                    else if (progressBarThread.GetThreadState() == ThreadState.Stopped)
                    {
                        progressBarThread = new MyThread(buttonStart, pb, tb);
                        progressBarThread.start();
                    }
                    else
                    {
                        DialogResult r = MessageBox.Show(
                            progressBarThread.GetThreadState().ToString() + "\nCreate new thread and start?",
                            "Thread error.",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Stop);
                        if (r == DialogResult.Yes)
                        {
                            progressBarThread = new MyThread(buttonStart, pb, tb);
                            progressBarThread.start();
                        }
                    }
                }
            }
            else if (sender == buttonStop)
            {
                if ((progressBarThread.GetThreadState() == ThreadState.Running) || 
                        (progressBarThread.GetThreadState() == ThreadState.WaitSleepJoin))
                    progressBarThread.halt();
            }
        }
/*
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose stuff here

            }

            base.Dispose(disposing);
        }*/
    }

    class MyThread
    {
        private CustomProgressBar progressBar;
        private Button button;
        private TextBox textBox;
        private int totalNumberOfChars;
        private double step;
        private Thread t;
        private bool stop = false;
        private Thread form;
        public MyThread(Button b, CustomProgressBar pb, TextBox tb)
        {
            button = b;
            progressBar = pb;
            textBox = tb;
            totalNumberOfChars = textBox.Text.Length;
            step = (double)100 / totalNumberOfChars;
            t = new Thread(run);
        }

        public MyThread(Button b, CustomProgressBar pb, TextBox tb, Thread f)
        {
            button = b;
            progressBar = pb;
            textBox = tb;
            totalNumberOfChars = textBox.Text.Length;
            step = (double)100 / totalNumberOfChars;
            form = f;
            t = new Thread(run);
        }

        public void Join()
        {
            halt();
            t.Join();
        }

        public bool start()
        {
            if (t.ThreadState == ThreadState.Unstarted)
            {
                t.Start();
                return true;
            }
            else return false;
        }

        public ThreadState GetThreadState()
        {
            return t.ThreadState;
        }

        private void run()
        {
            totalNumberOfChars = textBox.Text.Length;
            Console.WriteLine("totalNumberOfChars:" + totalNumberOfChars);
            DisableControls();
            step = (double)100 / totalNumberOfChars;
            for (int i = 0; i < totalNumberOfChars; i++)
            {
                if (!stop)
                {
                    //Console.WriteLine(form.ThreadState.ToString());
                    if (textBox.InvokeRequired)
                    {
                        textBox.Invoke((Action)delegate ()
                        {
                            textBox.Select(0, i);
                        });
                    }
                    else textBox.Select(0, i);

                    if (progressBar.InvokeRequired)
                    {
                        progressBar.Invoke((Action)delegate ()
                        {
                            progressBar.Value = (int)(step * (i + 1));
                        });
                    }
                    Thread.Sleep(10);
                }
                else
                {
                    break;
                }
            }
            releaseControls();
            Thread.Sleep(1000);
        }
        
        private void DisableControls()
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke((Action)delegate ()
                {
                    textBox.ReadOnly = true;
                });
            }
            else textBox.ReadOnly = true;

            if (button.InvokeRequired)
            {
                button.Invoke((Action)delegate ()
                {
                    button.Enabled = false;
                });
            }
            else button.Enabled = false;
        }

        private void releaseControls()
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke((Action)delegate ()
                {
                    progressBar.Enabled = true;
                    progressBar.Value = 0;
                });
            }
            else
            {
                progressBar.Enabled = true;
                progressBar.Value = 0;
            }

            if (textBox.InvokeRequired)
            {
                textBox.Invoke((Action)delegate ()
                {
                    textBox.ReadOnly = false;
                    textBox.DeselectAll();
                });
            }
            else
            {
                textBox.ReadOnly = false;
                textBox.DeselectAll();
            }

            if (button.InvokeRequired)
            {
                button.Invoke((Action)delegate ()
                {
                    button.Enabled = true;
                });
            }
            else button.Enabled = true;
        }

        public void halt()
        {
            stop = true;
        }
    }

    class CustomProgressBar : ProgressBar
    {
        //Property to set to decide whether to print a % or Text
        public ProgressBarDisplayText DisplayStyle { get; set; }

        //Property to hold the custom text
        public String CustomText { get; set; }

        public CustomProgressBar()
        {
            // Modify the ControlStyles flags
            //http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (Value > 0)
            {
                // As we doing this ourselves we need to draw the chunks on the progress bar
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }

            // Set the Display text (Either a % amount or our custom text
            int percent = (int)(((double)this.Value / (double)this.Maximum) * 100);
            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? percent.ToString() + '%' : CustomText;

            using (Font f = new Font(FontFamily.GenericSerif, 10))
            {

                SizeF len = g.MeasureString(text, f);
                // Calculate the location of the text (the middle of progress bar)
                // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                // Draw the custom text
                g.DrawString(text, f, Brushes.Black, location);
            }
        }
        public enum ProgressBarDisplayText
        {
            Percentage,
            CustomText
        }
    }
}
