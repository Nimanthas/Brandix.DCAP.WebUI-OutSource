#pragma checksum "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "790aad9b647635779e6fde8ebfedf6f6b756be5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MinimumQtyReport), @"mvc.1.0.view", @"/Views/Home/MinimumQtyReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MinimumQtyReport.cshtml", typeof(AspNetCore.Views_Home_MinimumQtyReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790aad9b647635779e6fde8ebfedf6f6b756be5f", @"/Views/Home/MinimumQtyReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ac14fb493c2990ba4a5667bd32d8705427078c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MinimumQtyReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 3090, true);
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

    
    getSessionInfo();

    $(document).ready(function () {
        $('#sitebody').removeClass('body-login');
        $(""#sitebody"").append(
            '<div id=""ajaxBusy"" class=""ajaxBusy""></div>'
        );
        $(""#ajaxBusy"").hide();
        checkLoginStatus();
        $('#pageTitleBar').html('<i class=""fas fa-barcode pageMainIcon""></i><span class=""pageTitle"">DCap - Update Details</span>');

        initializeControls();

        checkIdle();

        if (isValidClient == Answer.Null) {
            window.location.");
            WriteLiteral(@"href = ""Login"";
        }
        else if (isValidClient != null && clientconfig.dataCaptureMode != DataCaptureMode.Bulk) {
            if (clientconfig.dataCaptureMode == DataCaptureMode.Barcode) {
                msgBox.show('මෙම යන්ත්‍රයට බල්ක් අප්ඩේට් කිරීම සඳහා අවසර නැත.', 'This device is not authorized for Bulk update', 'අවවාදයයි / Warning', 'BU01', 'Warning', function () {
                    if (clientconfig.dataCaptureMode == DataCaptureMode.Barcode) {
                        window.location.href = ""Menu"";
                    }
                });
            }
        }
    });
    
    function resetControllers() {
        $(""#btnSearch"").attr('disabled', 'disabled');
        $(""#btnSearch"").attr('disabled', 'disabled');
        $(""#btnSearch"").attr('disabled', 'disabled');
    }

    function getSessionInfo() {
        isValidClient = sessionStorage.getItem(""IsValidClient"");
        clientconfig = JSON.parse(sessionStorage.getItem(""Clientconfig""));
        userPermissionList ");
            WriteLiteral(@"= JSON.parse(sessionStorage.getItem(""UserPermissionList""));
        clientIP = sessionStorage.getItem(""ClientIP"");
    }

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

    function initializeControls() {  
        console.log(sessionStorage, JSON.parse(sessionStorage.getItem(""Clientconfig"")));

        //Hide Filters
        $(""#color-filter"").hide();
        $(""#shedule-filter"").hide();
        console.log(""outputs :"", $(""#style"").val(), $(""#shedule"").val(), $(""#color"").val())

        //Style Dropdown: START
        $.ajax({
");
            WriteLiteral("            url: \'");
            EndContext();
            BeginContext(3123, 14, false);
#line 90 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
             Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(3137, 924, true);
            WriteLiteral(@"/Lookup/GetAllStyles',
            type: 'GET',
            dataType: 'json',
            //async: false,
            contentType: 'application/json',
            beforeSend: function () {
                $(""#ajaxBusy"").show();
            },
            complete: function () {
                $(""#ajaxBusy"").hide();
            },
            success: function (response) {
                $(""#style"").kendoDropDownList({""dataSource"": response, change: function(e) {loadShedule(this.value())}, filter: ""contains"",""dataTextField"": ""l1desc"",""dataValueField"": ""l1id"",""optionLabel"": ""select a style...""});
                loadShedule();
            },
            error: function (jqXHR, textStatus, errorThrown) {
                formatErrorMessage(jqXHR, errorThrown, ""Dispatch"");
            }
        });
        //Style Dropdown: START

        //Main Table: START
        var crudServiceBaseUrl = """);
            EndContext();
            BeginContext(4062, 14, false);
#line 112 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
                             Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(4076, 4887, true);
            WriteLiteral(@"/BusinessLogics"",
        dataSource = new kendo.data.DataSource({
            transport: {
                        read: function(options) {
                        /* implementation omitted for brevity */
                        },
                        update: function(options) {
                            console.log(""update row data: "", JSON.stringify(options.data.models));
                            $.ajax({
                                url: crudServiceBaseUrl + ""/UpdateWashDetails"",
                                type: 'POST',
                                dataType: ""json"",
                                data: JSON.stringify(options.data.models),
                                contentType: 'application/json; charset=utf-8',
                                success: function(result) {
                                    refreshGrid();
                                options.success(result);
                                },
                                error: function(re");
            WriteLiteral(@"sult) {
                                    formatErrorMessage(jqXHR, errorThrown, ""Update Details"");
                                options.error(result);
                                }
                            });
                        }
                    },
                    batch: true,
                    pageSize: 20,
                    schema: {
                        model: {
                            id: ""Key"",
                            fields: {
                                Key: { type: ""string"", editable: false, nullable: true },
                                L1: { type: ""number"", editable: false , validation: { required: true } },
                                Style: { type: ""string"", editable: false , validation: { required: true } },
                                L2: {type: ""number"", editable: false ,  validation: { required: true } },
                                Shedule: { type: ""string"", editable: false , validation: { required: true } },
     ");
            WriteLiteral(@"                           PO: { type: ""string"", editable: false , validation: { required: true } },
                                Zfeature: { type: ""string"", editable: false , validation: { required: true } },
                                L4: { type: ""number"", editable: false , validation: { required: true } },
                                Color: { type: ""string"", editable: false , validation: { required: true } },
                                WashProcess: { type: ""string"", validation: { min: 1, required: true } },
                                WashType: { type: ""string"", validation: { min: 1, required: true } },
                                GMTWeight: { type: ""number"", validation: { min: 0, required: true } },
                                WashDuration: { type: ""number"", validation: { min: 0, required: true } },
                                UnitPrice: { type: ""number"", validation: { required: true, min: 1} },
                                Category: { type: ""string"" },
      ");
            WriteLiteral(@"                      }
                        }
                    }
                });

                $(""#request-grid"").kendoGrid({
                    dataSource: dataSource,
                    pageable: {
                        refresh: true,
                        pageSizes: true,
                        buttonCount: 5
                    },
                    columns: [
                        { field:""Style"", title: ""Style Name"", width: ""120px"" },
                        { field:""Shedule"", title: ""Shedule"", width: ""120px"" },
                        { field:""PO"", title: ""PO"", width: ""120px"" },
                        { field:""Zfeature"", title: ""Z-feature"", width: ""100px"" },
                        { field:""Color"", title: ""Color"", width: ""170px"" },
                        { field:""WashProcess"", title: ""Wash Process"" , editor: customEditorSFProcess },
                        { field:""WashType"", title: ""Wash Type"" , editor: customEditorWashProcess },
                        { ");
            WriteLiteral(@"field:""GMTWeight"", title: ""Garment Weight"" },
                        { field:""WashDuration"", title: ""Wash Duration"" },
                        { field:""UnitPrice"", title:""Unit Price"", format: ""{0:c}"", width: ""120px"" },
                        { field:""Category"", title: ""Category"" },
                        { command: [""edit""], title: ""&nbsp;"", width: ""90px"" }],
                    editable: ""popup""
                });
            //Main Table: END
    }

    function loadShedule(style) {
        console.log(""outputs :"", $(""#style"").val(), $(""#shedule"").val(), $(""#color"").val())
        console.log(style);
        $(""#color-filter"").hide();
        if(style == undefined || style == null || style == """") {
        } else {
            $.ajax({
                url: '");
            EndContext();
            BeginContext(8964, 14, false);
#line 195 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
                 Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(8978, 1250, true);
            WriteLiteral(@"/Lookup/GetAllShedules?l1=' + style,
                type: 'GET',
                dataType: 'json',
                async: false,
                contentType: 'application/json',
                beforeSend: function () {
                    $(""#ajaxBusy"").show();
                },
                complete: function () {
                    $(""#ajaxBusy"").hide();
                },
                success: function (response) {
                    $(""#shedule-filter"").show();
                    $(""#shedule"").kendoDropDownList({""dataSource"": response, change: function(e) {loadColor(style, this.value())}, filter: ""contains"",""dataTextField"": ""l2desc"",""dataValueField"": ""l2id"",""optionLabel"": ""select a shedule...""});
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    formatErrorMessage(jqXHR, errorThrown, ""Dispatch"");
                }
            });
        }
    }

    function loadColor(style, color) {
        console.log(""outputs :""");
            WriteLiteral(", $(\"#style\").val(), $(\"#shedule\").val(), $(\"#color\").val())\r\n        console.log(style, color);\r\n        if(color == undefined || color == null || color == \"\") {\r\n        } else {\r\n            $.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(10229, 14, false);
#line 223 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
                 Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(10243, 1196, true);
            WriteLiteral(@"/Lookup/GetAllColors?l1=' + style + '&l2=' + color,
                type: 'GET',
                dataType: 'json',
                async: false,
                contentType: 'application/json',
                beforeSend: function () {
                    $(""#ajaxBusy"").show();
                },
                complete: function () {
                    $(""#ajaxBusy"").hide();
                },
                success: function (response) {    
                    $(""#color-filter"").show();
                    $(""#color"").kendoDropDownList({""dataSource"": response, filter: ""contains"",""dataTextField"": ""l4desc"",""dataValueField"": ""l4id"",""optionLabel"": ""select a color...""});
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    formatErrorMessage(jqXHR, errorThrown, ""Dispatch"");
                }
            });
        }
    }

    function refreshGrid() {
        if($(""#style"").val() == undefined || $(""#shedule"").val() == undefined  || ");
            WriteLiteral("$(\"#color\").val() == undefined  ) {\r\n\r\n        } else {\r\n            $(\"#request-grid\").data(\'kendoGrid\').dataSource.data([]);\r\n            $.ajax({\r\n                url: \"");
            EndContext();
            BeginContext(11440, 14, false);
#line 251 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
                 Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(11454, 3505, true);
            WriteLiteral(@"/Lookup/GetAllStyleSheduleColorDetails?l1id="" + ($(""#style"").val() != """" ? $(""#style"").val() : -1) + ""&l2id="" + ($(""#shedule"").val() != """" ? $(""#shedule"").val() : -1) + ""&l4id="" + ($(""#color"").val() != """" ? $(""#color"").val() : -1),
                type: 'GET',
                dataType: 'json',
                async: false,
                contentType: 'application/json',
                beforeSend: function () {
                    $(""#ajaxBusy"").show();
                },
                complete: function () {
                    $(""#ajaxBusy"").hide();
                },
                success: function (response) {
                    console.log(response);
                    if(response.length != 0){
                        gridData = [];
                        $.each(response, function (index, elements) {
                            var object = {
                                Key: elements.key,
                                L1: elements.l1,
                                Style");
            WriteLiteral(@": elements.style,
                                L2: elements.l2,
                                Shedule: elements.shedule,
                                PO: elements.po,
                                Zfeature: elements.zfeature,
                                L4: elements.l4,
                                Color: elements.color,
                                WashProcess: elements.washProcess,
                                WashType: elements.washType,
                                GMTWeight: elements.gmtWeight,
                                WashDuration: elements.washDuration,
                                UnitPrice: elements.unitPrice,
                                Category: elements.category,
                            }
                            gridData.push(object);
                            console.log(""row data :"", object);
                        });
                        $(""#request-grid"").data('kendoGrid').dataSource.data(gridData);
                    } ");
            WriteLiteral(@"else {

                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    formatErrorMessage(jqXHR, errorThrown, ""Dispatch"");
                }
            });
        }
    }

    function OnGridDataBound(e) {
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
        var row = $(e.ta");
            WriteLiteral(@"rget).closest(""tr"");
        var checkbox = $(row).find("".k-checkbox"");

        checkbox.click();
    };

    //Grid Controllers: START
    function customEditorWashProcess(container, options) {
        $('<input id=""washprocess-dropdown"" name=""WashType"" class=""k-input"" style=""width:180px""/>').appendTo(container);
        loadWashProcess();
    }

    function loadWashProcess() {
        $.ajax({
            url: '");
            EndContext();
            BeginContext(14960, 14, false);
#line 336 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
             Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(14974, 1128, true);
            WriteLiteral(@"/Lookup/GetAllWashes',
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: 'application/json',
            beforeSend: function () {
                $(""#ajaxBusy"").show();
            },
            complete: function () {
                $(""#ajaxBusy"").hide();
            },
            success: function (response) {
                console.log(""All washes dropdown data"", response);   
                $(""#washprocess-dropdown"").kendoDropDownList({""dataSource"": response, filter: ""contains"",""dataTextField"": ""washName"",""dataValueField"": ""washCatId"",""optionLabel"": ""select a wash...""});
            },
            error: function (jqXHR, textStatus, errorThrown) {
                formatErrorMessage(jqXHR, errorThrown, ""Dispatch"");
            }
        });
    }

    function customEditorSFProcess(container, options) {
        $('<input id=""sfprocess-dropdown"" class=""k-input"" name=""WashProcess"" style=""width:180px""/>').appendTo(container);");
            WriteLiteral("\n        loadSFProcess();\r\n    }\r\n\r\n    function loadSFProcess() {\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(16103, 14, false);
#line 364 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - OutSource\Views\Home\MinimumQtyReport.cshtml"
             Write(ViewBag.APIURL);

#line default
#line hidden
            EndContext();
            BeginContext(16117, 4139, true);
            WriteLiteral(@"/Lookup/GetAllSFProcess',
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: 'application/json',
            beforeSend: function () {
                $(""#ajaxBusy"").show();
            },
            complete: function () {
                $(""#ajaxBusy"").hide();
            },
            success: function (response) { 
                console.log(""All sf process dropdown data"", response);     
                $(""#sfprocess-dropdown"").kendoDropDownList({""dataSource"": response, filter: ""contains"",""dataTextField"": ""sfName"",""dataValueField"": ""sfCatId"",""optionLabel"": ""select a sf process...""});
            },
            error: function (jqXHR, textStatus, errorThrown) {
                formatErrorMessage(jqXHR, errorThrown, ""Dispatch"");
            }
        });
    }

    //Grid Controllers: END
</script>


<div>
    <div style=""margin-top: 5px; margin-left: 5px;"">
        <!--FILTER: BEGIN -->
        <div style=""margin: 5px;"">");
            WriteLiteral(@"
            <div>
                <div style=""float: left; height: 35px; margin-right: 10px;"" id=""style-filter"">
                    <div style=""float: left; width: 110px; margin-right: 10px; text-align: right; font-weight: bold;"">
                        <label for=""style"">
                            Style
                        </label>
                    </div>
                    <div style=""float: left;"">
                        <input id=""style"" class=""bu-form-control"" style=""width:180px""/>
                    </div>
                </div>
                <div style=""float: left; height: 35px; margin-right: 10px;"" id=""shedule-filter"">
                    <div style=""float: left; width: 110px; margin-right: 10px; text-align: right; font-weight: bold;"">
                        <label for=""shedule"">
                            Shedule
                        </label>
                    </div>
                    <div style=""float: left;"">
                        <input id=""shedule"" ");
            WriteLiteral(@"class=""bu-form-control"" style=""width:180px""/>
                    </div>
                </div>
                <div style=""float: left; height: 35px; margin-right: 10px;"" id=""color-filter"">
                    <div style=""float: left; width: 150px; margin-right: 10px; text-align: right; font-weight: bold;"">
                        <label for=""color"">
                            Color
                        </label>
                    </div>
                    <div style=""float: left;"">
                        <input id=""color"" class=""bu-form-control"" style=""width:180px""/>
                    </div>
                </div>
                <!--<div style=""float: left; height: 35px; margin-right: 10px;"" id=""color-filter"">
                    <div style=""float: left; width: 150px; margin-right: 10px; text-align: right; font-weight: bold;"">
                        <label for=""status"">
                            Status
                        </label>
                    </div>
              ");
            WriteLiteral(@"      <div style=""float: left;"">
                        <input id=""status"" class=""bu-form-control"" style=""width:180px""/>
                    </div>
                </div>-->
            </div>
            <div style=""clear: both;"">
                <div style=""float: left; height: 35px; margin-right: 10px;"">
                    <div style=""float: left; width: 110px; margin-right: 10px; visibility: hidden;"">
                        Invisible text
                    </div>
                    <div style=""float: left;"">
                        <button id=""filterGatePassRequestButton"" class=""k-button"" style=""width: 180px;"" onclick=""refreshGrid()"">
                            <span class=""k-icon k-i-search"" style=""margin-right: 7px; text-align:left;""></span><span>Search</span>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <!--FILTER: END -->

    <!--DETAILS PAGE GRID: BEGIN -->
    <div id=""request-grid"" style=""c");
            WriteLiteral("lear: both; padding-top: 5px;\">\r\n</div>\r\n\r\n");
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
