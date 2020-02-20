using System;
using CoreScanner;
using System.Xml;

namespace Weaselware.InventoryFerret {


    public class BarCodeReader
    {
        
        CCoreScannerClass cCoreScannerClass;
        public delegate void BarCodeReadHandler(object sender, BarCodeReadEventArgs e);
        public event BarCodeReadHandler OnBarCodeRead;

        public class BarCodeReadEventArgs : System.EventArgs
        {
            public string ValueRead { get; set; }
        }
        

        public void OpenScanner()
        {

            int opcode;
            string outXML;
            string inXML;

            //Instantiate CoreScanner Class
            cCoreScannerClass = new CCoreScannerClass();
            //Call Open API
            short[] scannerTypes = new short[1];//Scanner Types you are interested in
            scannerTypes[0] = 1; // 1 for all scanner types
            short numberOfScannerTypes = 1; // Size of the scannerTypes array
            int status; // Extended API return code
            cCoreScannerClass.Open(0, scannerTypes, numberOfScannerTypes, out status);

            opcode = 6000; // Method for Beep the beeper
            //outXML; // Output
            inXML = "<inArgs>" +
            "<scannerID>1</scannerID>" + // The scanner you need to beep
            "<cmdArgs>" +
            "<arg-int>43</arg-int>" + // 4 high short beep pattern
            "<arg-int>2</arg-int>" +
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);

            opcode = 6000; // Method for Beep the beeper
            //outXML; // Output
            inXML = "<inArgs>" +
            "<scannerID>1</scannerID>" + // The scanner you need to beep
            "<cmdArgs>" +
            "<arg-int>7</arg-int>" + // 4 high short beep pattern
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);

            opcode = 1001; // Method for Subscribe events
            //outXML; // XML Output
            inXML = "<inArgs>" +
            "<cmdArgs>" +
            "<arg-int>1</arg-int>" + // Number of events you want to subscribe
            "<arg-int>1</arg-int>" + // Comma separated event IDs
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);
            cCoreScannerClass.BarcodeEvent += new _ICoreScannerEvents_BarcodeEventEventHandler(OnBarcodeEvent);

        }

        void OnBarcodeEvent(short eventType, ref string pscanData)
        {
            string barcode = pscanData;
            if (OnBarCodeRead != null)
            {
                BarCodeReadEventArgs e = new BarCodeReadEventArgs();
                e.ValueRead = ShowBarcodeLabel(barcode) ;
                OnBarCodeRead(this ,e);
            }

        }

        public void CloseScanner()
        {
            int opcode;
            string outXML;
            string inXML;

            //Instantiate CoreScanner Class
            cCoreScannerClass = new CCoreScannerClass();
            //Call Open API
            short[] scannerTypes = new short[1];//Scanner Types you are interested in
            scannerTypes[0] = 1; // 1 for all scanner types
            short numberOfScannerTypes = 1; // Size of the scannerTypes array
            int status; // Extended API return code
            cCoreScannerClass.Open(0, scannerTypes, numberOfScannerTypes, out status);

            opcode = 6000; // Method for Beep the beeper
            //outXML; // Output
            inXML = "<inArgs>" +
            "<scannerID>1</scannerID>" + // The scanner you need to beep
            "<cmdArgs>" +
            "<arg-int>20</arg-int>" + // 4 high short beep pattern
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);

            opcode = 6000; // Method for Beep the beeper
            //outXML; // Output
            inXML = "<inArgs>" +
            "<scannerID>1</scannerID>" + // The scanner you need to beep
            "<cmdArgs>" +
            "<arg-int>42</arg-int>" + // 4 high short beep pattern
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);
            //Remove event handler
            cCoreScannerClass.BarcodeEvent -= new _ICoreScannerEvents_BarcodeEventEventHandler(OnBarcodeEvent);
        }


        private string ShowBarcodeLabel(string strXml)
        {
            System.Diagnostics.Debug.WriteLine("Initial XML" + strXml);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(strXml);

            string strData = String.Empty;
            string barcode = xmlDoc.DocumentElement.GetElementsByTagName("datalabel").Item(0).InnerText;
            string symbology = xmlDoc.DocumentElement.GetElementsByTagName("datatype").Item(0).InnerText;
            string[] numbers = barcode.Split(' ');

            foreach (string number in numbers)
            {
                if (String.IsNullOrEmpty(number))
                {
                    break;
                }

                strData += ((char)Convert.ToInt32(number, 16)).ToString();
            }

            return strData;
        }
    }
}
