function attachEventsListeners() {

    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    document.addEventListener('click', function (event) {
        //debugger;
        if (event.target.attributes.type && event.target.attributes.type.value === 'button') {

            let amount = event.target.parentElement.children[1].value;

            if (event.target.attributes.id.value === 'daysBtn') {
                hours.value = amount * 24;
                minutes.value = amount * 1440;
                seconds.value = amount * 86400;
            }
            else if (event.target.attributes.id.value === 'hoursBtn') {
                days.value = amount / 24;
                minutes.value = amount * 60;
                seconds.value = amount * 3600;
            }
            else if (event.target.attributes.id.value === 'minutesBtn') {
                days.value = amount / 1440;
                hours.value = amount / 60;
                seconds.value = amount * 60;
            }
            else if (event.target.attributes.id.value === 'secondsBtn') {
                days.value = amount / 86400;
                hours.value = amount / 3600;
                minutes.value = amount / 60;
            }
        }
    })
}