using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp {
    internal class Child : Parent {

        public Child() : this(0) {

        }
        public Child(int i) {
            this.Id = i;
        }
    }
}