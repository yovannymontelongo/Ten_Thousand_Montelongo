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
            answerLabel.Visible = false;
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

            int targetHours = 10000;
            int.TryParse(sundayTextBox.Text, out int sunday);
            int.TryParse(mondayTextBox.Text, out int monday);
            int.TryParse(tuesdayTextBox.Text, out int tuesday);
            int.TryParse(wednesdayTextBox.Text, out int wednesday);
            int.TryParse(thursdayTextBox.Text, out int thursday);
            int.TryParse(fridayTextBox.Text, out int friday);
            int.TryParse(saturdayTextBox.Text, out int saturday);
            int totalHours = sunday + monday + tuesday + wednesday + thursday + friday + saturday;
            int hoursLeft = targetHours;
            int iterations = 1;
            bool possible = false;

            DateTime today = DateTime.Now;
            DateTime answer = today;
            TimeSpan oneWeek = new TimeSpan(7, 0, 0, 0);

            if (sunday > 24 || monday > 24 || tuesday > 24 || wednesday > 24 || thursday > 24 || friday > 24 || saturday > 24) {
                possible = false;
                answerLabel.Visible = true;
                answerLabel.Left = 1;
                answerLabel.Text = "Umm, there aren't more than 24 hours in a day. Sorry about that, I'm not God.";
            } else {
                possible = true;
            }

            while (possible) {
                do {

                    hoursLeft = hoursLeft - totalHours;
                    //Console.WriteLine($"{iterations} : {hoursLeft}");

                    iterations++;

                } while (hoursLeft >= 0);

                iterations--;
                //MessageBox.Show($"{iterations} iterations");

                for (int i = iterations; i >= 0; i--) {
                    answer = answer.Add(oneWeek);
                    //Console.WriteLine($"At this rate, you'll be a pro by {answer}");
                }

                //MessageBox.Show($"At this rate, you'll be a pro by {answer}");
                answerLabel.Visible = true;
                answerLabel.Left = 90;
                answerLabel.Text = $"At this rate, you'll be a pro by {answer}";
                break;
            }

        }
    }
}
