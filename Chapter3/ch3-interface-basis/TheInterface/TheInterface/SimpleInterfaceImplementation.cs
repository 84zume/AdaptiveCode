using System;

namespace TheInterface
{
    public class SimpleInterfaceImplementation : ISimpleInterface
    {

        private int _encapsulatedInt;

        public int ThisIntPropertyOnlyNeedsAsGetter
        {
            get { return _encapsulatedInt; }
            set { _encapsulatedInt = value; }
        }

        public string ThisStringPropertyNeedsImplementingToo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler<EventArgs> InterfacesCanContainsEventToo;

        public void ThisMethodRequiresImplementations()
        {
            throw new NotImplementedException();
        }
    }
}