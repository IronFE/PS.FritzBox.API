﻿using PS.FritzBox.API.TR64.LANDevice.LANHostConfigManagement;
using System;
using System.Net;

namespace PS.FritzBox.API.CMD
{
    internal class LANHostConfigManagementClientHandler : ClientHandler
    {
        LANHostConfigManagementService _client;

        public LANHostConfigManagementClientHandler(ConnectionSettings settings, Action<string> printOutput, Func<string> getInput, Action wait, Action clearOutput) : base(settings, printOutput, getInput, wait, clearOutput)
        {
            this._client = new LANHostConfigManagementService(settings);
        }

        public override void Handle()
        {
            string input = string.Empty;

            do
            {
                this.ClearOutputAction();
                this.PrintOutputAction($"LANHostConfigManagement{Environment.NewLine}########################");
                this.PrintOutputAction("1 - GetInfo");
                this.PrintOutputAction("2 - GetSubnetMask");
                this.PrintOutputAction("3 - GetIPInterfaceNumberOfEntries");
                this.PrintOutputAction("4 - GetAddressRange");
                this.PrintOutputAction("5 - GetDNSServers");
                this.PrintOutputAction("6 - GetIPRouters");
                this.PrintOutputAction("7 - SetSubnetMask");
                this.PrintOutputAction("8 - SetAddressRange");
                this.PrintOutputAction("9 - SetDHCPServerEnable");

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
                            this.GetSubnetMask();
                            break;
                        case "3":
                            this.GetIPInterfaceNumberOfEntries();
                            break;
                        case "4":
                            this.GetAddressRange();
                            break;
                        case "5":
                            this.GetDNSServers();
                            break;
                        case "6":
                            this.GetIPRouters();
                            break;
                        case "7":
                            this.SetSubnetMask();
                            break;
                        case "8":
                            this.SetAddressRange();
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

        private void GetSubnetMask()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var subnetMask = this._client.GetSubnetMaskAsync().GetAwaiter().GetResult();
            this.PrintOutputAction($"Subnetmask: {subnetMask}");
        }

        private void GetIPInterfaceNumberOfEntries()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var count = this._client.GetIPInterfaceNumberOfEntriesAsync().GetAwaiter().GetResult();
            this.PrintOutputAction($"Interface count: {count}");
        }

        private void GetAddressRange()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var range = this._client.GetAddressRangeAsync().GetAwaiter().GetResult();
            this.PrintObject(range);
        }

        private void GetDNSServers()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var servers = this._client.GetDNSServersAsync().GetAwaiter().GetResult();
            this.PrintObject(servers);
        }

        private void GetIPRouters()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var servers = this._client.GetIPRoutersListAsync().GetAwaiter().GetResult();
            this.PrintObject(servers);
        }

        private void SetSubnetMask()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("New subnetmask:");
            var subnet = this.GetInputFunc();

            if (!IPAddress.TryParse(subnet, out IPAddress address))
            {
                this.PrintOutputAction("invalid subnet mask");
            }
            else
            {
                SetSubnetMaskRequest request = new SetSubnetMaskRequest()
                {
                    SubnetMask = address.ToString()
                };
                this._client.SetSubnetMaskAsync(request).GetAwaiter().GetResult();
                this.PrintOutputAction("subnet mask set");
            }
        }

        private void SetAddressRange()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("Min address:");
            var minAddress = this.GetInputFunc();
            this.PrintOutputAction("Max address:");
            var maxAddress = this.GetInputFunc();

            if (!IPAddress.TryParse(minAddress, out IPAddress min) || !IPAddress.TryParse(maxAddress, out IPAddress max))
            {
                this.PrintOutputAction("One or more addresses are invalid");
            }
            else
            {
                SetAddressRangeRequest request = new SetAddressRangeRequest()
                {
                    MaxAddress = max.ToString(),
                    MinAddress = min.ToString()
                };
                this._client.SetAddressRangeAsync(request).GetAwaiter().GetResult();
                this.PrintOutputAction("IP range set");
            }
        }
    }
}