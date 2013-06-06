﻿using System;

namespace SharpUtils.Consts
{
    public class HeaderKeys
    {
        public const string SCHEME = "Basic";
        public const string ApiUserKeyName = "X-Api-User-Key";
        public const string ApiAuthorizedKeyName = "X-Api-Auth-Key";
        public const string ApiAuthorizedKeyStatusName = "X-Api-Auth-Key-Status";
        public const string ApiPermissionName = "X-Api-Permission";
        public const string ForwardedForKeyName = "X-Forwarded-For";
        public const string ForwardedForApiKeyName = "X-Forwarded-For-Api";
    }
}
