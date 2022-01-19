Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Logging

    Public Class Logger

        Public Shared fileLogger As log4net.ILog = log4net.LogManager.GetLogger("FileLogger")
        Public Shared rollingFileLogger As log4net.ILog = log4net.LogManager.GetLogger("RollingLogFileAppender")
        Public Shared consoleLogger As log4net.ILog = log4net.LogManager.GetLogger("ConsoleLogger")
        Public Shared colorConsoleLogger As log4net.ILog = log4net.LogManager.GetLogger("ColorConsoleLogger")
        Public Shared outputDebugStringLogger As log4net.ILog = log4net.LogManager.GetLogger("OutputDebugStringAppender")
        Public Shared mailLogger As log4net.ILog = log4net.LogManager.GetLogger("eMailLogger")

    End Class

End Namespace