using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoVehicleUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasHeader = true;

            using (InputCaptureWebService.InputCaptureWebServiceClient client = new InputCaptureWebService.InputCaptureWebServiceClient())
            {
                int counter = 0;
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\A.Johnston\Documents\Excel for SQL Server\DemoVehicle1Line.csv");
                string line = string.Empty;
                while ((line = file.ReadLine()) != null)
                {
                    if (!hasHeader || counter != 0)
                    {
                        DemoVehicles vehicle = new DemoVehicles(line);
                        //URL = http://hosted2.nditech.com:8080/bof2/services/inputcapturewebservice
                        string result = client.sendCapture("floppydisk", vehicle.User, vehicle.Vehicle, vehicle.Org_ID,
                            vehicle.System_ID, vehicle.Camera_ID, vehicle.Plate_Image, vehicle.Overview_Image, vehicle.Date_Time,
                            vehicle.Latitude, vehicle.Longitude, vehicle.Camera_Preset, vehicle.Camera_Pan, vehicle.Camera_Tilt,
                            vehicle.Camera_Zoom, vehicle.Confidence, vehicle.Toward_Camera);

                        if (result != string.Empty)
                        {
                            Console.WriteLine("There were {0} lines.", counter);
                            Console.ReadLine();
                        }
                    }

                    ++counter;
                }
            }

        }
    }
}

