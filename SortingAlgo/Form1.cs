using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgo
{
    public partial class Form1 : Form
    {

        DateTime dt1 = new DateTime();

        static int numOfNums = 5;
        int[] numList1 = new int[numOfNums];
        int[] numList2 = new int[numOfNums];
        int[] numList3 = new int[numOfNums];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomiseList();
            displayList();
        }

        void randomiseList()
        {
            Random random = new Random();            
            for (int i = 0; i < numOfNums; i++)
            {
                numList1[i] = random.Next(1,9);
            }

            numList2 = numList1;
            numList3 = numList2;
        }

        void displayList()
        {
            textBox1.Clear();
            foreach(int num in numList1)
            {
                textBox1.AppendText(num + ", ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            randomiseList();
            displayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bubble Sort
            bubbleSortIt();

        }

        void bubbleSortIt()
        {
            int count = 0;
            for (int i = 0; i < numOfNums - 1; i++)
            {
                for (int j = 0; j < numOfNums - 1; j++)
                {
                    if (numList1[j] > numList1[j+1])
                    {
                        int temp = numList1[j];
                        numList1[j] = numList1[j+1];
                        numList1[j+1] = temp;
                    }
                    count++;
                    displayArray(numList1, count);
                }
            }
        }

        void displayArray(int[] list, int count)
        {
            textBox2.AppendText("\r\n" + count + ": ");
            foreach (int num in numList1)
            {
                textBox2.AppendText(num + ", ");
            }
        }
    }
}
