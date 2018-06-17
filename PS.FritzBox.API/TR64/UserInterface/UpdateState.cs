using System;

namespace PS.FritzBox.API.TR64.UserInterface
{
    /// <summary>
    /// enumeration of UpdateState
    /// </summary>
    public enum UpdateState
    {
        STARTED,
        STOPPED,
        ERROR,
        NOUPDATE,
        UPDATEAVAILABLE,
        UNKNOWN
    }
}