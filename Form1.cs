namespace Test_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }

       
        //�Ǽ��� ���� �̺�Ʈ
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //��ư 1 Ŭ����
        private void button1_Click(object sender, EventArgs e)
        {
           int num = int.Parse(label1.Text);
           num++;
           label1.Text = num.ToString();
        }
    }
}