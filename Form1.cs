using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(selectToy.SelectedItem != null)
            {
                if(selectToy.SelectedItem.ToString() == "Car")
                {
                    addedToys.Items.Add(new Car());
                }
                if (selectToy.SelectedItem.ToString() == "Submarine")
                {
                    addedToys.Items.Add(new Submarine());
                }
                if (selectToy.SelectedItem.ToString() == "Plane")
                {
                    addedToys.Items.Add(new Plane());
                }
                if (selectToy.SelectedItem.ToString() == "Computer")
                {
                    addedToys.Items.Add(new Computer());
                }
            }
        }

        private void addedToys_Click(object sender, EventArgs e)
        {
            speedParam.Visible = false;
            diveParam.Visible = false;
            heightParam.Visible = false;

            if (addedToys.SelectedItem is IAccelerate)
            {
                speedParam.Visible = true;
                speed.Text = ((IAccelerate)addedToys.SelectedItem).GetCurrentSpeed().ToString();
            }

            if (addedToys.SelectedItem is IDive)
            {
                diveParam.Visible = true;
                dive.Text = ((IDive)addedToys.SelectedItem).GetCurrentDive().ToString();
            }

            if (addedToys.SelectedItem is IRise)
            {
                heightParam.Visible = true;
                height.Text = ((IRise)addedToys.SelectedItem).GetCurrentRise().ToString();

            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            speedParam.Visible = false;
            diveParam.Visible = false;
            heightParam.Visible = false;

            if(addedToys.SelectedItem != null)
            {
                addedToys.Items.Remove(addedToys.SelectedItem);
            }

        }

        private void speedInc_Click(object sender, EventArgs e)
        {
            speed.Text = ((IAccelerate)addedToys.SelectedItem).SpeedIncrease().ToString();
        }

        private void speedDec_Click(object sender, EventArgs e)
        {
            speed.Text = ((IAccelerate)addedToys.SelectedItem).SpeedDecrease().ToString();
        }

        private void diveInc_Click(object sender, EventArgs e)
        {
            dive.Text = ((IDive)addedToys.SelectedItem).DiveIncrease().ToString();
        }

        private void diveDec_Click(object sender, EventArgs e)
        {
            dive.Text = ((IDive)addedToys.SelectedItem).DiveDecrease().ToString();
        }

        private void heightInc_Click(object sender, EventArgs e)
        {
            height.Text = ((IRise)addedToys.SelectedItem).RiseIncrease().ToString();
        }

        private void heightDec_Click(object sender, EventArgs e)
        {
            height.Text = ((IRise)addedToys.SelectedItem).RiseDecrease().ToString();
        }
    }
}
