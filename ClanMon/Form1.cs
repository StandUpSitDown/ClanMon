#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

#endregion

namespace ClanMon
{
    public partial class frmClanMon : Form
    {
        public frmClanMon()
        {
            InitializeComponent();
        }

        public void Subscribe(Clock theClock)
        {
            //can also be written theClock.OnSecondChange += TimeHasChanged
            theClock.OnSecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        //the method that implements the delegated functionality
        public void TimeHasChanged(object theClock, TimeInfoEventArgs ti)
        {
            getCurrentCpuUsage();
            Application.DoEvents();
            getCurrentMemoryUsage();
        }

        public double getCurrentCpuUsage()
        {
            double CpuReading;
            PerformanceCounter CurrentCpuUsage = new PerformanceCounter();
            CurrentCpuUsage.CategoryName = "Processor";
            CurrentCpuUsage.CounterName = "% Processor Time";
            CurrentCpuUsage.InstanceName = "_Total";
            CpuReading = CurrentCpuUsage.NextValue();

            System.Threading.Thread.Sleep(1000);

            CpuReading = CurrentCpuUsage.NextValue();

            lblCpuReading.Text = "CPU usage:" + Math.Round(CpuReading) + "%";

            return CpuReading;
        }

        public double getCurrentMemoryUsage()
        {

            double MemoryReading;
            PerformanceCounter CurrentMemoryUsage = new PerformanceCounter();
            CurrentMemoryUsage.CategoryName = "Memory";
            CurrentMemoryUsage.CounterName = "% Committed Bytes In Use";
            MemoryReading = CurrentMemoryUsage.NextValue();

            lblMemoryReading.Text = "Memory usage:" + Math.Round(MemoryReading) + "%";

            return MemoryReading;
        }

        private void tsmenAppExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ClanMon V1.0 by Nick Clancy");
        }

        private bool mouseIsDown = false;
        private Point firstPoint;

        private void frmClanMon_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void frmClanMon_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void frmClanMon_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int dx = firstPoint.X - e.Location.X;
                int dy = firstPoint.Y - e.Location.Y;

                int x = this.Location.X - dx;
                int y = this.Location.Y - dy;
                this.Location = new Point(x, y);
            }
        }
    }

    public class TimeInfoEventArgs : EventArgs
    {
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
    }

    public class Clock
    {
         
        private int hour;
        private int minute;
        private int second;

        //the delegate the subscribers must implement
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);

        /*an instance of the delegate. The keyword event controls access to the delegate, preventing assignment operators
         *or directly calling this method*/
        public event SecondChangeHandler OnSecondChange;

        //set the clock running, it will raise an event for each new second
        public void Run()
        {
            for (; ; )
            {
                //sleep 500 milliseconds
                Thread.Sleep(500);

                //get the current time
                System.DateTime dt = System.DateTime.Now;

                //if the second has changed notify the subscribers
                if (dt.Second != second)
                {
                    //create the TimeInfoEventArgs object to pass to the subscribers
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    //if anyone has subscribed, notify them
                    if (OnSecondChange != null)
                    {
                        OnSecondChange(
                            this, timeInformation);
                    }
                }

                //Update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
    }
}
