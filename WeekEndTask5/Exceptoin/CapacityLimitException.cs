using System;
using System.Collections.Generic;
using System.Text;

namespace WeekEndTask5.Exceptoin
{
    public class CapacityLimitException:Exception
    {
        private string _message;

        public override string Message => base.Message;

        public CapacityLimitException(string message)
        {
            _message = message;
        }
    }
}
