using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;

namespace WebEssentials.BuildTasks.Tester
{
    class Program
    {
        static void Main(string[] args)
		
		
       

        class Engine : IBuildEngine
        {
            public int ColumnNumberOfTaskNode { get { return 0; } }

            public bool ContinueOnError { get { return false; } }

            public int LineNumberOfTaskNode { get { return 0; } }

            public string ProjectFileOfTaskNode { get { throw new NotImplementedException(); } }

            public bool BuildProjectFile(string projectFileName, string[] targetNames, IDictionary globalProperties, IDictionary targetOutputs)
            {
                throw new NotImplementedException();
            }

            public void LogCustomEvent(CustomBuildEventArgs e) { Log(e.Message); }
            public void LogErrorEvent(BuildErrorEventArgs e) { Log(e.Message); }

            public void LogMessageEvent(BuildMessageEventArgs e) { Log(e.Message); }

            public void LogWarningEvent(BuildWarningEventArgs e) { Log(e.Message); }

           
        }
    }
}
