using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryXTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryX.Memory myProc = new MemoryX.Memory();
            var procName = "Tutorial-x86_64";
            myProc.GetProcessHandle(procName);
        
            long baseAddress = myProc.GetBaseAddress(procName + ".exe");
            long address = baseAddress + 0x002C4A80;
            int[] offsets = new int[] {0x10, 0x18 ,0 , 0x18};

            Console.WriteLine("BaseAddress: {0}", (baseAddress).ToString("X"));
            Console.WriteLine(myProc.ReadMemoryPointerInt(address, offsets));
            
            Console.ReadLine();

        }
    }
}
