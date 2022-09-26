
let takeValue = () => {
    let value = document.getElementById("opcions").value
    console.log(value)

    if (value == 0) {
        document.getElementById("value").setAttribute("placeholder", "0%")
    }
    if (value == 1) {
        document.getElementById("value").setAttribute("placeholder", "22%")
    }
    if (value == 2) {
        document.getElementById("value").setAttribute("placeholder", "12%")
    }
    if (value == 3) {
        document.getElementById("value").setAttribute("placeholder", "8%")
    }
}