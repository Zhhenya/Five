using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Курсовая_работа
{
    class IOF
    {
        protected static int[] weight;
        //для обучения
        public static void Init_Weight()
        {
            weight = new int[Neuron.Get_Weight().Length];
            weight = Neuron.Get_Weight();
        }
        //для обучения
        public static void Save_Weight()
        {
            Init_Weight();
            StreamWriter streamWriter = new StreamWriter("Weight1.dat");
            streamWriter.AutoFlush = true;
            for (int i = 0; i < weight.Length; i++)
                streamWriter.WriteLine(weight[i]);
            streamWriter.Close();
        }
        //для проверки
        public static void Init_Weight_for()
        {
            weight = new int[Image.Get_Height() * Image.Get_Widht()];
        }

        //для проверки
        public static void Read_Weight()
        {
            Init_Weight_for();
            StreamReader streamReader = new StreamReader("Weight1.dat");
            for (int i = 0; i < weight.Length; i++)
                weight[i] = Convert.ToInt32(streamReader.ReadLine());
            streamReader.Close();
        }
        public static int[] Get_Weight()
        {
            return weight;
        }
    }
}
