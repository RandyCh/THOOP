using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class FrmOOP : Form
    {
        public FrmOOP()
        {
            InitializeComponent();
        }
        ClsBanking x = new ClsBanking();

        private void button1_Click(object sender, EventArgs e)
        {
         //  x  = new ClsBanking();
            MessageBox.Show("x Balance = " + x.Balance);
          
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get Balance
            this.label1.Text = x.Balance.ToString("c2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set Balance
            x.Balance = decimal.Parse(this.textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //public
            button1.Text = "xxxx";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x.Test();
//            x.A(); 嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0122  'ClsBanking.A()' 由於其保護層級之故，所以無法存取。	OOP c:\C# Advanced\OOP\OOP\Form1.cs	50	使用中


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //x.Balance;

            MessageBox.Show(  SystemInformation.ComputerName);

            //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
            //錯誤  CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 其為唯讀 OOP c:\C# Advanced\OOP\OOP\FrmOOP.cs	62	使用中

            //SystemInformation.ComputerName = "xxxx";

            string s  =SystemInformation.ComputerName;

            // x.P1 = 888;
            MessageBox.Show("x.P1 = " + x.P1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            x.P2 = 100;
//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0154 屬性或索引子 'ClsBanking.P2' 無法用在此內容中，因為它缺少 get 存取子。	OOP C:\C# Advanced\OOP\OOP\FrmOOP.cs	82	使用中

//            int w =  x.P2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable table = this.northwindDataSet.Products;

            //DataRow dr = new DataRow();
             DataRow dr  = table.Rows[0];
            MessageBox.Show(dr[0].ToString());

            MessageBox.Show(table.Rows[0][0].ToString());

            //===============================

            MessageBox.Show(this.northwindDataSet.Products[0].ProductName);
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmOOP_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Point> list = new List<Point>();

            list.Add(new Point(100, 100));
            list.Add(new Point(200, 200));
            list.Add(new Point(300, 100));
           // list.Add(888);

            MessageBox.Show(list[1].X + ", " + list[1].Y);

            this.dataGridView1.DataSource = list;
            
        }

        private void button10_Click(object sender, EventArgs e)
        { int i = 100;
            try
               

            {     MessageBox.Show(x[10].ToString());

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x.P3 = 999;
            MessageBox.Show(x.P3.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //x.P4 = 999;
            MessageBox.Show(x.P4.ToString());
        }
   ClsBanking a = new ClsBanking();
        private void button13_Click(object sender, EventArgs e)
        {
         
            a.Deposit(3000);
            this.label4.Text = a.Balance.ToString("c2");

            ClsBanking b = new ClsBanking();
            b.Deposit(2000);
            MessageBox.Show("b balance = " + b.Balance);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                  a.Withdraw(1000);
                this.label4.Text = a.Balance.ToString("c2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button15_Click(object sender, EventArgs e)
        {

            MessageBox.Show("xxx");
            x.Test();
            x.Test(2100, 333);
            x.Test(22);
            x.Test("dfs");


        }

        private void button16_Click(object sender, EventArgs e)
        {
            int n =  x[1];
            int n1 = x["1"];

            //DataRow dr = new DataRow();
            //dr[]
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ClsBanking a = new ClsBanking();
            MessageBox.Show("a balance="+a.Balance);
            ClsBanking b = new ClsBanking(1000);
            MessageBox.Show("b balance=" + b.Balance);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClsBanking a = new ClsBanking();
            a.Deposit(1000);

            a = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            GC.Collect();//強制garbage collection起來回收
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ClsBanking a = new ClsBanking();
            a.Deposit(1000);

            a.dispose();
//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS1674  'ClsBanking': 在 using 陳述式中所用的類型，必須可以隱含轉換成 'System.IDisposable'。	OOP C:\Users\III\Desktop\Starter\1.OOP\OOP\FrmOOP.cs   240 使用中

//            using (ClsBanking a= new ClsBanking())
//            {

//            }//a.dispose




        }

        private void button41_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            MessageBox.Show("count="+count);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 5000; i++)
            {
                ClsMemoryTest x = new ClsMemoryTest();
                //this.label9.Text = ClsMemoryTest.count.ToString();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label9.Text = ClsMemoryTest.count.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //MyPoint pt1 = new MyPoint(99,99);

            //MyPoint pt2 = new MyPoint(1,2,9);
            List<MyPoint> list = new List<MyPoint>();
            //list.Add(pt1);

            //list.Add(pt2);
           
            MyPoint pt3 = new MyPoint { p1 = 1, p2 = 2 };
            MyPoint pt4 = new MyPoint { p1 = 1, p2 = 2,Field1="test", };
            list.Add(pt3);
            list.Add(pt4);
            this.dataGridView2.DataSource = list;
            //使用大括號 就不需要很多建構子方法了 ,直接寫屬性或變數=多少
            //================================================================
            List<MyPoint> mylist = new List<MyPoint>()
                                                           {
                                                                new MyPoint{p1 = 1, p2 = 2},
                                                                new MyPoint{p1 = 2, p2 = 2},
                                                                new MyPoint{p1 = 3, p2 = 2}
                                                            };
            this.dataGridView3.DataSource = mylist;
            //================================================================
            List<ClsBanking> BankingList = new List<ClsBanking>();
            BankingList.Add(new ClsBanking { Balance = 1000, P2 = 1, P3 = 2 });
            BankingList.Add(new ClsBanking { Balance = 10040, P2 = 1, P3 = 2 });
            BankingList.Add(new ClsBanking { Balance = 10400, P2 = 1, P3 = 2 });
            BankingList.Add(new ClsBanking { Balance = 10400, P2 = 1, P3 = 2 });

            this.dataGridView3.DataSource = BankingList;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            //static method=================================
            File.Copy("a.txt"," a1.txt", true);
            //instance method
            FileInfo f = new FileInfo("b.txt");
            MessageBox.Show(f.CreationTime+"\n"+f.FullName+"\n"+f.Extension);
            f.CopyTo("b1.txt", true);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemInformation.ComputerName);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //static class Math
            //static class File
            int n = Math.Abs(-100);
            MessageBox.Show(n.ToString());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClsBanking.InterestRate.ToString());
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //FrmOOP.ActiveForm//後面接靜態方法
            
            this.Text = this.textBox2.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            FrmOOP f = new FrmOOP();
            f.Text = "hello分身" + textBox2.Text;
            f.Show();

            FrmOOP.ActiveForm.Text = "hello分身" + textBox2.Text;
        }
    }
    class MyPoint
    {
        //public MyPoint()
        //{

            
        //}
        //public MyPoint(int p1)
        //{

        //}
        //public MyPoint(int p1, int p2)
        //{
        //    this.p1 = p1;
        //    this.p2 = p2;
        //}
        //public MyPoint(int p1,int p2,int p3)
        //{
        //    this.p1 = p1;
        //    this.p2 = p2;
        //    this.p3 = p3;
        //}
        private int m_p1;
        public int p1
        {
            get
            {
                return m_p1;
            }
            set
            {
                m_p1=value;
            }
        }
        public int p2 { get; set; }
        public int p3 { get; set; }
        public string Field1, Field2;
    }
}
