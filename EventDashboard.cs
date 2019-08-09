using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event_Management
{
    public partial class EventDashboard : Form
    {
        public EventDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Notification();
            newForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newForm = new Notification();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Notification();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Society();
            newForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var newForm = new Society();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new Society();
            newForm.Show();
        }
    }
}
