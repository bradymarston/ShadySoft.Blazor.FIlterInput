using System;
using System.Collections.Generic;
using System.Text;

namespace ShadySoft.Blazor.FilterInput
{
    public interface IFilterContext
    {
        string FilterText { get; set; }
        int FilteredItemCount { get; }
    }
}
