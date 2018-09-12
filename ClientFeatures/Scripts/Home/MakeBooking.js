function processResponse(appt) {
    $('#successClientName').text(appt.ClientName);
    switchViews();
}

function switchViews() {
    $(".hidden, .visible").toggleClass("hidden visible");
}

$(document).ready(function () {
    $('#backButton').click(function (e) {
        switchViews();
    });
});