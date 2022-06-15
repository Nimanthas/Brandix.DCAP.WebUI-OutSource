var ScanOption = {
  Non: 0,
  Before: 1,
  After: 2,
  Continue: 3
};

var DataCaptureMode = {
  Bulk: 2,
  Touch: 1,
  Barcode: 3,
  Washing: 4, //Added by NimanthaH
};

var TransactionMode = {
  Non: 0,
  Good: 1,
  Scrap: 2,
  Rework: 3
};

var Action = {
  Non: 0,
  Add: 1,
  Reverse: 2
};

var Answer = {
  Yes: 1,
  No: 0,
  Null: null
};

var LoginMode = {
  UsetIdAlfaNum: 1,
  UserIdNum: 2
};

var AccessibleFunctions = {
  GoodAdd: "00101D0002",
  GoodReverse: "00101D0002",
  ScrapAdd: "00101D0003",
  ScrapReverse: "00101D0004",
  ReworkAdd: "00101D0006",
  ReworkReverse: "00101D0007",
  ApproveGatepass: "00801A0001",
  CreateGatepass: "00801A0002",
  WashingProductionUpdate: "00901A0002",
  GoodReceive: "00901B0001",
  GenerateTravelBarcode: "00901C0001",
  TravelTagOperationUpdate: "00901D0001",
  UpdateWashDetails: "00901E0001",
  GenerateInvoices: "00901F0001",
  BarcodeDetails: "00901G0001",
  ViewReports: "00901H0001",
  RevreseDispatchStatus: "00901I0001",
  BarcodeErrorCorrection: "01001B0001",
  CreateBulkBag: "01001C0001",
};

var AccessibleDispatchFunctions = {
  ApproveGatepass: "00801A0001",
  CreateGatepass: "00801A0002"
};

var ScannedStatus = {
  Non: "Non",
  Pass: "Pass",
  Fail: "Fail"
};

var options = {   
  day: 'numeric',
  month: 'long', 
  year: 'numeric'
};

