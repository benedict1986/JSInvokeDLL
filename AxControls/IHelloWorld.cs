using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AxControls
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("05E5F955-14EF-4080-8740-4901EF6E74ED")]
    public interface IHelloWorld
    {
        string GetText();
    }
}
