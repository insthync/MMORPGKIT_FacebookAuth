﻿#if UNITY_STANDALONE && !CLIENT_BUILD
using Cysharp.Threading.Tasks;

namespace MultiplayerARPG.MMO
{
    public partial class BaseDatabase
    {
        public const byte AUTH_TYPE_FACEBOOK = 2;
        public abstract UniTask<string> FacebookLogin(string fbId, string email);
    }
}
#endif