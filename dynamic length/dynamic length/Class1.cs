using System;
using System.Collections.Generic;
using System.Text;

namespace dynamic_length
{
    class Class1
    {
        object[] objArray = new object[0];
        
        private void Push(object item)
        {
            object[] pushArray = new object[objArray.Length+1];

            for (int i = 0; i < objArray.Length; i++)
            {
                pushArray[i] = objArray[i];
            }
            pushArray[pushArray.Length - 1] = item;

            objArray = pushArray;

            object Pop()
            {
                object[] popArray = new object[pushArray.Length - 1];
           
                for (int i = 0; i < popArray.Length; i++)
                {
                    popArray[i] = pushArray[i];
           
                }
                object returnValue = pushArray[pushArray.Length - 1];
                pushArray = popArray;
                return returnValue;
            }
        }
        
    }
    
}
