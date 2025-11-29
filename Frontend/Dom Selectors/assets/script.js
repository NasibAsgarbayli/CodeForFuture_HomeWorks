function calculate(op) {
    let a = parseFloat(document.getElementById("num1").value);
    let b = parseFloat(document.getElementById("num2").value);
    let res = "";

    if (isNaN(a) || isNaN(b)) {
        res = "Xahiş olunur ədədləri daxil edin!";
    } else {
        switch (op) {
            case "add": res = a + b; break;
            case "sub": res = a - b; break;
            case "mul": res = a * b; break;
            case "div": 
                res = b === 0 ? "0-a bölmək olmaz!" : a / b;
                break;
        }
    }

    document.getElementById("result").value = res;
}
