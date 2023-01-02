using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFforMultipleDB.ViewModels
{
    public class DoStuffs : Command
    {
        public DoStuffs(Action<object> action) : base(action)
        {
        }
    }
}
