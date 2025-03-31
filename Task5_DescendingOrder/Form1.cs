namespace Task5_DescendingOrder
{
    public partial class Form1 : Form
    {
       
            private int[] numbers = { 5, 3, 2, 1, 4, 6, 9, 10, 8, 7 };

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                UpdateListBox();
            }

            private void btnSort_Click(object sender, EventArgs e)
            {
                Array.Sort(numbers, new CustomDescendingComparer());

                UpdateListBox();
            }

            private void UpdateListBox()
            {
                listBoxView.Items.Clear();
                foreach (int num in numbers)
                {
                    listBoxView.Items.Add(num);
                }
            }
        }

        public class CustomDescendingComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
        
    }

