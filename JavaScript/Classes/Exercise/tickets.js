function createTickets(arr, sortBy){
    class Ticket{
        constructor(destination, price, status)
        {
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }
    let result = [];
    for (const ticketData of arr) {
        let [destination, price, status] = ticketData.split('|');
        result.push(new Ticket(destination, price, status));
    }

    result = result.sort((a, b)=> {
        return typeof(a[sortBy]) === 'number' ? 
        a[sortBy] - b[sortBy]:
        a[sortBy].localeCompare(b[sortBy])
    });

    return result;
}

console.log(createTickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination'
));
console.log(createTickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'price'
));