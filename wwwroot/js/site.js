// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function() {
  kendo.ui.Window.fn._keydown = (function(originalFn) {
    var KEY_ESC = 27;
    return function(e) {
      if (e.which !== KEY_ESC) {
        originalFn.call(this, e);
      }
    };
  })(kendo.ui.Window.fn._keydown);
});
$(document).ready(function() {
  //Initilize Kendo Message Box
  $("#msgWindow").kendoWindow({
    visible: false,
    modal: true
  });

  $("#msgWindow")
    .closest(".k-window")
    .addClass("msgWindowWrapper");

  $("#msgWindowConfirm").kendoWindow({
      visible: false,
      modal: true
    });
  
  $("#msgWindowConfirm")
      .closest(".k-window")
      .addClass("msgWindowWrapper");

  //Start Timer
  startTime();
});

//This msgBox object is used for creating, initilizing and funtioning web site message boxes.
var msgBox = {
  show: function(msgSin, msgEng, title, errorCode, type, okBtnFunc) {
    var okBtn = $("#btnMsgWinOK").unbind();
    var kWin = $("#msgWindow").data("kendoWindow");
    $("#msgWindow")
      .parent()
      .find(".k-window-action")
      .css("visibility", "hidden");
    okBtn.focus();
    okBtn.addClass("msgWindowBtn");
    if (okBtnFunc) {
      okBtn.click(function() {
        okBtnFunc();
        kWin.close();
      });
    } else {
      okBtn.click(function() {
        kWin.close();
      });
    }

    $("#msgSin").html(msgSin);
    $("#msgEng").html(msgEng);
    $("#msgErroCode").html(errorCode);

    if (type == "Warning") {
      $("#msgWindowTitle").html(title);
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgWarningIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowWarning");
    }

    if (type == "Error") {
      $("#msgWindowTitle").html(title);
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgWarningIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowWarning");
    }

    if (type == "Information") {
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgInformationIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowInformation");
    }

    if (type == "success") {
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgSuccIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowSuccess");
    }

    kWin.open();
    kWin.center();
  }
};


