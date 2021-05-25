using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Interfaces
{
    public interface IUIService
    {
        int LogInMenu();
        int RoleMenu();
        int ChooseMenu<T>(List<T> items);
    }
}
