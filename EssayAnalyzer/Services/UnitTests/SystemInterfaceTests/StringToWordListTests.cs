using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.ServiceObjects;
using Xunit;

namespace Services.Testing
{
    class StringToWordListTests
    {
        ServerInterface _ServerInterface = new ServerInterface();

        /*
         Test Methodology:
         * Naming:
         *  <Method under test>_<Condition under test>_<Expected outcome>()
         *  {
         *      /// Initialize
         *      Used to set up the condition under test
         *      
         *      /// Test
         *      Call the MUT (method under test)
         *      
         *      /// Assert
         *      Used to assert the expected outcome
         *  }
         */
        
        [Fact]
        public void BadMath()
        {
            /// Initialize
            // Populate the test essay

            /// Test
            // Call the MUT

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(0, 3);
        }
    }
}
