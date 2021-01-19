using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SystemCollectionsHomework
{
    public class MyList : List<int>
    {
        public new void Sort()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (this[i] > this[j])
                    {
                        var buffer = this[i];
                        this[i] = this[j];
                        this[j] = buffer;
                    }
                }
            }
        }
    }
}
