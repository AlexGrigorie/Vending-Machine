﻿using VendingMachine.Business.Interfaces;

namespace VendingMachine.Business.UseCase
{
    internal class TurnOffUseCase : IUseCase
    {
        private readonly ITurnOffService turnOffService;
        private readonly IAuthenticationService authenticationService;

        public string Name => "exit";

        public string Description => "Go to live your life.";

        public bool CanExecute => authenticationService.IsUserLoggedIn;

        public TurnOffUseCase(IAuthenticationService authenticationService, ITurnOffService turnOffService)
        {
            this.authenticationService = authenticationService;
            this.turnOffService = turnOffService;
        }

        public void Execute()
        {
           turnOffService.TurnOff();
        }
    }
}