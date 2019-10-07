using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TextHandler
    {

        public char[] Latter_mas
        {
            get;
            set;
        }

        public void set_lang (int i)
        {
            switch (i)
            {
                case 0:
                    Latter_mas = new char[26] {'a','b','c','d','e','f','g','h','i','j','k','l',
                     'm','n','o','p','q','r','s','t','u','v','w','x','y','z' };
                    break;
                case 1:
                    Latter_mas = new char[33] {'а','б','в','г','ґ','д','е','є','ж','з','и','і','ї','й','к','л','м','н','о',
                     'п','р','с','т','у','ф','х','ц','ч','ш','щ','ь','ю','я'};
                    break;
                case 2:
                    Latter_mas = new char[33] {'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о',
                     'п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'};
                    break;
            }
        }

        public List<double> calc(string input_text)
        {
            List<double> percent_mas = new List<double>();
            double count = 0;
            double lenght = 0;

            for (int i = 0; i < Latter_mas.Length; i++)
            {
                for (int j = 0; j < input_text.Length; j++)
                {
                    if (Latter_mas[i] == input_text[j])
                        lenght++;
                }
            }
            for (int i = 0; i < Latter_mas.Length; i++)
            {
                for (int j = 0; j < input_text.Length; j++)
                {
                    if (Latter_mas[i] == input_text[j])
                        count++;
                }
                double result = count / lenght * 100;
                percent_mas.Add(result);
                count = 0;
            }
            return percent_mas;
        }
    }
}
