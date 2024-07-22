namespace Test_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }


        //실수로 만든 이벤트
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        //버튼2 클릭 시
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label1.Text);
            a--;
            label1.Text = a.ToString();
        }
    }
}