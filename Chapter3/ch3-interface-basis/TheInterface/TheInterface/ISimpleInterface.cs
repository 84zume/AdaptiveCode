using System;

namespace TheInterface
{
    public interface ISimpleInterface
    {
        void ThisMethodRequiresImplementations();

        string ThisStringPropertyNeedsImplementingToo
        {
            get;
            set;
        }

        int ThisIntPropertyOnlyNeedsAsGetter
        {
            get;
        }

        event EventHandler<EventArgs> InterfacesCanContainsEventToo;
    }
}