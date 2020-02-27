using System.Collections.Generic;

namespace HotChocolate.Types.Selection
{
    internal static class ListHandlers
    {
        public static IReadOnlyList<IListHandler> All { get; } =
            new IListHandler[]
            {
                new FilterHandler(),
                new SortHandler()
            };
    }
}
