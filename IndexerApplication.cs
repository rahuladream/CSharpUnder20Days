using System;
namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size-1) {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if(index >=0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Rahul";
            names[1] = "Sharad";
            names[2] = "Nimish";
            names[3] = "Ninja";
            names[4] = "Shabnam";
            names[5] = "Shivam";
            names[6] = "Zara";
            for(int i=0; i< IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
