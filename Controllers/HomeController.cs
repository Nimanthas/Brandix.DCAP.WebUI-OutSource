using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Brandix.DCAP.WebUI.Models;
using Brandix.DCAP.WebUI.Services;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace Brandix.DCAP.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUIConfiguration appSettings;
        private IHttpContextAccessor client;
        private IHostingEnvironment _hostingEnvironment;
        public HomeController(IUIConfiguration appSettings, IHttpContextAccessor client, IHostingEnvironment hostingEnvironment)
        {
            this.appSettings = appSettings;
            this.client = client;
            this._hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Login()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Bulk()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Barcode()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Dispatch()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult PrintDispatch()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult UpdateWashDetails()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult GenerateTravelBarcode()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult GenerateTravelBarcode2()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }
        
        public IActionResult BFLProductionBarcode()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult BFLProductionBarcodeNew()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult BFLStockReport()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult GatePassSummaryReport()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult NonApperalDataManager()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Menu()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult PrintTravelTag()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult OutsourceDetails()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult GenerateBuddyTag()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult GoodReceive()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult SecurityUpdate()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult InvoiceSummaryReport()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult BarcodeDetail()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult Invoice()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult ManageStyles()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult CreateBulkBagBarcode()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult BarcodeScanErrorCorrector()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult GroupBarcodeAudit()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult FindBarcodeOperationHistory()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }

        public IActionResult ManagePackingList()
        {
            ViewBag.ClientIP = client.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.APIURL = appSettings.APIURL;
            ViewBag.WebUIURL = appSettings.WebUIURL;
            ViewBag.SessionTimeOut = appSettings.SessionTimeOut;
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public IActionResult Error()
        {
            var feature = this.HttpContext.Features.Get<IExceptionHandlerFeature>();
            return View();
        }

        //Excel Controllers
        public ActionResult Import()
        {
            IFormFile file = Request.Form.Files[0];
            string folderName = "UploadExcel";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            StringBuilder sb = new StringBuilder();
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                ISheet sheet;
                string fullPath = Path.Combine(newPath, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    if (sFileExtension == ".xls")
                    {
                        HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook  
                    }
                    else
                    {
                        XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                    }
                    
                    IRow headerRow = sheet.GetRow(0); //Get Header Row
                    int cellCount = headerRow.LastCellNum;
                    sb.Append("<table class='table table-bordered'><tr>");
                    for (int j = 0; j < cellCount; j++)
                    {
                        NPOI.SS.UserModel.ICell cell = headerRow.GetCell(j);
                        if (cell == null || string.IsNullOrWhiteSpace(cell.ToString())) continue;
                        sb.Append("<th>" + cell.ToString() + "</th>");
                    }
                    sb.Append("</tr>");
                    sb.AppendLine("<tr>");
                    for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;
                        if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            if (row.GetCell(j) != null)
                                sb.Append("<td>" + row.GetCell(j).ToString() + "</td>");
                        }
                        sb.AppendLine("</tr>");
                    }
                    sb.Append("</table>");
                }
            }
            return this.Content(sb.ToString());
        }

    }
}
