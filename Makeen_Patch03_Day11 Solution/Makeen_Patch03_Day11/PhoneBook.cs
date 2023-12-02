using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;

namespace Makeen_Patch03_Day11
{
    class PhoneBook
    {
        #region attributes
        //its by default is a Private Member
        public static int cnt;
        string[] Names;
        long[] Numbers;
        int size;

        #endregion
        #region Constructor

        public PhoneBook(int size)
        {
            
            this.size = size;
            this.Names = new string[size];
            this.Numbers = new long[size];
        } 
        #endregion

        public int GetSize()
        {
            return this.size;
        }
        public void addPerson(string Name , long Number)
        {
            this.Names[cnt] = Name;
            this.Numbers[cnt] = Number;
            cnt += 1;
        }

        public void GetAll()
        {
            Console.WriteLine("*-------------------------*");
            for (int i = 0; i < size; i++)
            {
                if (this.Names[i] != null)
                    Console.WriteLine($"{i+1} - || {this.Names[i]} || {this.Numbers[i]}");
            }
        }

        //obj. ==> cw(obj[]) ==> value ==>>  I am Accessing
        //          obj[idx] = 123
        #region indexer
        //cw(myphone[string name]) ==> value 
        // myphone= 123456 ==> assign 
        public long this[string name , bool flag =false]
        {
            get
            {
                for (int i = 0; i < this.size; i++)
                {
                    if (Names[i] == name)
                    {
                        return Numbers[i];
                    }
                }
                return 0;
            }
            set
            {
                // add new || edit old || (add && edit)
                // your logic 
                if (!flag)
                {   // add new 
                    this.Names[cnt] = name;
                    this.Numbers[cnt] = value;
                    cnt += 1;
                }
                else
                {
                    for (int i = 0; i < this.size; i++)
                    {
                        if (this.Names[i] == name)
                        {
                          // obj["yousif"] = 0123456789
                            this.Numbers[i] = value;
                        }
                    }
                }
    
            }
        }
        #endregion



        #region GetNumber

        public long GetNumber(string name)
        {

            for (int i = 0; i < this.size; i++)
            {
                if (Names[i] == name)
                {
                    return Numbers[i];
                }
            }
            // not Found 
            return -1;
        }

        #endregion

        #region EditNumber

        public void EditNumber(string name, long number)
        {
            bool isedited = false;
            for (int i = 0; i < size; i++)
            {
                if (Names[i] == name)
                {
                    this.Numbers[i] = number;
                    Console.WriteLine($" {Names[i]} is Updated with Number {Numbers[i]}");
                    isedited = true;
                }

            }
            if (!isedited)
            {
                Console.WriteLine("not FOUND");
            }
        } 
        #endregion




    }
}
