using PS.FritzBox.API.TR64.DeviceConfig;
using System;

namespace PS.FritzBox.API.CMD
{
    public class DeviceConfigClientHandler : ClientHandler
    {
        DeviceConfigService _client;
        private string _configSID;

        public DeviceConfigClientHandler(ConnectionSettings settings, Action<string> printOutput, Func<string> getInput, Action wait, Action clearOutput) : base(settings, printOutput, getInput, wait, clearOutput)
        {
            this._client = new DeviceConfigService(settings);
        }

        public override void Handle()
        {
            string input = string.Empty;

            do
            {
                this.ClearOutputAction();
                this.PrintOutputAction($"DeviceConfigClient{Environment.NewLine}########################");
                this.PrintOutputAction("1 - FactoryReset");
                this.PrintOutputAction("2 - Reboot");
                this.PrintOutputAction("3 - StartConfiguration");
                this.PrintOutputAction("4 - FinishConfiguration");
                this.PrintOutputAction("5 - GetConfigFile");
                this.PrintOutputAction("6 - DownloadConfigFile");
                this.PrintOutputAction("7 - GenerateURLSID");
                this.PrintOutputAction("8 - GetPersistentData");
                this.PrintOutputAction("9 - SetPersistentData");
               
                this.PrintOutputAction("r - Return");

                input = this.GetInputFunc();

                try
                {
                    switch (input)
                    {
                        case "1":
                            this.FactoryReset();
                            break;
                        case "2":
                            this.Reboot();
                            break;
                        case "3":
                            this.StartConfiguration();
                            break;
                        case "4":
                            this.FinishConfiguration();
                            break;
                        case "5":
                            this.GetConfigFIle();
                            break;
                            break;
                        case "7":
                            this.GenerateUrlSID();
                            break;
                        case "8":
                            this.GetPersistentData();
                            break;
                        case "9":
                            this.SetPersistentData();
                            break;
                        case "r":
                            break;
                        default:
                            this.PrintOutputAction("invalid choice");
                            break;
                    }

                    if(input != "r")
                        this.WaitAction();
                }
                catch (Exception ex)
                {
                    this.PrintOutputAction(ex.ToString());
                    this.WaitAction();
                }

            } while (input != "r");
        }  

        /// <summary>
        /// Method to do a factory reset
        /// </summary>
        private void FactoryReset()
        {
            this.PrintEntry();
            this.ClearOutputAction();
            this.PrintOutputAction("Are you sure to reset? (y/n)");
            string result = this.GetInputFunc();

            if (result == "y")
                _client.FactoryResetAsync().GetAwaiter().GetResult();
            else
                this.PrintOutputAction("Reset aborted");
        }

        /// <summary>
        /// Method to reboot the device
        /// </summary>
        private void Reboot()
        {

            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("Are you sure to reboot? (y/n)");
            string result = this.GetInputFunc();

            if (result == "y")
                this._client.RebootAsync().GetAwaiter().GetResult();
            else
                this.PrintOutputAction("Reboot aborted");
        }

        /// <summary>
        /// Method to generate uuid
        /// </summary>
        private void GenerateUUID()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var result = _client.X_GenerateUUIDAsync().GetAwaiter().GetResult();
            this._configSID = result.UUID;
            this.PrintOutputAction($"UUID: {this._configSID}");
        }

        private void StartConfiguration()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.GenerateUUID();

            ConfigurationStartedRequest request = new ConfigurationStartedRequest()
            {
                SessionID = this._configSID
            };
            this._client.ConfigurationStartedAsync(request).GetAwaiter().GetResult();
        }

        private void FinishConfiguration()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var result = this._client.ConfigurationFinishedAsync().GetAwaiter().GetResult();
            this.PrintObject(result);
        }

        private void GetConfigFIle()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("Password: ");
            X_GetConfigFileRequest request = new X_GetConfigFileRequest()
            {
                Password = this.GetInputFunc()
            };
            var result = this._client.X_GetConfigFileAsync(request).GetAwaiter().GetResult();
            this.PrintObject(result);
        }

        private void GenerateUrlSID()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var result = this._client.X_GenerateUUIDAsync().GetAwaiter().GetResult();
            this.PrintOutputAction($"UrlSID: {result.UUID}");
        }

        private void GetPersistentData()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            
            var persistentData = this._client.GetPersistentDataAsync().GetAwaiter().GetResult();
            this.PrintOutputAction($"Persistent Data: {persistentData.PersistentData}");
        }

        private void SetPersistentData()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("New persistent data: ");
            SetPersistentDataRequest request = new SetPersistentDataRequest()
            {
                PersistentData = this.GetInputFunc()
            };
            this._client.SetPersistentDataAsync(request).GetAwaiter().GetResult();
            this.PrintOutputAction("Persistent data written.");
        }
    }

}