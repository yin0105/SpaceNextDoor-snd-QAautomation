using Microsoft.VisualStudio.TestTools.UnitTesting;


[assembly:Parallelize(Workers = 3, Scope = ExecutionScope.ClassLevel)]


namespace SND
{
   internal  class ParallelConfiguration
    {
        
    }
}
