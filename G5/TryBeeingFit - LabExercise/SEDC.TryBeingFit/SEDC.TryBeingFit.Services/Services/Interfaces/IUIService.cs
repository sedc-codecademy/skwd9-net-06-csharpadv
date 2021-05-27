using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
using SEDC.TryBeingFit.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Interfaces
{
    public interface IUIService
    {
        List<string> MainMenuItems { get; set; }
        void Welcome(User user);
        int MainMenu(UserRole role);
        int LogInMenu();
        int RoleMenu();
        int TrainMenu();
        int TrainMenuItems<T>(List<T> trainings) where T : Training;
        int ChooseMenu<T>(List<T> items);
        void UpgradeToPremium();
    }
}
