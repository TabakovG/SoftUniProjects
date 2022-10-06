function attachEventsListeners() {
    let convert = document.getElementById('convert');
    let source = document.getElementById('inputDistance');
    let sourceType = document.getElementById('inputUnits');
    let result = document.getElementById('outputDistance');
    let resultType = document.getElementById('outputUnits');

    let targetToMeters = { 
        km: 1000, 
        m: 1, 
        cm: 0.01, 
        mm: 0.001, 
        mi: 1609.34, 
        yrd: 0.9144, 
        ft: 0.3048, 
        in: 0.0254 
    };


    convert.addEventListener('click', function (event) {

        let tempValue = source.value * targetToMeters[sourceType.value];
        result.value = tempValue / targetToMeters[resultType.value]
        console.log(tempValue);

    })
}