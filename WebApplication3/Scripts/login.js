// get element
const input1 = document.getElementById("account");
const input2 = document.getElementById("password");
const btn = document.getElementById("btn");

// if button is clicked
btn.addEventListener("click", () => {
    const value1 = input1.value;
    const value2 = input2.value;

    // input element has value
    if (value1 && value2) {
        window.location.href = "/Main/Main"; // page jump 
    } else {
        alert("Enter account or password please.")
    }
});