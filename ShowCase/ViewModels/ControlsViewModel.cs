using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowCase.Core;

namespace ShowCase.ViewModels
{
    public class ControlsViewModel : ObservableObject
    {
        private bool isActivated;
        public bool IsActivated
        {
            get { return isActivated; }
            set
            {
                if(value != isActivated)
                {
                    isActivated = value;
                    OnPropertyChanged(nameof(IsActivated));
                }
            }
        }

        public ControlsViewModel()
        {
            IsActivated = false;
        }
    }
}
