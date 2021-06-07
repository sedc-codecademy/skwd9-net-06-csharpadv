using System.Collections.Generic;
using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Services.Services
{
	public interface IUIService
	{
        List<string> MainMenuItems { get; set; }
        List<string> AccountMenuItems { get; set; }
        void Welcome(User user);
		int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity;
		int MainMenu(UserRole role);
        int AccountMenu(UserRole role);
        int TrainMenu();
        int TrainMenuItems<T>(List<T> trainings) where T : Training;

        int ChooseMenu<T>(List<T> items);
		int LogInMenu();
		int RoleMenu();
        void UpgradeToPremium();
    }
}
