// Input dəyişəndə ekrana göstəririk
document.getElementById("nameInput").addEventListener("input", function(e) {
    document.getElementById("result").innerHTML =
        "Daxil etdiyiniz ad: <b>" + e.target.value + "</b>";
});

// Buttona klik olanda navigation edirik
document.getElementById("goBtn").addEventListener("click", function() {
    const name = document.getElementById("nameInput").value.trim();

    if (name === "") {
        alert("Ad boş ola bilməz!");
        return;
    }

    // Başqa səhifəyə yönləndiririk (misal üçün welcome.html)
    window.location.href = "welcome.html?name=" + encodeURIComponent(name);
});
