﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTCSTLKiosk
{
    public class Settings
    {
        private static Settings instance = null;
        private Windows.Storage.ApplicationDataContainer localSettings;
        private List<string> regions;

        private Settings()
        {
            localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            regions = new List<string>() { "eastasia", "southeastasia", "australiaeast", "northeurope", "westeurope", "eastus", "eastus2", "southcentralus", "westcentralus",
                                            "westus", "westus2", "brazilsouth"};
        }


        public static Settings SingletonInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        public string CameraKey
        {
            get
            {
                if (localSettings.Values.ContainsKey("CameraKey"))
                    return (string)localSettings.Values["CameraKey"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["CameraKey"] = value; }
        }

        public bool ShowAgeAndGender
        {
            get
            {
                if (localSettings.Values.ContainsKey("ShowAgeAndGender"))
                    return (bool)localSettings.Values["ShowAgeAndGender"];
                else
                    return false;
            }
            set { localSettings.Values["ShowAgeAndGender"] = value; }
        }

        public bool DoFaceDetection
        {
            get
            {
                if (localSettings.Values.ContainsKey("DoFaceDetection"))
                    return (bool)localSettings.Values["DoFaceDetection"];
                else
                    return false;
            }
            set { localSettings.Values["DoFaceDetection"] = value; }
        }

        public string SpeechKey
        {
            get {
                if (localSettings.Values.ContainsKey("SpeechKey"))
                    return (string)localSettings.Values["SpeechKey"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["SpeechKey"] = value; }
        }

        public string GroupName
        {
            get
            {
                return "MTC CSH FACES";
            }
        }

        public string VisionKey
        {
            get
            {
                if (localSettings.Values.ContainsKey("VisionKey"))
                    return (string)localSettings.Values["VisionKey"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["VisionKey"] = value; }
        }

        public string CustomVisionKey
        {
            get
            {
                if (localSettings.Values.ContainsKey("CustomVisionKey"))
                    return (string)localSettings.Values["CustomVisionKey"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["CustomVisionKey"] = value; }
        }

        public string CustomVisionProjectId
        {
            get
            {
                if (localSettings.Values.ContainsKey("CustomVisionProjectId"))
                    return (string)localSettings.Values["CustomVisionProjectId"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["CustomVisionProjectId"] = value; }
        }

        public string CustomVisionIterationName
        {
            get
            {
                if (localSettings.Values.ContainsKey("CustomVisionIterationName"))
                    return (string)localSettings.Values["CustomVisionIterationName"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["CustomVisionIterationName"] = value; }
        }

        public int CustomVisionThreshold
        {
            get
            {
                if (localSettings.Values.ContainsKey("CustomVisionThreshold"))
                    return (int)localSettings.Values["CustomVisionThreshold"];
                else
                    return 80;
            }
            set { localSettings.Values["CustomVisionThreshold"] = value; }
        }

        public int FaceThreshold
        {
            get
            {
                if (localSettings.Values.ContainsKey("FaceThreshold"))
                    return (int)localSettings.Values["FaceThreshold"];
                else
                    return 65;
            }
            set { localSettings.Values["FaceThreshold"] = value; }
        }

        public int FaceCVFPM
        {
            get
            {
                if (localSettings.Values.ContainsKey("FaceCVFPM"))
                    return (int)localSettings.Values["FaceCVFPM"];
                else
                    return 60;
            }
            set { localSettings.Values["FaceCVFPM"] = value; }
        }

        public string FaceKey
        {
            get
            {
                if (localSettings.Values.ContainsKey("FaceKey"))
                    return (string)localSettings.Values["FaceKey"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["FaceKey"] = value; }
        }

        public string FaceRegion
        {
            get
            {
                if (localSettings.Values.ContainsKey("FaceRegion"))
                    return (string)localSettings.Values["FaceRegion"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["FaceRegion"] = value; }
        }

        public string VisionRegion
        {
            get
            {
                if (localSettings.Values.ContainsKey("VisionRegion"))
                    return (string)localSettings.Values["VisionRegion"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["VisionRegion"] = value; }
        }

        public string CustomVisionRegion
        {
            get
            {
                if (localSettings.Values.ContainsKey("CustomVisionRegion"))
                    return (string)localSettings.Values["CustomVisionRegion"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["CustomVisionRegion"] = value; }
        }

        public string SpeechRegion
        {
            get
            {
                if (localSettings.Values.ContainsKey("SpeechRegion"))
                    return (string)localSettings.Values["SpeechRegion"];
                else
                    return string.Empty;
            }
            set { localSettings.Values["SpeechRegion"] = value; }
        }

        public List<string> Regions
        {
            get
            {
                return regions;
            }
        }

    }
}
