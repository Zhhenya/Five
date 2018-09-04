using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    class Occasion
    {
        protected static bool occasionOpenFileDialog;
        public static void Init_OccasionOprnFileDialog(bool f)
        {
            occasionOpenFileDialog = f;
        }
        public static bool Get_occasionOpenFileDialog()
        {
            return occasionOpenFileDialog;
        }
    }
}
