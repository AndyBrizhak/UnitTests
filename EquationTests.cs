using System;
using System.Collections.Generic;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class EquationTests
    {
        [Test]
        public void Test()
        {
            var result = Solve.Quadratic(1, 10, 16);
        } 
        
        [Test]
                public void Test2()
                {
                    Assert.Throws<Exception>(() =>
                    {
                        Solve.Quadratic(1, 1, 1);
                    });
                } 
                
          [Test]
                  public void Test3()
                  {
//                      var result = Solve.Quadratic(1, 10, 16);
                      var checkpoint1 = dotMemory.Check();
                        //

                        var checkpoint2 = dotMemory.Check(memory =>
                        {
                            Assert.That(memory.GetTrafficFrom(checkpoint1)
                                .Where(obj => obj.Interface.Is<IEnumerable<int>>())
                                .AllocatedMemory.SizeInBytes, Is.LessThan(1000));
                        });



                  }       
    }
}