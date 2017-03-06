(function() {
  const TIMEOUT = 10000; // 10 seconds waiting for response, then "NOPE"
  const $dots = $("#dots");
  const $subtitle = $("#subtitle");

  var setStatus = function(status, subtitle, dotsInterval) {
    $subtitle.text(subtitle).show();
    $("#status").text(status);
    clearInterval(dotsInterval);
    $dots.hide();
  }

  $(document).ready(function() {
    var dotsInterval = setInterval(function() {
      if($dots.text().length == 3) {
        $dots.text('');
      } else {
        $dots.text($dots.text() + '.');
      }
    }, 200);

    $.ajax({
      url: "http://212.33.66.221:3003/isOfficeOpened",
      timeout: TIMEOUT,
      success: function(result) {
        var subtitle = "But it can be closed in any time.";
        if (result.OpenUntil.length > 0) {
          try {
            var time = new Date(result.OpenUntil);
            var hr = time.getHours();
            var mn = time.getMinutes();
            subtitle = "Probably until " + (hr < 10 ? "0" + hr : hr) + ":" + (mn < 10 ? "0" + mn : mn) + ' (local time)';;
          }
          catch(ex) {
            // nothing
          }
        }
        setStatus("YUP", subtitle, dotsInterval);
      },
      error: function(errror) {
        var subtitle = "But they may be hiding in there...";
        setStatus("NOPE", subtitle, dotsInterval);
      },
    });
  });
})();
