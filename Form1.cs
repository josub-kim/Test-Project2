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


        //버튼 1 클릭시
        private void button1_Click(object sender, EventArgs e)
        {
           int num = int.Parse(label1.Text);
           num++;
           label1.Text = num.ToString();
        }
    }
}