//This msgBox object is used for creating, initilizing and funtioning web site Confirm message boxes.
var msgBoxConfirm = {
  show: function(msgSin, msgEng, title, errorCode, type, okBtnFunc,CancelBtnFunc) {
    var okBtn = $("#btnMsgWinOKC").unbind();
    var CancelBtn = $("#btnMsgWinCancelC").unbind();
   
    var kWin = $("#msgWindowConfirm").data("kendoWindow");
    $("#msgWindowConfirm")
      .parent()
      .find(".k-window-action")
      .css("visibility", "hidden");
    okBtn.focus();
    okBtn.addClass("msgWindowBtn");
    CancelBtn.addClass("msgWindowBtn");

    if (okBtnFunc) {
      okBtn.click(function() {
        okBtnFunc();
        kWin.close();
      });
    } 
    if (CancelBtnFunc) {
      CancelBtn.click(function() {
        CancelBtnFunc();
        kWin.close();
      });
    }  
    
    $("#msgSinC").html(msgSin);
    $("#msgEngC").html(msgEng);
    $("#msgErroCodeC").html(errorCode);

    if (type == "Warning") {
      $("#msgWindowTitle").html(title);
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgWarningIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowWarning");
    }

    if (type == "Error") {
      $("#msgWindowTitle").html(title);
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgWarningIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowWarning");
    }

    if (type == "Information") {
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgInformationIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowInformation");
    }

    if (type == "success") {
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgSuccIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowSuccess");
    }

    if (type == "Confirm") {
      $("#msgWindowTitle").html(title);
      $(".msgWindowWrapper")
        .find(".k-window-title")
        .html($("#msgWarningIcon").html());
      $(".msgWindowWrapper")
        .find(".k-window-titlebar")
        .addClass("msgWindowConfirm");
    }
    kWin.open();
    kWin.center();
  }
};
//This validator object is used for page control validation
var validator = {
  validate: function(extraValidations) {
    var isValid = Answer.Yes;
    $("[data-validatefor]").each(function() {
      var control = $(this);
      if (!validator.validateControler(control)) {
        isValid = Answer.No;
      }
    });

    console.log("Before External Validation:" + isValid);

    if (extraValidations) {
      var extValidation = extraValidations();
      console.log("Extravalidation: " + extValidation);
      if (extValidation == false) {
        isValid = Answer.No;
      }
    }

    console.log("Final Validation:" + isValid);

    return isValid;
  },

  validateControler: function(control) {
    var msg = "";
    var valMsgReqF = $("#validationMsgRequiredField").html();
    var valMsgReOpt = $("#validationMsgRequiredOpt").html();
    var isValid = Answer.Yes;
    var controlParent = control.parents(".validateCol");
    var validationType = control.attr("data-validatefor");
    var controlName = control.attr("name");
    if (control.attr("type") == "radio") {
      if ($('[name="' + controlName + '"]:checked').length == 0) {
        msg = valMsgReOpt;
        isValid = Answer.No;
      } else {
        controlParent.find(".validationMsg").remove();
      }

      if (!isValid) {
        control.click(function() {
          validator.validateControler(control);
          return true;
        });
      }
    } else if (
      control.is("textarea") ||
      control.attr("type") == "text" ||
      control.attr("type") == "number" ||
      control.attr("type") == "password"
    ) {
      if (control.val().trim() == "") {
        msg = valMsgReqF;
        isValid = Answer.No;
      } else {
        controlParent.find(".validationMsg").remove();
      }

      if (!isValid) {
        control.blur(function() {
          validator.validateControler(control);
        });
      }
    } else if (control.attr("type") == "checkbox") {
      if (control.is(":checked")) {
        controlParent.find(".validationMsg").remove();
      } else {
        msg = valMsgReqF;
        isValid = Answer.No;
      }

      if (!isValid) {
        control.click(function() {
          validator.validateControler(control);
        });
      }
    } else if (control.is('[data-role="dropdownlist"]')) {
      if (
        !$("#" + control.attr("id"))
          .data("kendoDropDownList")
          .value()
      ) {
        msg = valMsgReqF;
        isValid = Answer.No;
      } else {
        controlParent.find(".validationMsg").remove();
      }

      if (!isValid) {
        control.change(function() {
          validator.validateControler(control);
        });
      }
    }

    if (msg != "") {
      validator.appendMsg(controlParent, msg);
    }

    if (control.attr("data-mappingName")) {
      console.log(control.attr("data-mappingName") + " : " + isValid);
    } else if (control.attr("data-bind")) {
      console.log(control.attr("data-bind") + " : " + isValid);
    } else {
      console.log(
        "Other: Id:" +
          control.attr("id") +
          " Name:" +
          control.attr("name") +
          ":  " +
          isValid
      );
    }

    return isValid;
  },

  createMsgObj: function() {
    return $('<div class="validationMsg"></div>');
  },

  appendMsg: function(controlParent, msg) {
    if (controlParent.find(".validationMsg").length == 0) {
      var validaitonMgsgControl = validator.createMsgObj();
      validaitonMgsgControl.html(msg);
      controlParent.append(validaitonMgsgControl);
    }
  },

  removeMsg: function(control) {
    control
      .parents(".validateCol")
      .find(".validationMsg")
      .remove();
  },

  validateDecision: function() {
    var isValid = Answer.Yes;
    if ($('[name="decisionOpt"]').is(":checked")) {
      var decisionOpt = $('[name="decisionOpt"]:checked');
      if (decisionOpt.val() == "false") {
        var rejectDrop = $("#rejectReason").data("kendoDropDownList");
        var controlParent = $("#rejectReason").parents(".validateCol");
        if (!rejectDrop.value()) {
          isValid = Answer.No;
          validator.appendMsg(
            controlParent,
            "* Value is required for this feild"
          );
          $("#rejectReason").change(function() {
            validator.validateDecision();
          });
        } else {
          controlParent.find(".validationMsg").remove();
        }
      }
    }
    return isValid;
  }
};

function isNumberKey(evt, obj) {
  var charCode = evt.which ? evt.which : event.keyCode;
  if (charCode > 31 && (charCode < 48 || charCode > 57)) return false;
  return true;
}

