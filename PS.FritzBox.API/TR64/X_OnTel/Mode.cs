using System;

namespace PS.FritzBox.API.TR64.X_OnTel
{
    /// <summary>
    /// enumeration of Mode
    /// </summary>
    public enum Mode
    {
        EUNKNOWN,
        EIMMEDIATELY,
        ESHORTDELAYED,
        ELONGDELAYED,
        EBUSY,
        EPARALLELCALL,
        ENOSIGNAL,
        EVIP,
        EDELAYED,
        EDELAYEDORBUSY,
        EBELLBLOCKADE,
        EDIRECTCALL,
        EOFF
    }
}