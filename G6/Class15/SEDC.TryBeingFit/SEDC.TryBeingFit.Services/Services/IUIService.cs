using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public interface IUIService
    {
        List<string> AccountMenuItems { get; set; }
        List<string> MainMenuItems { get; set; }

        void Welcome(User user);

        int MainMenu(UserRole role);

        int AccountMenu(UserRole role);

        int ChooseMenu<T>(List<T> items);

        int TrainMenu();

        int TrainMenuItems<T>(List<T> items) where T : Training;
        int RoleMenu();
        int LoginMenu();

        void UpgradeToPremium();

        int ChooseEntititesMenu<T>(List<T> entities) where T : IBaseEntity;
    }
}
