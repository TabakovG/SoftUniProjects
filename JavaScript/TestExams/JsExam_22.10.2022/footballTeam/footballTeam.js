class footballTeam {
    constructor(clubName, country) {
        this.clubName = clubName;
        this.country = country;
        this.invitedPlayers = [];
    }

    newAdditions(footballPlayers) {
        footballPlayers.forEach(p => {
            let [name, age, playerValue] = p.split('/');
            let player = this.invitedPlayers.find(p => p.name === name);
            if (player === undefined) {
                this.invitedPlayers.push({ name, age: Number(age), playerValue: Number(playerValue) });
            }
            else {
                if (player.playerValue < Number(playerValue)) {
                    player.playerValue = Number(playerValue);
                }
            }
        });

        return `You successfully invite ${this.invitedPlayers.map(x => x.name).join(', ')}.`
    }

    signContract(selectedPlayer) {
        let [name, playerOffer] = selectedPlayer.split('/');
        let player = this.invitedPlayers.find(p => p.name === name);
        if (player === undefined) {
            throw new Error(`${name} is not invited to the selection list!`);
        }
        if (player.playerValue > Number(playerOffer)) {
            let priceDifference = player.playerValue - Number(playerOffer);
            throw new Error(`The manager's offer is not enough to sign a contract with ${name}, ${priceDifference} million more are needed to sign the contract!`)
        }
        else {
            player.playerValue = 'Bought'
        }
        return `Congratulations! You sign a contract with ${player.name} for ${playerOffer} million dollars.`
    }

    ageLimit(name, age) {
        let player = this.invitedPlayers.find(p => p.name === name);
        if (player === undefined) {
            throw new Error(`${name} is not invited to the selection list!`);
        }
        if (player.age < Number(age)) {
            let ageDifference = Number(age) - player.age;
            if (ageDifference < 5) {
                return `${name} will sign a contract for ${ageDifference} years with ${this.clubName} in ${this.country}!`;
            }
            else {
                return `${name} will sign a full 5 years contract for ${this.clubName} in ${this.country}!`;
            }
        }
        else {
            return `${name} is above age limit!`
        }
    }

    transferWindowResult() {
        let result = "Players list:\n";
        this.invitedPlayers
            .sort((a, b) => a.name.localeCompare(b.name))
            .forEach(p => {
                result += `Player ${p.name}-${p.playerValue}\n`
            })
            return result.trim();
    }
}

let fTeam = new footballTeam("Barcelona", "Spain");
console.log(fTeam.newAdditions(["Kylian Mbappé/23/160", "Lionel Messi/35/50", "Pau Torres/25/52"]));
console.log(fTeam.signContract("Kylian Mbappé/240"));
console.log(fTeam.ageLimit("Kylian Mbappé", 30));
console.log(fTeam.transferWindowResult());


