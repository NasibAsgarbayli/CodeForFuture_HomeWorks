document.addEventListener("DOMContentLoaded", function () {

    const button = document.getElementById("loadBtn");
    const tbody = document.querySelector("#commentsTable tbody");

    button.addEventListener("click", () => {
        fetch("https://jsonplaceholder.typicode.com/comments")
            .then(res => res.json())
            .then(data => {
                tbody.innerHTML = ""; // təmizlə

                data.forEach(item => {
                    const tr = document.createElement("tr");

                    const tdId = document.createElement("td");
                    tdId.textContent = item.id;
                    tr.appendChild(tdId);

                    const tdName = document.createElement("td");
                    tdName.textContent = item.name;
                    tr.appendChild(tdName);

                    const tdEmail = document.createElement("td");
                    tdEmail.textContent = item.email;
                    tr.appendChild(tdEmail);

                    const tdBody = document.createElement("td");
                    tdBody.textContent = item.body;
                    tr.appendChild(tdBody);

                    tbody.appendChild(tr);
                });
            })
            .catch(err => console.log("Xəta:", err));
    });

});
