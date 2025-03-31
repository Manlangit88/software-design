namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] Sorting(int[] num)
        {
            Array.Sort(num);
            return num;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] num = { 3, 1, 5, 2, 4, 10, 8, 7, 9, 6 };
            int[] sortedNum = Sorting(num);
            listBoxView.DataSource = sortedNum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
