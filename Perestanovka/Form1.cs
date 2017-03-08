using System;
using System.Windows.Forms;

namespace Perestanovka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            // 1 txtBKey to arrChar
            string strKey = txtBKey.Text;
            Console.WriteLine("some");
            char[] arrCharKey = strKey.ToCharArray();
            // 2 arrChar to columns of DGW
            this.dataGridView1.Columns.Clear();
            foreach (var s in arrCharKey)
            {
                Console.Write(s + " ");
                this.dataGridView1.Columns.Add("s", s.ToString());
            }
            // 3 fill DGW from richTextBox1

            // objavit array of ich texta
            string strIch = richTextBox_ish.Text;
            char[] arrCharIch = strIch.ToCharArray();

            int n = txtBKey.Text.Length; // number of stolbcov = dline of klucha
            int m = richTextBox_ish.Text.Length; // number of strok = dline ich texta / n

            for (int i = 0; i < m; i++) // columns
            {
                for (int j = 0; j < n; j++) // rows
                {
                    dataGridView1.Rows.Add(i + " ");
                    //dataGridView1[0, j].Value = arrCharIch[j];
                    Console.Write("3 point");
                }
            }
            
        }
    }
}
