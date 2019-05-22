using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {

        string[] SList = new string[] { "김밥", "샐러드김밥", "야채김밥", "소고기김밥", "계란김밥", "라볶이" };
        string orgStr = ""; //선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
