using System;

namespace DataLayer
{

    public interface IFeedsRepository<T>
    {
        Feeds GetFeeds(String url);

    }

}
