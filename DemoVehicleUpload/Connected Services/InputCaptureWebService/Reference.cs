﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoVehicleUpload.InputCaptureWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://172.31.255.113:8080/bof2/services/InputCaptureWebService", ConfigurationName="InputCaptureWebService.InputCaptureWebService")]
    public interface InputCaptureWebService {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://input.webservices.bof2.anite.com) of message sendCaptureRequest does not match the default value (http://172.31.255.113:8080/bof2/services/InputCaptureWebService)
        [System.ServiceModel.OperationContractAttribute(Action="http://input.webservices.bof2.anite.com/InputCaptureWebService", ReplyAction="http://172.31.255.113:8080/bof2/services/InputCaptureWebService/InputCaptureWebSe" +
            "rvice/sendCaptureResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        DemoVehicleUpload.InputCaptureWebService.sendCaptureResponse sendCapture(DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://input.webservices.bof2.anite.com/InputCaptureWebService", ReplyAction="http://172.31.255.113:8080/bof2/services/InputCaptureWebService/InputCaptureWebSe" +
            "rvice/sendCaptureResponse")]
        System.Threading.Tasks.Task<DemoVehicleUpload.InputCaptureWebService.sendCaptureResponse> sendCaptureAsync(DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendCapture", WrapperNamespace="http://input.webservices.bof2.anite.com", IsWrapped=true)]
    public partial class sendCaptureRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string signatureOfSender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string vrm;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public short feedIdentifier;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public short sourceIdentifier;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public short cameraIdentifier;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=6)]
        [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        public byte[] plateJpegImage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=7)]
        [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        public byte[] overviewJpegImage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=8)]
        public System.DateTime captureTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=9)]
        public float latitude;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=10)]
        public float longitude;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=11)]
        public short cameraPresetPosition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=12)]
        public string cameraPan;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=13)]
        public string cameraTilt;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=14)]
        public string cameraZoom;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=15)]
        public sbyte confidencePercentage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=16)]
        public bool motionTowardCamera;
        
        public sendCaptureRequest() {
        }
        
        public sendCaptureRequest(
                    string signatureOfSender, 
                    string username, 
                    string vrm, 
                    short feedIdentifier, 
                    short sourceIdentifier, 
                    short cameraIdentifier, 
                    byte[] plateJpegImage, 
                    byte[] overviewJpegImage, 
                    System.DateTime captureTime, 
                    float latitude, 
                    float longitude, 
                    short cameraPresetPosition, 
                    string cameraPan, 
                    string cameraTilt, 
                    string cameraZoom, 
                    sbyte confidencePercentage, 
                    bool motionTowardCamera) {
            this.signatureOfSender = signatureOfSender;
            this.username = username;
            this.vrm = vrm;
            this.feedIdentifier = feedIdentifier;
            this.sourceIdentifier = sourceIdentifier;
            this.cameraIdentifier = cameraIdentifier;
            this.plateJpegImage = plateJpegImage;
            this.overviewJpegImage = overviewJpegImage;
            this.captureTime = captureTime;
            this.latitude = latitude;
            this.longitude = longitude;
            this.cameraPresetPosition = cameraPresetPosition;
            this.cameraPan = cameraPan;
            this.cameraTilt = cameraTilt;
            this.cameraZoom = cameraZoom;
            this.confidencePercentage = confidencePercentage;
            this.motionTowardCamera = motionTowardCamera;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendCaptureResponse", WrapperNamespace="http://172.31.255.113:8080/bof2/services/InputCaptureWebService", IsWrapped=true)]
    public partial class sendCaptureResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string sendCaptureReturn;
        
        public sendCaptureResponse() {
        }
        
        public sendCaptureResponse(string sendCaptureReturn) {
            this.sendCaptureReturn = sendCaptureReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InputCaptureWebServiceChannel : DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InputCaptureWebServiceClient : System.ServiceModel.ClientBase<DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService>, DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService {
        
        public InputCaptureWebServiceClient() {
        }
        
        public InputCaptureWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InputCaptureWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InputCaptureWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InputCaptureWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DemoVehicleUpload.InputCaptureWebService.sendCaptureResponse DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService.sendCapture(DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest request) {
            return base.Channel.sendCapture(request);
        }
        
        public string sendCapture(
                    string signatureOfSender, 
                    string username, 
                    string vrm, 
                    short feedIdentifier, 
                    short sourceIdentifier, 
                    short cameraIdentifier, 
                    byte[] plateJpegImage, 
                    byte[] overviewJpegImage, 
                    System.DateTime captureTime, 
                    float latitude, 
                    float longitude, 
                    short cameraPresetPosition, 
                    string cameraPan, 
                    string cameraTilt, 
                    string cameraZoom, 
                    sbyte confidencePercentage, 
                    bool motionTowardCamera) {
            DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest inValue = new DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest();
            inValue.signatureOfSender = signatureOfSender;
            inValue.username = username;
            inValue.vrm = vrm;
            inValue.feedIdentifier = feedIdentifier;
            inValue.sourceIdentifier = sourceIdentifier;
            inValue.cameraIdentifier = cameraIdentifier;
            inValue.plateJpegImage = plateJpegImage;
            inValue.overviewJpegImage = overviewJpegImage;
            inValue.captureTime = captureTime;
            inValue.latitude = latitude;
            inValue.longitude = longitude;
            inValue.cameraPresetPosition = cameraPresetPosition;
            inValue.cameraPan = cameraPan;
            inValue.cameraTilt = cameraTilt;
            inValue.cameraZoom = cameraZoom;
            inValue.confidencePercentage = confidencePercentage;
            inValue.motionTowardCamera = motionTowardCamera;
            DemoVehicleUpload.InputCaptureWebService.sendCaptureResponse retVal = ((DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService)(this)).sendCapture(inValue);
            return retVal.sendCaptureReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DemoVehicleUpload.InputCaptureWebService.sendCaptureResponse> DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService.sendCaptureAsync(DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest request) {
            return base.Channel.sendCaptureAsync(request);
        }
        
        public System.Threading.Tasks.Task<DemoVehicleUpload.InputCaptureWebService.sendCaptureResponse> sendCaptureAsync(
                    string signatureOfSender, 
                    string username, 
                    string vrm, 
                    short feedIdentifier, 
                    short sourceIdentifier, 
                    short cameraIdentifier, 
                    byte[] plateJpegImage, 
                    byte[] overviewJpegImage, 
                    System.DateTime captureTime, 
                    float latitude, 
                    float longitude, 
                    short cameraPresetPosition, 
                    string cameraPan, 
                    string cameraTilt, 
                    string cameraZoom, 
                    sbyte confidencePercentage, 
                    bool motionTowardCamera) {
            DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest inValue = new DemoVehicleUpload.InputCaptureWebService.sendCaptureRequest();
            inValue.signatureOfSender = signatureOfSender;
            inValue.username = username;
            inValue.vrm = vrm;
            inValue.feedIdentifier = feedIdentifier;
            inValue.sourceIdentifier = sourceIdentifier;
            inValue.cameraIdentifier = cameraIdentifier;
            inValue.plateJpegImage = plateJpegImage;
            inValue.overviewJpegImage = overviewJpegImage;
            inValue.captureTime = captureTime;
            inValue.latitude = latitude;
            inValue.longitude = longitude;
            inValue.cameraPresetPosition = cameraPresetPosition;
            inValue.cameraPan = cameraPan;
            inValue.cameraTilt = cameraTilt;
            inValue.cameraZoom = cameraZoom;
            inValue.confidencePercentage = confidencePercentage;
            inValue.motionTowardCamera = motionTowardCamera;
            return ((DemoVehicleUpload.InputCaptureWebService.InputCaptureWebService)(this)).sendCaptureAsync(inValue);
        }
    }
}
