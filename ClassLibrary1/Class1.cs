using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public DateTime? MyDate { get; set; }

        public void ReplaceMinValue()
        {
            if (MyDate == DateTime.MinValue)
                MyDate = null;
        }
    }
}
