﻿using PS.FritzBox.API.TR64.LANDevice.WLANConfiguration;
using System;
using System.Linq;

namespace PS.FritzBox.API.CMD
{
    internal class WLANConfigurationClientHandler : ClientHandler
    {
        WLANConfigurationService _client;
        public WLANConfigurationClientHandler(ConnectionSettings settings, Action<string> printOutput, Func<string> getInput, Action wait, Action clearOutput) : base(settings, printOutput, getInput, wait, clearOutput)
        {
            this._client = new WLANConfigurationService(settings);
        }

        public override void Handle()
        {
            string input = string.Empty;

            do
            {
                this.ClearOutputAction();
                this.PrintOutputAction($"WLANConfigurationClient{Environment.NewLine}########################");
                this.PrintOutputAction(" 1 - GetInfo");
                this.PrintOutputAction(" 2 - GetSecurityKeys");
                this.PrintOutputAction(" 3 - GetDefaultWEPKeyIndex");
                this.PrintOutputAction(" 4 - SetDefaultWEPKeyIndexAsync");
                this.PrintOutputAction(" 5 - GetBSSID");
                this.PrintOutputAction(" 6 - GetSSID");
                this.PrintOutputAction(" 7 - SetSSID");
                this.PrintOutputAction(" 8 - GetBeaconType");
                this.PrintOutputAction(" 9 - GetChannelInfo");
                this.PrintOutputAction("10 - SetChannel");
                this.PrintOutputAction("11 - GetTotalAssociations");
                this.PrintOutputAction("12 - GetAssociatedDevices");
                this.PrintOutputAction("13 - GetIPTVOptimized");
                this.PrintOutputAction("14 - GetNightControl");
                this.PrintOutputAction("15 - GetWPSInfo");

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
                            this.GetSecurityKeys();
                            break;
                        case "3":
                            this.GetDefaultWEPKeyIndex();
                            break;
                        case "4":
                            this.SetDefaultWEPKeyIndex();
                            break;
                        case "5":
                            this.GetBSSID();
                            break;
                        case "6":
                            this.GetSSID();
                            break;
                        case "7":
                            this.SetSSID();
                            break;
                        case "8":
                            this.GetBeaconType();
                            break;
                        case "9":
                            this.GetChannelInfo();
                            break;
                        case "10":
                            this.SetChannel();
                            break;
                        case "11":
                            this.GetTotalAssociations();
                            break;
                        case "12":
                            this.GetAssociatedDevices();
                            break;
                        case "13":
                            this.GetIPTVOptimized();
                            break;
                        case "14":
                            this.GetNightControl();
                            break;
                        case "15":
                            this.GetWPSInfo();
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

        private void GetWPSInfo()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var info = this._client.X_GetWPSInfoAsync().GetAwaiter().GetResult();
            this.PrintObject(info);
        }

        private void GetNightControl()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var info = this._client.X_GetNightControlAsync().GetAwaiter().GetResult();
            this.PrintObject(info);
        }

        private void GetAssociatedDevices()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var result = this._client.GetTotalAssociationsAsync().GetAwaiter().GetResult();

            for(int i = 0; i < result.TotalAssociations; i++)
            {
                GetGenericAssociatedDeviceInfoRequest request = new GetGenericAssociatedDeviceInfoRequest()
                {
                    AssociatedDeviceIndex = i
                };
                var entry = this._client.GetGenericAssociatedDeviceInfoAsync(request).GetAwaiter().GetResult();

                this.PrintObject(entry);
            }
        }

        private void GetTotalAssociations()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var result = this._client.GetTotalAssociationsAsync().GetAwaiter().GetResult();
            this.PrintOutputAction($"Total associations: {result.TotalAssociations}");
        }

        private void GetBeaconType()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var result = this._client.GetBeaconAdvertisementAsync().GetAwaiter().GetResult();

            this.PrintOutputAction($"Beacon Type: {result.BeaconAdvertisementEnabled}");
        }

        private void GetChannelInfo()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            this.PrintObject(this._client.GetChannelInfoAsync().GetAwaiter().GetResult());
        }

        private void GetInfo()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var info = this._client.GetInfoAsync().GetAwaiter().GetResult();
            this.PrintObject(info);
        }

        private void GetSecurityKeys()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            var info = this._client.GetSecurityKeysAsync().GetAwaiter().GetResult();
            this.PrintObject(info);
        }

        private void GetDefaultWEPKeyIndex()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            this.PrintOutputAction($"Default WEP Key index: {this._client.GetDefaultWEPKeyIndexAsync().GetAwaiter().GetResult()}");
        }

        private void SetDefaultWEPKeyIndex()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("New index:");
            if (Int32.TryParse(this.GetInputFunc(), out Int32 result))
            {
                SetDefaultWEPKeyIndexRequest request = new SetDefaultWEPKeyIndexRequest()
                {
                    DefaultWEPKeyIndex = result
                };
                this._client.SetDefaultWEPKeyIndexAsync(request).GetAwaiter().GetResult();
                this.PrintOutputAction("New index set");
            }
            else
                this.PrintOutputAction("Invalid input");
        }

        private void GetBSSID()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            this.PrintOutputAction($"BSSID: {this._client.GetBSSIDAsync().GetAwaiter().GetResult().BSSID}");
        }

        private void GetSSID()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            this.PrintOutputAction($"BSSID: {this._client.GetSSIDAsync().GetAwaiter().GetResult().SSID}");
        }

        private void SetSSID()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            this.PrintOutputAction("New SSID:");
            SetSSIDRequest request = new SetSSIDRequest()
            {
                SSID = this.GetInputFunc()
            };

            this._client.SetSSIDAsync(request).GetAwaiter().GetResult();
            this.PrintOutputAction("New SSID set");
        }

        private void SetChannel()
        {
            this.ClearOutputAction();
            this.PrintEntry();
            var channelInfo = this._client.GetChannelInfoAsync().GetAwaiter().GetResult();
            this.PrintOutputAction("New Channel:");
            if (Int32.TryParse(this.GetInputFunc(), out Int32 channel) && channelInfo.PossibleChannels.Max() >= channel)
            {
                SetChannelRequest request = new SetChannelRequest()
                {
                    Channel = channel
                };

                this._client.SetChannelAsync(request).GetAwaiter().GetResult();
                this.PrintOutputAction("channel set");
            }
            else
                this.PrintOutputAction("invalid input");
        }

        private void GetIPTVOptimized()
        {
            this.ClearOutputAction();
            this.PrintEntry();

            this.PrintOutputAction($"IP TV Optimized: {this._client.X_GetIPTVOptimizedAsync().GetAwaiter().GetResult().IPTVoptimize}");
        }
    }
}