﻿using System;

namespace Server.CommonLib.MglServerConfig
{
    /// <summary>
    /// 프로토콜 구분 키
    /// </summary>
    [Flags]
    public enum ProtocolKey
    {
        //default
        NONE = 0,
        ECHO = 1,
        //
    }
}
