document.getElementById("contactForm").addEventListener("submit", function (event) {
    event.preventDefault();

    // get value
    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var message = document.getElementById("message").value;

    console.log("Name: " + name);
    console.log("Email: " + email);
    console.log("Message: " + message);

    // clear all
    document.getElementById("name").value = "";
    document.getElementById("email").value = "";
    document.getElementById("message").value = "";

});