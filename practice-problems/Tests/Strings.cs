using System;
using Xunit;
using practice_problems.Strings;

namespace Tests
{
    public class Strings
    {
        [Fact]
        public void ReverseTest()
        {
            
            string input = "dragon";
            string expected = "nogard";
            string reversed = input.Reverse();
            
            Assert.Equal(expected, reversed);
           
            }
        }
        
    
}
