using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace UI.Components
{
    public partial class Iterator<T> : ComponentBase
    {
        [Parameter]
        public IEnumerable<T> Items { get; set; }

        [Parameter]
        public RenderFragment<T> ChildContent { get; set; }
    }
}
