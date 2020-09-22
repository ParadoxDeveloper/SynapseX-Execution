using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sxlib;
using sxlib.Specialized;

namespace ScriptExecutorSXLIB
{
    class Program
    {
        static void Main(string[] args)
        {
            SLib = SxLib.InitializeOffscreen('./Synapse X.exe');
            SLib.LoadEvent += Ev =>
            {
                if (Ev == SxLibBase.SynLoadEvents.READY)
                {
                    SLib.Attach();
                    if (Ev == SxLibBase.SynAttachEvents.READY)
                    {
                        SLib.Execute('Code Here');


                    }

                }
            };
            SLib.Load();
        }
    }
}
