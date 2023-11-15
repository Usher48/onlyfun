namespace onlyfun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] spellen = new string[100];
            spellen[0] = "Ik heb nog nooit";
            spellen[1] = "Dirty Never Have I Ever";
            spellen[2] = "Strip Poker (met een twist)";
            spellen[3] = "Verdubbelen";
            spellen[4] = "Categorieën";
            spellen[5] = "Kernwoorden";
            spellen[6] = "Verhalen vertellen";
            listBox1.Items.Add(spellen[0]);
            listBox1.Items.Add(spellen[1]);
            listBox1.Items.Add(spellen[2]);
            listBox1.Items.Add(spellen[3]);
            listBox1.Items.Add(spellen[4]);
            listBox1.Items.Add(spellen[5]);
            listBox1.Items.Add(spellen[6]);

        }

        private int huidigespel = 0;

        public string HaalHuidigespelOp()
        {
            if (huidigespel >= 0 && huidigespel < listBox1.Items.Count)
            {
                return listBox1.Items[huidigespel].ToString();
            }
            return "Geen spel geselecteerd";
        }

        public void ToonHuidigespel()
        {
            listBox1.Text = HaalHuidigespelOp();
        }

        public void VorigeZender()
        {
            if (huidigespel > 0)
            {
                huidigespel--;
            }
            ToonHuidigespel();
        }

        public void VolgendeZender()
        {
            if (huidigespel < listBox1.Items.Count - 1)
            {
                huidigespel++;
            }
            ToonHuidigespel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VorigeZender();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VolgendeZender();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}