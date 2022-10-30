using System;
using System.Diagnostics;
class Program {
    static void Main(string[] args) {
        Console.WriteLine($"Thread {System.Threading.Thread.CurrentThread.ThreadState}");
      System.Diagnostics.Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
       Process[] localAll = System.Diagnostics.Process.GetProcesses();
      for(int i=0;i<localAll.Length;i++){
        Console.WriteLine(localAll[i].ProcessName);
      }
    }
}
