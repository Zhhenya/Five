using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Курсовая_работа
{
    class Neuron//простейший персептрон
    {
        protected static byte[] neur;
        protected static int[] weight;//вес
        protected static int bias;//порог
        public static void Init(byte[] Neur, int widht, int height)
        {
            neur = new byte[widht * height];
            neur = Neur;
        }

        public static void Init_Weight(int size)//инициализация весов
        {
            weight = new int[size];
            for (int i = 0; i < size; i++)
                weight[i] = 0;
        }

        public static void Weight_(int[] W)
        {
            weight = new int[W.Length];
            weight = W;
        }

        public static int[] Get_Weight()
        {
            return weight;
        }

        public static void Init_bias(int b)
        {
            bias = b;
        }

        //подсчет весов
        public static bool Count_weight(Form1 F)
        {
            int net = 0;

            for (int i = 0; i < neur.Length; i++)
                net += neur[i] * weight[i];
            if (net >= bias)
            {
                F.Set_Label("Это 5");
                return true;
            }
            else
            {
                F.Set_Label("Это не 5");
                return false;
            }
        }

        //уменьшение весов
        public static void Decrease_weight()
        {
            for (int i = 0; i < neur.Length; i++)
            {
                if (neur[i] == 1)
                    weight[i] -= 1;
            }
        }

        //увеличение весов
        public static void Increase_weight()
        {
            for (int i = 0; i < neur.Length; i++)
            {
                if (neur[i] == 1)
                    weight[i] += 1;
            }
        }
        //обучение 
        public static int Training(bool f, Form1 F)
        {      
            if (!f)
            {
                if (Count_weight(F))
                    Decrease_weight();
   
                return 1;
            }
            if (f)
            {
                if (!Count_weight(F))
                    Increase_weight();
                return 0;
            }

            return -1;
        }
    }
}
