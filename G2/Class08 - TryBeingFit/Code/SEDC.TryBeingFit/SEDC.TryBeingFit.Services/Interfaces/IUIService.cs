using System.Collections.Generic;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface IUIService
    {
        int ChooseMenuItem(List<string> menuItems);
        int LogInMenu();
        int RoleMenu();
    }
}
