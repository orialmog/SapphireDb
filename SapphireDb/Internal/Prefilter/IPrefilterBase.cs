﻿using System;

namespace SapphireDb.Internal.Prefilter
{
    public interface IPrefilterBase : IDisposable
    {
        void Initialize(Type modelType);

        string Hash();
    }
}
