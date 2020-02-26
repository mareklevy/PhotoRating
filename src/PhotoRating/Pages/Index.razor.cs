using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace PhotoRating.Pages
{
    public partial class Index : ComponentBase
    {
        ViewModels.IndexViewModel vm;

        protected override void OnInitialized()
        {
            this.vm = new ViewModels.IndexViewModel();
        }
    }
}
