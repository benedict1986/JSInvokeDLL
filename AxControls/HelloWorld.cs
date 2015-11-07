using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxControls
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("7442B95D-9F7D-422C-9C87-EF01FF042106")]
    [ProgId("AxControls.HelloWorld")]
    [ComDefaultInterface(typeof(IHelloWorld))]
    public class HelloWorld : UserControl, IHelloWorld
    {
        public string GetText()
        {
            return "Hello ActiveX World!";
        }

    }
}
