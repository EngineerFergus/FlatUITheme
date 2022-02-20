using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowCase.Core;

namespace ShowCase.ViewModels
{
    public class ButtonsViewModel : ObservableObject
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

        public ButtonsViewModel()
        {
            IsActivated = false;
        }
    }
}
