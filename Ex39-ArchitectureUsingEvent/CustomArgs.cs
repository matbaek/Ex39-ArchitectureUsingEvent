using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter01
{
    public class CustomArgs : EventArgs
    {
        //implement as described in the class diagram
        public string MessageBefore { get; set; }
        public string MessageAfter { get; set; }

        public CustomArgs(string before, string after)
        {
            //to be implemented
            this.MessageBefore = before;
            this.MessageAfter = after;
        }
    }
}
