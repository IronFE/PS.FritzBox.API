using PS.FritzBox.API.TR64.LANDevice.LANEthernetInterfaceConfig;
using System;

namespace PS.FritzBox.API.CMD
{
    public class LANEthernetInterfaceClientHandler : ClientHandler
    {
        LANEthernetInterfaceConfigService _client;

        public LANEthernetInterfaceClientHandler(ConnectionSettings settings, Action<string> printOutput, Func<string> getInput, Action wait, Action clearOutput) : base(settings, printOutput, getInput, wait, clearOutput)
        {
            this._client = new LANEthernetInterfaceConfigService(settings);   
        }

        public override void Handle()
        {
            string input = string.Empty;

            do
            {
                this.ClearOutputAction();
                this.PrintOutputAction($"LANEthernetInterfaceConfig{Environment.NewLine}########################");
                this.PrintOutputAction("1 - GetInfo");
                this.PrintOutputAction("2 - GetStatistics");
                this.PrintOutputAction("3 - SetEnable");
                this.PrintOutputAction("r - Return");

                input = this.GetInputFunc();

                try
                {
                    switch (input)
                    {
                        case "1":
                            this.GetInfo();
                            break;
                        case "2":
                            this.GetStatistics();
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

        private void GetInfo()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var info = this._client.GetInfoAsync().GetAwaiter().GetResult();
            this.PrintObject(info);
        }

        private void GetStatistics()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var statistics = this._client.GetStatisticsAsync().GetAwaiter().GetResult();
            this.PrintObject(statistics);
        }
    }
}