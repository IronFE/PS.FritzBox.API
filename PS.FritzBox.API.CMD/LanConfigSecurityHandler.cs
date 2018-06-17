﻿using PS.FritzBox.API.TR64.LANConfigSecurity;
using System;

namespace PS.FritzBox.API.CMD
{
    public class LanConfigSecurityHandler : ClientHandler
    {
        LANConfigSecurityService _client;

        public LanConfigSecurityHandler(ConnectionSettings settings, Action<string> printOutput, Func<string> getInput, Action wait, Action clearOutput) : base(settings, printOutput, getInput, wait, clearOutput)
        {
            this._client = new LANConfigSecurityService(settings);
        }

        public override void Handle()
        {
            string input = string.Empty;

            do
            {
                this.ClearOutputAction();
                this.PrintOutputAction($"LanConfigSecurityHandler{Environment.NewLine}########################");
                this.PrintOutputAction("1 - GetAnonymousLogin");
                this.PrintOutputAction("2 - GetCurrentUser");
                this.PrintOutputAction("3 - GetInfo");
                this.PrintOutputAction("4 - SetConfigPassword");
                this.PrintOutputAction("r - Return");

                input = this.GetInputFunc();

                try
                {
                    switch (input)
                    {
                        case "1":
                            this.GetAnonymousLogin();
                            break;
                        case "2":
                            this.GetCurrentUser();
                            break;
                        case "3":
                            this.GetInfo();
                            break;
                        case "4":
                            this.SetConfigPassword();
                            break;
                        case "r":
                            break;
                        default:
                            this.PrintOutputAction("invalid choice");
                            break;
                    }

                    if (input != "r")
                        this.WaitAction();
                }
                catch (Exception ex)
                {
                    this.PrintOutputAction(ex.ToString());
                    this.WaitAction();
                }

            } while (input != "r");
        }

        private void GetAnonymousLogin()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var anonymousLogin = this._client.X_GetAnonymousLoginAsync().GetAwaiter().GetResult();
            this.PrintOutputAction($"AnonymousLogin: {anonymousLogin.AnonymousLoginEnabled}");
        }

        private void GetCurrentUser()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var currentUser = this._client.X_GetCurrentUserAsync().GetAwaiter().GetResult();
            this.PrintObject(currentUser);
        }

        private void GetInfo()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var info = this._client.GetInfoAsync().GetAwaiter().GetResult();
            this.PrintObject(info);
        }

        private void SetConfigPassword()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("New password:");
            SetConfigPasswordRequest request = new SetConfigPasswordRequest()
            {
                Password = this.GetInputFunc()
            };
            this._client.SetConfigPasswordAsync(request).GetAwaiter().GetResult();
            this.PrintOutputAction("Password changed.");
        }
    }
}