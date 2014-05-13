using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boom_Manager_Project.DataBaseClasses
{
    class ErrorsAndWarningsMessages
    {
        private static ErrorsAndWarningsMessages _errorsAndWarningsMessages;

        public static ErrorsAndWarningsMessages ErrorsAndWarningsInstance()
        {
            return _errorsAndWarningsMessages ?? (_errorsAndWarningsMessages = new ErrorsAndWarningsMessages());
        }

        public void GetError(int errorId)
        {
            switch (errorId)
            {
                case 1:
                    break;
                default:
                    break;
            }
        }

        public void ShowWarning(int WarningId)
        {
            switch (WarningId)
            {
                case 1:
                    break;
                default:
                    break;
            }
        }
    }
}
