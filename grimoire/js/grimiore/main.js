// Put your code here
console.log("Do you believe in magic?");
console.log("------------------------");

const allSpells = [
    {
        name: "Turn enemy into a newt",
        isEvil: true,
        energyReqired: 5.1
    },
    {
        name: "Conjure some gold for a local charity",
        isEvil: false,
        energyReqired: 2.99
    },
    {
        name: "Give a deaf person the ability to heal",
        isEvil: false,
        energyReqired: 12.2
    },
    {
        name: "Make yourself emperor of the universe",
        isEvil: true,
        energyReqired: 100.0
    },
    {
        name: "Convince your relatives your political views are correct",
        isEvil: false,
        energyReqired: 2921.5
    }
]

const getGoodBooks = () => {

    for (let spells of allSpells) {
        if (spells.isEvil === false) {

            console.log(`${spells.name}`)
        }

    };
}

const getEvilBooks = () => {
    for (let spells of allSpells) {
        if (spells.isEvil === true) {
            console.log(`${spells.name}`)
        }
    }
}
console.log(`Good Book`)
getGoodBooks();
console.log(`Evil Book`)
getEvilBooks();