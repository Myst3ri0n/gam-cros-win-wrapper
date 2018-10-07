﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChromebookGUI
{
    public class GAM
    {
        public static List<string> RunGAM(String gamCommand)
        {
            // this function lets us run gam, which is pretty important

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "gam.exe",
                    Arguments = gamCommand, // this must be passed in without the "gam"
                    UseShellExecute = false,
                    RedirectStandardOutput = true, // let us read the output here
                    RedirectStandardError = true,
                    CreateNoWindow = true // don't open a cmd window
                }
            };

            List<string> output = new List<string>();
            proc.Start();

            while (!proc.StandardOutput.EndOfStream) // while it's still running
            {
                //Console.WriteLine("recieved output from GAM...");
                output.Add(proc.StandardOutput.ReadLine()); // append the line to output
                //Console.WriteLine("Standard output:");
                //Console.WriteLine(proc.StandardOutput.ReadLine());
                //Console.WriteLine("Error output:");
                //Console.WriteLine(proc.StandardError.ReadLine());

            }
            proc.Close();
            return output;
        }

        /// <summary>
        /// Runs GAM, but returns a newline character seperated string, ready for display.
        /// </summary>
        /// <param name="gamCommand"></param>
        /// <returns>A newline character seperated string, ready for display.</returns>
        public static String RunGAMFormatted(String gamCommand)
        {
            string result = null;
            foreach(string line in RunGAM(gamCommand))
            {
                result += "\n" + line;
            }
            return result;
        }

        /// <summary>
        /// Get the GAM command for the CSV. Turns a normal GAM command into one that pulls from a CSV. Can be fed into GAM.RunGAM or GAM.RunGAMFormatted.
        /// </summary>
        /// <param name="csvLocation">The absolute path to your CSV file. Get it with GetInput.GetFileSelection("csv").</param>
        /// <param name="gamCommandBeforeDeviceId">The GAM command you would run before the device id parameter.</param>
        /// <param name="gamCommandAfterDeviceId">The rest of the GAM command, after the device id.</param>
        /// <returns>The GAM command that can be fed into GAM.RunGAM or GAM.RunGAMFormatted.</returns>
        public static string GetGAMCSVCommand(String csvLocation, String gamCommandBeforeDeviceId, String gamCommandAfterDeviceId)
        {
            return "csv " + csvLocation + " " + gamCommandBeforeDeviceId + " ~deviceId " + gamCommandAfterDeviceId;
        }

        /// <summary>
        /// Runs GAM and FixCSVCommas.FixCommas
        /// </summary>
        /// <param name="gamCommand"></param>
        /// <returns></returns>
        public static List<List<string>> RunGAMCommasFixed(String gamCommand)
        {
            return FixCSVCommas.FixCommas(GAM.RunGAM(gamCommand));
        }
        
        /// <summary>
        /// Checks if a string is a device ID by seeing if it has 4 dashes in it.
        /// </summary>
        /// <param name="input">The string you wish to check.</param>
        /// <returns></returns>
        public static bool IsDeviceId(string input)
        {
            if(Regex.Matches(input, "-").Count == 4)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a Device ID, from a variety of sources (email, serial number, asset id, email)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static BasicDeviceInfo GetDeviceId(String input)
        {
            if (IsDeviceId(input)) // this is already a device ID
            {
                return new BasicDeviceInfo
                {
                    DeviceId = input
                };
            }
            else if (input.Contains("@"))
            {
                string user = input.Split('@')[0];
                if (String.IsNullOrEmpty(user))
                {
                    return new BasicDeviceInfo
                    {
                        ErrorText = "There was an error processing your email entry: I couldn't find the email.",
                        Error = true
                    };
                }
                // results:
                // deviceId,lastSync,notes,serialNumber,status
                List<string> gamResults = RunGAM("print cros query \"user:" + user + "\" fields deviceId,lastSync,notes,serialNumber,status,assetid,location");
                List<List<string>> deviceInfos = FixCSVCommas.FixCommas(gamResults);
                if (deviceInfos[0][0] == "deviceId") deviceInfos.RemoveAt(0);
                if (deviceInfos.Count == 1) if (deviceInfos[0].Count > 1)
                    {
                        return new BasicDeviceInfo()
                        {
                            DeviceId = deviceInfos[0][0],
                            LastSync = deviceInfos[0][1],
                            Notes = deviceInfos[0][2],
                            SerialNumber = deviceInfos[0][3],
                            Status = deviceInfos[0][4],
                            AssetId = deviceInfos[0][5],
                            Location = deviceInfos[0][6]
                        };
                    }
                List<BasicDeviceInfo> infoObjects = new List<BasicDeviceInfo>();
                foreach (List<string> line in deviceInfos)
                {
                    infoObjects.Add(new BasicDeviceInfo()
                    {
                        DeviceId = line[0],
                        LastSync = line[1],
                        SerialNumber = line[3],
                        Status = line[4],
                        Notes = line[2],
                        AssetId = line[5],
                        Location = line[6]
                    });
                }
                List<string> selection = GetInput.GetDataGridSelection("Which device would you like to select?", "Click on a row or enter a Device ID or Serial Number.", "Device Selector", infoObjects);
                string deviceId = null;
                foreach (string item in selection)
                {
                    if (IsDeviceId(item)) deviceId = item;
                    break;
                }
                if (deviceId == null)
                {
                    return new BasicDeviceInfo
                    {
                        ErrorText = "There was an error. You didn't pick anything.",
                        Error = true
                    };
                }
                else
                {
                    for (int i = 1; i < deviceInfos.Count; i++)
                    {
                        if (deviceId == deviceInfos[i][0])
                        {
                            return new BasicDeviceInfo
                            {
                                DeviceId = deviceId,
                                LastSync = deviceInfos[i][1],
                                Notes = deviceInfos[i][2],
                                SerialNumber = deviceInfos[i][3],
                                Status = deviceInfos[i][4],
                                AssetId = deviceInfos[i][5],
                                Location = deviceInfos[i][6],
                                Error = false
                            };
                        }
                    }
                    // we have not found a match for the device id
                    return new BasicDeviceInfo
                    {
                        DeviceId = deviceId
                    };
                }
            }
            else
            {
                // must be a serial number. 
                List<List<string>> response = null;
                
                // obey the preference here
                if (Preferences.SerialNumberAssetIdPriority)
                {
                    response = FixCSVCommas.FixCommas(RunGAM("print cros query \"asset_id:" + input + "\" fields deviceId,lastSync,notes,serialNumber,status,assetid,location"));
                    if (response.Count < 2)
                    {
                        response = FixCSVCommas.FixCommas(RunGAM("print cros query \"id:'" + input + "'\" fields deviceId,lastSync,notes,serialNumber,status,assetid,location"));
                    }
                }
                else
                {
                    response = FixCSVCommas.FixCommas(RunGAM("print cros query \"id:" + input + "\" fields deviceId,lastSync,notes,serialNumber,status,assetid,location"));
                    if (response.Count < 2)
                    {
                        response = FixCSVCommas.FixCommas(RunGAM("print cros query \"asset_id:'" + input + "'\" fields deviceId,lastSync,notes,serialNumber,status,assetid,location"));
                    }
                }

                if (response.Count < 2) return new BasicDeviceInfo
                {
                    ErrorText = "No results found for that entry (" + input + ").",
                    Error = true
                }; // this count thing does NOT start at zero. ugh!

                BasicDeviceInfo deviceInfo = new BasicDeviceInfo()
                {
                    DeviceId = response[1][0],
                    LastSync = response[1][1],
                    Notes = response[1][2],
                    SerialNumber = response[1][3],
                    Status = response[1][4],
                    AssetId = response[1][5],
                    Location = response[1][6]
                };
                Globals.SetGlobalsFromBasicDeviceInfo(deviceInfo);
                return deviceInfo;
            }
        }
    }
}