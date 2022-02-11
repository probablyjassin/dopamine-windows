﻿using Dopamine.Services.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dopamine.Services.Blacklist
{
    public interface IBlacklistService
    {
        Task AddToBlacklistAsync(IList<TrackViewModel> selectedTracks);

        Task RemoveFromBlacklistAsync(BlacklistTrackViewModel blacklistTrack);

        Task RemoveAllFromBlacklistAsync();

        Task<bool> IsInBlacklistAsync(TrackViewModel track);

        event Action<int> AddedTracksToBacklist;
    }
}
