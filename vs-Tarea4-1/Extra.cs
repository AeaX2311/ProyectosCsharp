using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_Tarea4._1 {
    class Extra <T>where T:new(){
        private T mia = new T();

        ~Extra() {
            mia = default;
        }

    }
}
