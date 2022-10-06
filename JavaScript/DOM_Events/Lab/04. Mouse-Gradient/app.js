// function attachGradientEvents2() {
//     let source = document.getElementById('gradient');
//     let result = document.getElementById('result');

//     source.addEventListener('mousemove', function (event) {
//         showResult(event);
//     });

//     function showResult(e) {
//         result.textContent = (Math.floor((e.clientX - 10) / 3) / 100).toLocaleString("en", { style: "percent" });
//     }
// }

function attachGradientEvents() {
    let gradient = document.getElementById('gradient');
    gradient.addEventListener('mousemove', gradientMove);
    gradient.addEventListener('mouseout', gradientOut);
    function gradientMove(event) {
        let power = event.offsetX / (event.target.clientWidth - 1);
        power = Math.trunc(power * 100);
        document.getElementById('result').textContent = power + "%";
    }
    function gradientOut(event) {
        document.getElementById('result').textContent = "";
    }
}
