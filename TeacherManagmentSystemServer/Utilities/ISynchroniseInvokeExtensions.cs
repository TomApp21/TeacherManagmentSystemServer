using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherManagmentSystemServer.Utilities
{
    public static class ISynchroniseInvokeExtensions
    {
        // asking the thread if an invoke is required on this component
        // if so, call the action to the component via invoke
        public static void InvokeExecute<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this }); 
            }
            else
            {
                action(@this);
            }
        }
    }
}
