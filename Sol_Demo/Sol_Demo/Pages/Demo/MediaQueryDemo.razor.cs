using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class MediaQueryDemo
    {
        #region State Property

        private bool IsLoading { get; set; }

        #endregion State Property

        #region LifeCycle

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                IsLoading = true;
                base.StateHasChanged();
            }
        }

        #endregion LifeCycle
    }
}