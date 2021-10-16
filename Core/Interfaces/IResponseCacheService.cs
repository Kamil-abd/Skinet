using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IResponseCacheService
    {
        Task CacheResponseAsync(string casheKey, object response, TimeSpan timeToLive);
        Task<string> GetCachedResponseAsync(string casheKey);
    }
}