﻿using System.Security.Principal;

namespace LiveDomain.Core.Security
{
    public interface IAuthorizer<T>
    {
        bool Allows(T securable, IPrincipal principal);
    }
}
