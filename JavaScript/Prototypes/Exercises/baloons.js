function solution() {
    class Balloon {
        constructor(color, hasWeight) {
            this.color = color;
            this.hasWeight = hasWeight;
        }
    }
    class PartyBalloon extends Balloon {
        constructor(color, hasWeight, ribbonColor, ribbonLength) {
            super(color, hasWeight);
            this.ribbon = {color:ribbonColor,length:ribbonLength}
        }

        get ribbon(){return this._ribbon};
        set ribbon(value){this._ribbon = value}
    }
    class BirthdayBalloon extends PartyBalloon{
        constructor(color, hasWeight, ribbonColor, ribbonLength, text){
            super(color, hasWeight, ribbonColor, ribbonLength);
            this.text = text;
        }
        get text(){return this._text}
        set text(value){this._text = value}
    }
    return{
        Balloon: Balloon,
        PartyBalloon: PartyBalloon,
        BirthdayBalloon: BirthdayBalloon
    }
}

let classes = solution();
let testBalloon = new classes.Balloon("yellow", 20.5);
let testPartyBalloon = new classes.PartyBalloon("yellow", 20.5, "red", 10.25);
let ribbon = testPartyBalloon.ribbon;
console.log(testBalloon);
console.log(testPartyBalloon);
console.log(ribbon);
