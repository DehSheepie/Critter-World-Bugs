using CritterController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCritters
{
    class ControllerFactory : ICritterControllerFactory
    {
        public string Author => "Christopher Parsons";

        public ICritterController[] GetCritterControllers()
        {
            List<ICritterController> controllers = new List<ICritterController>();
            for (int i = 0; i < 25; i++)
            {
                controllers.Add(new Wanderer("Wanderer" + (i + 1)));
                controllers.Add(new Chaser("Chaser" + (i + 1)));
				controllers.Add(new TestCritter("Jack" + (i + 1)));
            }
            return controllers.ToArray();
        }
    }
}
