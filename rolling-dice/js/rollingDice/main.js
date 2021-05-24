// Put your code here
console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const dieRoll = () => {
    for (let i = 0; i < 10; i++) {
        let dieOne = Math.floor((Math.random() * 6) + 1);
        let dieTwo = Math.floor((Math.random() * 6) + 1);
        if (dieOne === dieTwo) {
            console.log(`${dieOne} + ${dieTwo} == ${dieOne + dieTwo} DOUBLES!`)
        }
        else {
            console.log(`${dieOne} + ${dieTwo} == ${dieOne + dieTwo}`)
        };
    }

}

dieRoll();