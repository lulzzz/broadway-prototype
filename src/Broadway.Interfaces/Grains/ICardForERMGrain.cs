﻿using System.Threading.Tasks;

using NuClear.Broadway.Interfaces.Models;

namespace NuClear.Broadway.Interfaces.Grains
{
    public interface ICardForERMGrain : IStateProjectorGrain
    {
        Task UpdateStateAsync(CardForERM cardForErm);
    }
}