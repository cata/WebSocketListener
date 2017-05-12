﻿using System;

namespace vtortola.WebSockets
{
    public interface ILogger
    {
        bool IsDebugEnabled { get; }
        bool IsWarningEnabled { get; }
        bool IsErrorEnabled { get; }

        void Debug(string message, Exception error = null);
        void Warning(string message, Exception error = null);
        void Error(string message, Exception error = null);
    }
}
