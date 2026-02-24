using System.ComponentModel;
using System.Dynamic;

namespace VTM_Client_AIF22
{
    internal class IController
    {
        IModel Model { set; }
        IView View { set; }

    }
}