using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVehicleUpload
{
    public class DemoVehicles
    {
        public const int UserCol = 2;
        private const int VehicleCol = 3;
        public const int ConfidenceCol = 4;
        private const int TowardCol = 5;
        private const int OrgIDCol = 6;
        private const int SystemIDCol = 7;
        private const int CameraIdCol = 8;
        private const int DateTimeCol = 9;
        private const int LatCol = 10;
        private const int LongCol = 11;
        private const int CameraPreCol = 12;
        private const int CameraPanCol = 13;
        private const int CameraTiltCol = 14;
        private const int CameraZoomCol = 15;
        private const int OverviewCol = 16;
        private const int PlateCol = 17;

        private readonly string[] parts;

        public DemoVehicles(string line)
        {
            parts = line.Split(',');
        }

        public string User => parts[VehicleCol];

        public string Vehicle => parts[VehicleCol];

        public sbyte Confidence
        {
            get
            {
                sbyte.TryParse(parts[ConfidenceCol], out var result);
                return result;
            }
        }

        public bool Toward_Camera
        {
            get
            {
                bool.TryParse(parts[TowardCol], out var result);
                return result;
            }
        }

        public short Org_ID
        {
            get
            {
                short.TryParse(parts[OrgIDCol], out var result);
                return result;
            }
        }
        public short System_ID
        {
            get
            {
                short.TryParse(parts[SystemIDCol], out var result);
                return result;
            }
        }

        public short Camera_ID
        {
            get
            {
                short.TryParse(parts[CameraIdCol], out var result);
                return result;
            }
        }

        public DateTime Date_Time
        {
            get
            {
                DateTime.TryParse(parts[DateTimeCol], out var result);
                return result;
            }
        }

        public float Latitude
        {
            get
            {
                float.TryParse(parts[LatCol], out var result);
                return result;
            }
        }

        public float Longitude
        {
            get
            {
                float.TryParse(parts[LongCol], out var result);
                return result;
            }
        }

        public short Camera_Preset
        {
            get
            {
                short.TryParse(parts[CameraPreCol], out var result);
                return result;
            }
        }

        public string Camera_Pan
        {
            get
            {
                return parts[CameraPanCol];
            }
        }

        public string Camera_Tilt
        {
            get
            {
                return parts[CameraTiltCol];
            }
        }

        public string Camera_Zoom
        {
            get
            {
                return parts[CameraTiltCol];
            }
        }

        public byte[] Overview_Image
        {
            get
            {
                string path = parts[OverviewCol] + ".jpg";
                return System.IO.File.ReadAllBytes(path);
            }
        }

        public byte[] Plate_Image
        {
            get
            {
                string path = parts[PlateCol] + ".jpg";
                return System.IO.File.ReadAllBytes(path);
            }            
        }
    }
}

//public int Camera_Tilt => Convert.ToInt32(parts[CameraTiltCol] ?? "0");

//public string User => parts[UserCol];
//public string Vehicle => parts[VehicleCol];
//public int Confidence => Convert.ToInt32(parts[ConfidenceCol]);
//public string Toward_Camera => parts[TowardCol];
//public int Org_ID => Convert.ToInt32(parts[OrgIDCol]);
//public int System_ID => Convert.ToInt32(parts[SystemIDCol]);
//public string Camera_ID => parts[CameraIdCol];
//public DateTime Date_Time => Convert.ToDateTime(parts[DateTimeCol]);
//public decimal Latitude => Convert.ToDecimal(parts[LatCol]);
//public decimal Longitude => Convert.ToDecimal(parts[LongCol]);
//public int Camera_Preset => Convert.ToInt32(parts[CameraPreCol]);