using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int test = 1;
            string str;
            int[] ahoaho = new int[3];


            Console.WriteLine("Hello! C# World!");
            Console.WriteLine("Number:{0}",test);
            Console.WriteLine("てきとーな文字列を入力してください");
            str = Console.ReadLine();
            Console.WriteLine("Inputted:{0}", str);
            test = int.Parse(str);
            Console.WriteLine("Parsed:{0}", test);

            for(test = 0;test<3;test++)
            {
                ahoaho[test] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0} {1} {2}", ahoaho[0] ,ahoaho[1], ahoaho[2]);
            */

            Ham IMX = new Ham();

            IMX.WriteCallsign();
            IMX.ReadCallsign();

        }
    }

    class Ham
    {
        private int Band;
        private string callsign;

       public void WriteCallsign()
       {
           callsign = Console.ReadLine();
       }

       public void ReadCallsign()
       {
           Console.WriteLine(callsign);
       }
    }

    class botan
    {
        void botan()
        {
            DialogResult result = MessageBox.Show(
                "ボタンを押してください。", "",
                MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "[はい] が押されました", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(
                    "[いいえ] が押されました", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
