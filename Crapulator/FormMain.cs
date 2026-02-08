using CrapEngine;

namespace Crapulator

{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPartyTime_Click(object sender, EventArgs e)
        {
            Add object_add = new Add();

            this.textBoxTotal.Text = object_add.AddTwoNumbers(int.Parse(textBoxFirstNumber.Text), int.Parse(textBoxSecondNumber.Text)).ToString();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Mult object_mult = new Mult();

            this.textBoxTotal.Text =
                object_mult.MultTwoNumbers(
                    int.Parse(textBoxFirstNumber.Text),
                    int.Parse(textBoxSecondNumber.Text)
                ).ToString();
        }

        private void buttonFrom_Click(object sender, EventArgs e)
        {
            From object_from = new From();

            this.textBoxTotal.Text =
                object_from.FromTwoNumbers(
                    int.Parse(textBoxFirstNumber.Text),
                    int.Parse(textBoxSecondNumber.Text)
                ).ToString();
        }

        private void buttonInto_Click(object sender, EventArgs e)
        {
            Into object_into = new Into();

            this.textBoxTotal.Text =
                object_into.IntoTwoNumbers(
                    int.Parse(textBoxFirstNumber.Text),
                    int.Parse(textBoxSecondNumber.Text)
                ).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
