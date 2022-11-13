using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlingPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Console.WriteLine("test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("커밋하고 푸쉬가 되고 있는거 맞어?? 깃이랑 깃허브랑은 좀 다른가?");

            Console.WriteLine("CrawlingTest 분기에서 한번 올려볼게요");
            
            // 잘 되넹 그냥 깃이랑은 초큼 다르네엥 회사컴이랑 옵션이 달라서 그런건가??!! 뚜둥
            //test
            for(int i = 0; i < 5; i++)
            {
            Console.WriteLine($"tdevelop {i} 커밋 할꺼임");
            }
        }
    }
}
