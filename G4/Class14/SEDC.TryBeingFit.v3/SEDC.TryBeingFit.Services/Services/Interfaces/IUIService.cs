using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Interfaces
{
    public interface IUIService
    {
        List<string> MainMenuItems { get; set; }
        List<string> AccountMenuItems { get; set; }

        void Welcome(User user);
        int ChooseEntitiesMenu<T>(List<T> entities) where T : IBaseEntity;
        int MainMenu(UserRole role);
        int AccountMenu(UserRole role);
        int TrainMenu();
        int TrainMenuItems<T>(List<T> training) where T : Training;
        int ChooseMenu<T>(List<T> items);
        int LoginMenu();
        int RoleMenu();
        void UpgradeToPremium();
    }
}
