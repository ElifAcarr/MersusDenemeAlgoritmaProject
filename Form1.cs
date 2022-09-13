using System.Diagnostics.Metrics;

namespace Mersus_Algoritma
{
    public partial class Form1 : Form
    {
        bool cleared = false;
        public Form1()
        {
            InitializeComponent();
        }
        void tarihEkle(string gunDegeri)
        {
            if (!cleared)
            {
                listBox1.Items.Clear();
                cleared = true;
            }

            String cmbselct = comboBoxaralik.SelectedValue.ToString();
            int aralik = Convert.ToInt32(cmbselct.Replace(" Gün", "").Replace(" Hafta", ""));

            var bas = monthCalendarbas.SelectionStart.ToShortDateString();

            var bitis = monthCalendarbitis.SelectionStart.ToShortDateString();
            var bitiss = Convert.ToDateTime(bitis);
            var bass = Convert.ToDateTime(bas);
            var dayname = bass.DayOfWeek.ToString();
            listBox1.Items.Add(gunDegeri);
            if (dayname == gunDegeri)
                listBox1.Items.Add(bas);
            while (true)
            {
                if (cmbselct.Contains(" Gün"))
                    bass = bass.AddDays(aralik);
                else
                    bass = bass.AddDays(aralik * 7);

                var comparison = DateTime.Compare(bitiss, bass) < 0;
                if (comparison)
                    break;
                dayname = bass.DayOfWeek.ToString();
                if (dayname == gunDegeri)
                    listBox1.Items.Add(bass.ToShortDateString());
            }
        }
        private void comboBoxTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> aralik = new List<string>();
            if (comboBoxTarih.SelectedIndex == 0)
            {
                for (int i = 1; i < 32; i++)
                    aralik.Add(i + " Gün");

                comboBoxaralik.DataSource = aralik;
            }
            else
            {
                for (int i = 1; i < 9; i++)
                    aralik.Add(i + " Hafta");
                comboBoxaralik.DataSource = aralik;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxaralik_SelectedIndexChanged(object sender, EventArgs e)
        {
            butonEtkinlestir(true);
            monthCalendarbitis.Enabled = true;
            butonRengi(button1);
            butonRengi(button2);
            butonRengi(button3);
            butonRengi(button4);
            butonRengi(button5);
            butonRengi(button6);
            butonRengi(button7);
            cleared = false;

            String cmbselct = comboBoxaralik.SelectedValue.ToString();
            int aralik = Convert.ToInt32(cmbselct.Replace(" Gün", "").Replace(" Hafta", ""));
            listBox1.Items.Clear();
            var bas = monthCalendarbas.SelectionStart.ToShortDateString();
            listBox1.Items.Add(bas);
            var bitis = monthCalendarbitis.SelectionStart.ToShortDateString();
            var bitiss = Convert.ToDateTime(bitis);
            var bass = Convert.ToDateTime(bas);
            while (true)
            {
                if (cmbselct.Contains(" Gün"))
                    bass = bass.AddDays(aralik);
                else
                    bass = bass.AddDays(aralik * 7);

                var comparison = DateTime.Compare(bitiss, bass) < 0;
                if (comparison)
                    break;
                listBox1.Items.Add(bass.ToShortDateString());
            }

        }

        void butonRengi(Button snd)
        {
            if (snd.BackColor == Color.GreenYellow)
            {
                snd.BackColor = DefaultBackColor;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarihEkle("Monday");
            button1.BackColor = Color.GreenYellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tarihEkle("Tuesday");
            button2.BackColor = Color.GreenYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tarihEkle("Wednesday");
            button3.BackColor = Color.GreenYellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tarihEkle("Thursday");
            button4.BackColor = Color.GreenYellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tarihEkle("Friday");
            button5.BackColor = Color.GreenYellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tarihEkle("Saturday");
            button6.BackColor = Color.GreenYellow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tarihEkle("Sunday");
            button7.BackColor = Color.GreenYellow;
        }

        private void monthCalendarbitis_DateChanged(object sender, DateRangeEventArgs e)
        {
            butonEtkinlestir(true);
            butonRengi(button1);
            butonRengi(button2);
            butonRengi(button3);
            butonRengi(button4);
            butonRengi(button5);
            butonRengi(button6);
            butonRengi(button7);
            cleared = false;

            String cmbselct = comboBoxaralik.SelectedValue.ToString();
            int aralik = Convert.ToInt32(cmbselct.Replace(" Gün", "").Replace(" Hafta", ""));
            listBox1.Items.Clear();
            var bas = monthCalendarbas.SelectionStart.ToShortDateString();
            listBox1.Items.Add(bas);
            var bitis = monthCalendarbitis.SelectionStart.ToShortDateString();
            var bitiss = Convert.ToDateTime(bitis);
            var bass = Convert.ToDateTime(bas);
            while (true)
            {
                if (cmbselct.Contains(" Gün"))
                    bass = bass.AddDays(aralik);
                else
                    bass = bass.AddDays(aralik * 7);

                var comparison = DateTime.Compare(bitiss, bass) < 0;
                if (comparison)
                    break;
                listBox1.Items.Add(bass.ToShortDateString());
            }
        }
        void butonEtkinlestir(bool napim)
        {
            foreach (var c in Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = napim;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            butonEtkinlestir(false);
            monthCalendarbitis.Enabled = false;
        }
    }
}