function formatErrorMessage(jqXHR, exception, thrownPage) {
  try {
    if (jqXHR.status === 0) {
      msgBox.show(
        "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "Error jqXHR.status = 0. Please contact a IT helpdesk officer",
        "දෝෂයකි / Error",
        "ER01",
        "Error",
        function() {
          sessionStorage.setItem(
            "ErrorSin",
            "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න."
          );
          sessionStorage.setItem(
            "ErrorEng",
            "Error jqXHR.status = 0. Please contact a IT helpdesk officer."
          );
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
      //throw new Error("");
      //"Not connected.\nPlease verify your network connection.";
    } else if (jqXHR.status == 404) {
      //"The requested page not found.";
      msgBox.show(
        "ඔබ ඉල්ලුම් කල වෙබ් පිටුව නොමැත. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "The requested page not found. Please contact a IT helpdesk officer",
        "අවවාදයයි / Warning",
        "JQXHR.STATUS : 404",
        "Error",
        function() {
          sessionStorage.setItem(
            "ErrorSin",
            "ඔබ ඉල්ලුම් කල වෙබ් පිටුව නොමැත. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න."
          );
          sessionStorage.setItem(
            "ErrorEng",
            "The requested page not found. Please contact a IT helpdesk officer"
          );
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
    } else if (jqXHR.status == 401) {
      //"Sorry!! You session has expired. Please login to continue access.";
      msgBox.show(
        "කණගාටුයි. ඔබගේ වාරය අවසානයි. කරුණාකර නැවත පිවිසෙන්න.",
        "Sorry. You session has expired. Please login to continue access.",
        "අවවාදයයි / Warning",
        "JQXHR.STATUS : 401",
        "Error",
        function() {
          sessionStorage.setItem("IsSignedIn", Answer.No);
          sessionStorage.setItem("UserId", "");
          $("#toolBarLoggedinUser").html(sessionStorage.getItem("UserId"));
          $("#loginBar").hide();
          window.location.href = "Login";
        }
      );
    } else if (jqXHR.status == 500) {
      //Internal Server Error.";
      msgBox.show(
        "අභ්‍යන්තර තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "Internal Server Error. Please contact a IT helpdesk officer",
        "අවවාදයයි / Warning",
        "JQXHR.STATUS : 500",
        "Error",
        function() {
          sessionStorage.setItem(
            "ErrorSin",
            "අභ්‍යන්තර තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න."
          );
          sessionStorage.setItem(
            "ErrorEng",
            "Internal Server Error. Please contact a IT helpdesk officer"
          );
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
    } else if (exception === "parsererror") {
      //"Requested JSON parse failed.";
      msgBox.show(
        "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "Requested JSON parse failed. Please contact a IT helpdesk officer",
        "අවවාදයයි / Warning",
        "PARSER ERROR",
        "Error",
        function() {
          sessionStorage.setItem(
            "ErrorSin",
            "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න."
          );
          sessionStorage.setItem(
            "ErrorEng",
            "Internal Server Error. Please contact a IT helpdesk officer"
          );
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
    } else if (exception === "timeout") {
      //"Time out error.";
      msgBox.show(
        "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "Time out error. Please contact a IT helpdesk officer",
        "අවවාදයයි / Warning",
        "TIMEOUT ERROR",
        "Error",
        function() {
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
    } else if (exception === "abort") {
      //"Ajax request aborted.";
      msgBox.show(
        "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "Ajax request aborted. Please contact a IT helpdesk officer",
        "අවවාදයයි / Warning",
        "ABORT ERROR",
        "Error",
        function() {
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
    } else {
      //"Unknown error occured. Please try again.";
      msgBox.show(
        "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
        "Unknown error occured. Please contact a IT helpdesk officer",
        "අවවාදයයි / Warning",
        "UNKNOWN ERROR",
        "Error",
        function() {
          //window.location.href = "Error";
          window.location.href = thrownPage;
        }
      );
    }
  } catch (e) {
    msgBox.show(
      "තාක්ෂණ ගැටලුවකි. කරුණාකර තොරතුරු තාක්ෂණ නිලධාරියෙකු අමතන්න.",
      e.stack,
      "දෝෂයකි / Error",
      "ER01",
      "Error",
      function() {
        sessionStorage.setItem("ErrorSin", "");
        sessionStorage.setItem("ErrorEng", e);
        //window.location.href = "Error";
        window.location.href = thrownPage;
      }
    );
  }
}

//Function to strat timer to display time in the top left corner.
function startTime() {
  var date = new Date();
  var hours = date.getHours();
  var minutes = date.getMinutes();
  var seconds = date.getSeconds();
  var ampm = hours >= 12 ? "PM" : "AM";
  hours = hours % 12;
  hours = hours ? hours : 12; // the hour '0' should be '12'
  minutes = minutes < 10 ? "0" + minutes : minutes;
  seconds = seconds < 10 ? "0" + seconds : seconds;
  var strTime = hours + ":" + minutes + ":" + seconds + " " + ampm;

  $("#timer").html(strTime);
  var t = setTimeout(startTime, 500);
}
function checkTime(i) {
  if (i < 10) {
    i = "0" + i;
  } // add zero in front of numbers < 10
  return i;
}
