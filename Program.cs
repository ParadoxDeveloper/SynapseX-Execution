using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using sxlib;
using sxlib.Specialized;

namespace SynapseExecution
{
    class Program
    {
          private static SxLibOffscreen SLib;
          private static SxLibBase.SynLoadEvents LoadEvents;
        private static SxLibBase.SynAttachEvents AttachEvents;

         static void Main(string[] args)
        {
            SLib = SxLib.InitializeOffscreen(@"./");
            if (LoadEvents == SxLibBase.SynLoadEvents.READY)
            {
                SLib.Attach();
                if (AttachEvents == SxLibBase.SynAttachEvents.READY)
                {
                    SLib.Execute("return nil");
                }

                return;
            }
            SLib.Load();

        }
        
    }
}