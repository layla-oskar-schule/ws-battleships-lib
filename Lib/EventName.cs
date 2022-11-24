﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public static class EventName
    {
        public static readonly string SUFFIX = "$";

        // PLAYER EVENTS
        public static readonly string SendUserNameEvent = "p_sendUserName";
        public static readonly string SendGameNameEvent = "p_sendGameName";
        public static readonly string SendPlaceEvent = "p_sendPlace";
        public static readonly string SendFireEvent = "p_sendFire";

        // SERVER EVENTS
        public static readonly string AskUserNameRequest = "s_askUserName";
        public static readonly string AskGameNameRequest = "s_askGameName";
        public static readonly string AskPlaceRequest= "s_askPlace";
        public static readonly string AskFireRequst = "s_askFire";
        public static readonly string SendServerMessageEvent = "s_sendMessage";
        public static readonly string SendGameFieldEvent = "s_sendGameField";

    }
}
