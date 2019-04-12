using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ten_Thousand_Montelongo {

    public partial class Main : Form {

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            sundayTextBox.Text = "10";
            mondayTextBox.Text = "10";
            tuesdayTextBox.Text = "10";
            wednesdayTextBox.Text = "10";
            thursdayTextBox.Text = "10";
            fridayTextBox.Text = "10";
            saturdayTextBox.Text = "10";
        }

        private void submitButton_Click(object sender, EventArgs e) {

            float targetHours = 10000;

            float.TryParse(sundayTextBox.Text, out float sunday);
            float.TryParse(mondayTextBox.Text, out float monday);
            float.TryParse(tuesdayTextBox.Text, out float tuesday);
            float.TryParse(wednesdayTextBox.Text, out float wednesday);
            float.TryParse(thursdayTextBox.Text, out float thursday);
            float.TryParse(fridayTextBox.Text, out float friday);
            float.TryParse(saturdayTextBox.Text, out float saturday);
            float totalHours = sunday + monday + tuesday + wednesday + thursday + friday + saturday;
            float hoursLeft = targetHours;
            int iterations = 1;



            DateTime today = DateTime.Now;
            TimeSpan oneWeek = new TimeSpan(totalHours, 0, 0);

            do {

                hoursLeft = hoursLeft - totalHours;
                Console.WriteLine($"{iterations} : {hoursLeft}");

                iterations++;

            } while (hoursLeft >= 0);

            for (int i = iterations; i == 0; i--) {
                today.Add
            }

            //DateTime answer = today.Add(duration);

            MessageBox.Show($"{iterations - 1} iterations");

        }
    }
}
