#pragma checksum "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\NonApperalDataManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04cc750103297089eae459fe285dab4f3ff1568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NonApperalDataManager), @"mvc.1.0.view", @"/Views/Home/NonApperalDataManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NonApperalDataManager.cshtml", typeof(AspNetCore.Views_Home_NonApperalDataManager))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\_ViewImports.cshtml"
using Brandix.DCAP.WebUI;

#line default
#line hidden
#line 2 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\_ViewImports.cshtml"
using Brandix.DCAP.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04cc750103297089eae459fe285dab4f3ff1568", @"/Views/Home/NonApperalDataManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ac14fb493c2990ba4a5667bd32d8705427078c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NonApperalDataManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\NonApperalDataManager.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 16232, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    var selectedDate = null;
    var fromdatePicker = null;
    var todatePicker = null;
    var scheduleObject = null;
    var operationList = null;
    var todayDate = null;
    var scrapItems = [];
    var SoberSheetMode = false;
    var SSheetSCHNo = null;
    var SSheetSCHId = null;
    var SSAlreadySaved = false;

    //views
    var createNewTag = null;
    var addItemsGrid = null;
    var isvalidbarcode = false;


    function checkLoginStatus() {
        if (sessionStorage.getItem(""UserId"") != """") {
            $(""#toolBarLoggedinUser"").html(sessionStorage.getItem(""UserId""));
        } else {
            $(""#toolBarLoggedinUser"").html("""");
        }
        if (sessionStorage.getItem(""IsSignedIn"") == Answer.Null || sessionStorage.getItem(""IsSignedIn"") == Answer.No) {
            $(""#loginBar"").hide();
            window.location.href = ""Login"";
        } else {
            $(""#loginBar"").show();
        }
    }

    function initializ");
            WriteLiteral(@"eControls() {
        //Data selectors
        $(""#date-created-filter"").kendoDatePicker({format:""yyyy-MM-dd"",min:new Date(1900,0,1,0,0,0,0),max:new Date(2099,11,31,0,0,0,0)});
        todayDate = new Date();
        $(""#date-created-filter"").data(""kendoDatePicker"").value(todayDate);
        
	    $(""#status-filter"").kendoDropDownList({""dataSource"":[{""Text"":""All"",""Value"":""0""},
                                                            {""Text"":""Pending Approval"",""Value"":""1""},
                                                            {""Text"":""Approved - Not Send"",""Value"":""2""},
                                                            {""Text"":""Security Passed"",""Value"":""3""},
                                                            {""Text"":""Security Recieved"",""Value"":""4""},
                                                            {""Text"":""Closed"",""Value"":""5""}],
                                                ""dataTextField"":""Text"",""dataValueField"":""Value""});
        //End of data selections");
            WriteLiteral(@"
        //Create new Travel tag : END

        //For Request loading
        //Grid definition
        $(""#gatepass-grid"").kendoGrid({
            dataSource: {
                schema: {
                    model: {
                        id: ""Key"",
                        fields: {
                            Key: { type: ""string"", editable: false },
                            Style: { type: ""string"", editable: false },
                            Shedule: { type: ""string"", editable: false },
                            Color: { type: ""string"", editable: false },
                            Size: { type: ""string"", editable: false },
                            Barcode: { type: ""string"", editable: false },
                            Quantity: { type: ""number"", editable: false },
                            Remarks: { type: ""string"", editable: false },
                            Status: { type: ""string"", editable: false },
                        },
                    }
             ");
            WriteLiteral(@"   },
                batch: true,
                aggregate: [ { field: ""Style"", aggregate: ""count"" },
                            { field: ""Quantity"", aggregate: ""sum"" },
                            { field: ""Key"", aggregate: ""min"" },
                            { field: ""Key"", aggregate: ""max"" }]
                },
                toolbar: [""pdf"",""excel""],
                pdf: {
                    allPages: true,
                    author: JSON.parse(sessionStorage.getItem(""Clientconfig"")).clientId,
                    creator: JSON.parse(sessionStorage.getItem(""Clientconfig"")).clientId,
                    date: (new Date()).toLocaleDateString('en-US', { month: '2-digit', day: '2-digit', year: 'numeric'}),
                    fileName: ""Gate Pass""
                },
                excel: {
                    allPages: true,
                    fileName: ""Gate Pass - "" + (new Date()).toLocaleDateString('en-US', { month: '2-digit', day: '2-digit', year: 'numeric'})  + "".xlsx"",
        ");
            WriteLiteral(@"            filterable: true
                },
                scrollable: false,      
                sortable: false,
                filterable: false,
                columns:[
                        {field:""Key"",width:""0px"", hidden: true , aggregates: [""count""] },
                        {title:""Style"",field:""Style"",width:""54px"", aggregates: [""count""]},
                        {title:""Shedule"",field:""Shedule"",width:""54px""},
                        {title:""Color"",field:""Color"",width:""68px""},
                        {title:""Size"",field:""Size"",width:""68px""},
                        {title:""Barcode"",field:""Barcode"",width:""70px"", footerTemplate: ""Total""},
                        {title:""Quantity"",field:""Quantity"",width:""52px"", aggregates: [""sum""], footerTemplate: ""#=sum#""},
                        {title:""Remarks"",field:""Remarks"",width:""54px""},
                        {title:""Status"",field:""Status"",width:""54px""},
                    ],
            });
    }

    function OnGridDataBound(");
            WriteLiteral(@"e) {
        var grid = $(""#request-grid"").data().kendoGrid; 
        var gridData = grid.dataSource.view();

        for (var i = 0; i < gridData.length; i++) {
            var currentUid = gridData[i].uid;
            if (gridData[i].success == true) {
                var currentRow = grid.table.find(""tr[data-uid='"" + currentUid + ""']"");
                currentRow.css('background-color', 'lightgreen');
            }
        }

        var grid = e.sender;
        var rows = grid.tbody.find(""[role='row']"");

        rows.unbind(""click"");
        rows.on(""click"", onClick)
    }

    function onClick(e) {
        if ($(e.target).hasClass(""k-checkbox-label"")) {
            return;
        }
        var row = $(e.target).closest(""tr"");
        var checkbox = $(row).find("".k-checkbox"");

        checkbox.click();
    };
        //end

    getSessionInfo();

    $(document).ready(function () {
        $('#sitebody').removeClass('body-login');
        $(""#sitebody"").append(
      ");
            WriteLiteral(@"      '<div id=""ajaxBusy"" class=""ajaxBusy""></div>'
        );
        $(""#ajaxBusy"").hide();
        checkLoginStatus();
        $('#pageTitleBar').html('<i class=""fas fa-barcode pageMainIcon""></i><span class=""pageTitle"">DCap - Out Source</span>');

        initializeControls();

        checkIdle();

        if (isValidClient == Answer.Null) {
            window.location.href = ""Login"";
        }
        else if (isValidClient != null && clientconfig.dataCaptureMode != DataCaptureMode.Bulk) {
            if (clientconfig.dataCaptureMode == DataCaptureMode.Barcode) {
                msgBox.show('????????? ??????????????????????????? ??????????????? ????????????????????? ??????????????? ???????????? ???????????? ?????????.', 'This device is not authorized for Bulk update', '???????????????????????? / Warning', 'BU01', 'Warning', function () {
                    if (clientconfig.dataCaptureMode == DataCaptureMode.Barcode) {
                        window.location.href = ""Menu"";
                    }
                });
            }
        }
    });

    function getSessionInfo()");
            WriteLiteral(@" {
        isValidClient = sessionStorage.getItem(""IsValidClient"");
        clientconfig = JSON.parse(sessionStorage.getItem(""Clientconfig""));
        userPermissionList = JSON.parse(sessionStorage.getItem(""UserPermissionList""));
        clientIP = sessionStorage.getItem(""ClientIP"");
    }

    //on dataBound event restore previous selected rows:
    function onDataBound(e) {
        var view = this.dataSource.view();
        for (var i = 0; i < view.length; i++) {
            if (checkedIds[view[i].id]) {
                this.tbody.find(""tr[data-uid='"" + view[i].uid + ""']"")
                    .addClass(""k-state-selected"")
                    .find("".k-checkbox"")
                    .attr(""checked"", ""checked"");
            }
        }
    }

    //End of Add Item

    //Excel Upload Controllers : START
    $(function () {
        $('#btnupload').on('click', function () {
            var fileExtension = ['xls', 'xlsx'];
            var filename = $('#fileupload').val();
            ");
            WriteLiteral(@"if (filename.length == 0) {
                alert(""Please select a file."");
                return false;
            }
            else {
                var extension = filename.replace(/^.*\./, '');
                if ($.inArray(extension, fileExtension) == -1) {
                    alert(""Please select only excel files."");
                    return false;
                }
            }
            var fdata = new FormData();
            var fileUpload = $(""#fileupload"").get(0);
            var files = fileUpload.files;
            fdata.append(files[0].name, files[0]);
            $.ajax({
                type: ""POST"",
                url: ""/Home/Import"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""XSRF-TOKEN"",
                        $('input:hidden[name=""__RequestVerificationToken""]').val());
                },
                data: fdata,
                contentType: false,
                processData: false,
                success:");
            WriteLiteral(@" function (response) {
                    if (response.length == 0)
                        alert('Some error occured while uploading');
                    else {
                        $('#divPrint').html(response);
                        var conresponse = tableToJSON();
                        if(conresponse != undefined) {
                            if(conresponse.length != 0) {
                                $(""#gatepass-grid"").data('kendoGrid').dataSource.data([]);
                                var gridData = [];
                                $.each(conresponse, function (index, elements) {
                                    if(index != 0) {
                                        var object = {
                                            Barcode: elements.Barcode,
                                            Color: elements.Color,
                                            Quantity: elements.Quantity,
                                            Remarks: elements.Remarks,
    ");
            WriteLiteral(@"                                        Shedule: elements.Shedule,
                                            Size: elements.Size,
                                            Style: elements.Style
                                        }
                                        gridData.push(object);
                                    }
                                });
                                //console.log(gridData);
                                $(""#gatepass-grid"").data('kendoGrid').dataSource.data(gridData);
                                $(""#fileupload"").val('');
                            }
                        } else {
                            alert(""Upload failed. Please try again"");
                        }
                    }
                },
                error: function (e) {
                    $('#divPrint').html(e.responseText);
                }
            });
        })
        
        $('#btnExport').on('click', function () {
            v");
            WriteLiteral(@"ar fileExtension = ['xls', 'xlsx'];
            var filename = $('#fileupload').val();
            if (filename.length == 0) {
                alert(""Please select a file then Import"");
                return false;
            }
        });
    });

    function tableToJSON() {
        var myRows = [];
        var $headers = $(""th"");
        var $rows = $(""tbody tr"").each(function(index) {
            $cells = $(this).find(""td"");
            myRows[index] = {};
            $cells.each(function(cellIndex) {
                myRows[index][$($headers[cellIndex]).html()] = $(this).html();
            });    
        });
        $('#divPrint').html('');
        return myRows;
    }

    function herfBagGenerator(loc) {
        window.location.href = loc;
    }

</script>


<div>
    <div style=""margin-top: 5px; margin-left: 5px;"">
        <!--CREATE REQUEST BUTTON: BEGIN -->
        <div>
            <div style=""float: left; margin-right: 30px;"">
                <input type=""file");
            WriteLiteral(@""" id=""fileupload"" name=""files"" class="""" style=""width: 566px; height: 33px; border: 3px solid; border-radius: 5px; background: #f4f4f4; color: black; border-color: #dbe7e75e;"" />
            </div>
            <div style=""float: left;"">
                <button id=""btnupload"" class=""k-button"">
                    <span class=""k-icon k-i-plus"" style=""margin-right: 7px;""></span><span>Load Gate Pass</span>
                </button>
            </div>
        </div>
        <div>
            <div style=""float: left; margin-right: 30px; margin-left: 10px; margin-bottom: 15px;"">
                <button id=""upload-gatepass-details"" class=""k-button"" onclick=""tableToJSON()"">
                    <span class=""k-icon k-i-plus"" style=""margin-right: 7px;""></span><span>Upload Gate Pass Data</span>
                </button>
            </div>
        </div>
        <div>
            <div style=""float: left; margin-right: 30px; margin-left: 10px; margin-bottom: 15px;"">
                <button id=""upload-gatepas");
            WriteLiteral(@"s-details"" class=""k-button"" onclick=""herfBagGenerator('CreateBulkBagBarcode')"">
                    <span class=""k-icon k-i-plus"" style=""margin-right: 7px;""></span><span>Size wise Bag generator</span>
                </button>
            </div>
        </div>
    </div>
    <div style=""clear:both;""></div>
    <!--CREATE REQUEST BUTTON: END -->

    <!--FILTER: BEGIN -->
    <div style=""margin: 5px;"">
        <div>
            <div style=""float: left; height: 35px; margin-right: 10px;"">
                <div style=""float: left; width: 110px; margin-right: 10px; text-align: right; font-weight: bold;"">
                    <label for=""date-created-filter"">
                        Date Created
                    </label>
                </div>
                <div style=""float: left;"">
                    <input id=""date-created-filter"" class=""bu-form-control"" style=""width:180px""/>
                </div>
            </div>
            <div style=""float: left; height: 35px; margin-right: 10px");
            WriteLiteral(@";"">
                <div style=""float: left; width: 110px; margin-right: 10px; text-align: right; font-weight: bold;"">
                    <label for=""status-filter"">
                        Status
                    </label>
                </div>
                <div style=""float: left;"">
                    <div id=""status-filter"" class=""bu-form-control"" style=""width:180px""></div>
                </div>
            </div>
            <div style=""float: left; height: 35px; margin-right: 10px;"">
                <div style=""float: left; width: 150px; margin-right: 10px; text-align: right; font-weight: bold;"">
                    <label for=""BagBarcode"">
                        Gate Pass No.
                    </label>
                </div>
                <div style=""float: left;"">
                    <div id=""BagBarcode"" style=""width:180px;""><input id=""weight"" class=""bu-form-control"" style=""width:100%; height: 26px;""/></div>
                </div>
            </div>
        </div>
   ");
            WriteLiteral(@"     <div style=""clear: both;"">
            <div style=""float: left; height: 35px; margin-right: 10px;"">
                <div style=""float: left; width: 110px; margin-right: 10px; visibility: hidden;"">
                    Invisible text
                </div>
                <div style=""float: left;"">
                    <button id=""filterGatePassRequestButton"" class=""k-button"" style=""width: 180px;"" onclick=""RefreshRequestGrid()"">
                        <span class=""k-icon k-i-search"" style=""margin-right: 7px; text-align:left;""></span><span>Search</span>
                    </button>
                </div>
            </div>
        </div>
    </div>
    <!--FILTER: END -->

    <!--DETAILS PAGE GRID: BEGIN -->
    <div id=""divPrint"" hidden=""hidden""></div>
    <div id=""gatepass-grid"" style=""clear: both; padding-top: 5px;""></div>

</div>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
