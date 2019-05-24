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

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            this.orgStr = this.lblResult.Text;

            if (cbList.Items.Count > 0) //cbList가 가지고 있는 아이템 갯수가 0보다 클 때
            {
                this.cbList.SelectedIndex = 0; //콤보박스의 첫번째 값을 보여줘라
            }

              
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e) // 선택하는 인덱스가 바뀌었을 때 실행
        {
            this.lblResult.Text = this.orgStr + this.cbList.Text;
        }

        private void CheckInput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus(); //커서를 사용자 입력 란에 옮기기
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text); //사용자가 txtList(사용자 입력란)에 쓴 텍스트를 cbList에 추가
                this.txtList.Text = ""; //txtList 란 내용 지우기 (reset)
                this.txtList.Focus(); //커서를 사용자 입력 란에 옮기기
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                CheckInput();
                e.Handled = true;
            }
  

        }
    }
}
