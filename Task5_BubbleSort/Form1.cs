namespace Task5_BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] BubbleSort(int[] num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }
            return num;
        }

        private void bTnSort_Click(object sender, EventArgs e)
        {
            int[] num = { 3, 1, 5, 2, 4, 10, 8, 7, 9, 6 };
            int[] sortedNum = BubbleSort(num);
            listBoxView.DataSource = sortedNum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
