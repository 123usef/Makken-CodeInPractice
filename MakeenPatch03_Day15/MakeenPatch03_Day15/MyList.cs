
namespace MakeenPatch03_Day15
{

    /*
     
     
     
     */
     class MyList<T>
    {
        private T[] Items;

        public MyList()
        {
        }
        public MyList(T items)
        {
            this.Items = new T[] { items };
        }
        // Add : add a member to the array of T
        public void Add(T item)
        {
            if (this.Items is null || this.Items.Length == 0)
            {
                this.Items = new T[] { item };
            }
            else
            {
                int len = this.Items.Length;
                T[] temp = new T[len + 1];
                for (int i = 0; i < Items.Length; i++)
                {
                    temp[i] = Items[i];
                }
                temp[len] = item;
                this.Items = temp;
            }

        }
        public void RemoveAt(int index)
        {
            if(index < 0 || index >= this.Items.Length)
            {
                return;
            }
            int len = this.Items.Length;
            T[] Temp = new T[len - 1];
            for (int i = 0; i < Items.Length; i++)
            {
                if(index == i)
                {
                    continue;
                }
                Temp[i] = Items[i];

            }
            this.Items = Temp;
        }
        public int Count() => this.Items.Length;
        public bool isEmpty() => this.Items.Length == 0 || this.Items is null;
        public void Display()
        {
            Console.Write("[");
            foreach (T item in Items)
            {
                Console.Write($"{item},");
            }
            Console.Write("]");
        }
    }
}
