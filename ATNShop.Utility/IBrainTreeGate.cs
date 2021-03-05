using Braintree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATNShop.Utility
{
    public interface IBrainTreeGate
    {
        IBraintreeGateway CreateGateway();
        IBraintreeGateway GetGateway();
    }
}
