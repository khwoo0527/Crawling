﻿using System;
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
            
            
            
            for(int i = 0; i < 5; i++)
            {
            Console.WriteLine($"tdevelop {i} 커밋 할꺼임");
            }

            Console.WriteLine("누군가 develope 에서 수정을 막하겠지??");

            

            Console.WriteLine($"비정기 11차 이슈 모두 해결후 푸쉬합니다.");
            
        }
    }
}
