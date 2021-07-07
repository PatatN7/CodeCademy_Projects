// Returns a random DNA base
const returnRandBase = () => {
    const dnaBases = ['A', 'T', 'C', 'G'];
    return dnaBases[Math.floor(Math.random() * 4)];
};

// Returns a random single stand of DNA containing 15 bases
const mockUpStrand = () => {
    const newStrand = [];
    for (let i = 0; i < 15; i++) {
        newStrand.push(returnRandBase());
    }
    return newStrand;
};

// Stores list of organism numbers to prevent duplicates
const organismList = [];

//Create a new organism with organism number and DNA strand
const pAequorFactory = (organismNum, dna) => {

    // Adds organism number to organism list
    if (organismList.includes(organismNum)) {
        console.log('Organism number already in use');
        return 'Organism number already in use';
    }
    else {
        organismList.push(organismNum);
    }

    // Return object
    return {
        organismNum,
        dna,

        // Mutates one random DNA base and return mutated DNA strand
        mutate() {
            const randBase = Math.floor(Math.random() * 15);
            const currentBase = this.dna[randBase];
            let mutatedBase = returnRandBase();
            while (currentBase === mutatedBase) {
                mutatedBase = returnRandBase();
            }
            this.dna[randBase] = mutatedBase;
            return this.dna;
        },

        // Checks percentage of DNA is same with provided specimen
        compareDNA(pAequor) {
            let count = 0;
            for (let i = 0; i < this.dna.length; i++) {
                if (this.dna[i] === pAequor.dna[i]) {
                    count++;
                }
            }
            const percent = (count / this.dna.length) * 100;
            console.log(`Specimen ${this.organismNum} and specimen ${pAequor.organismNum} have ${percent.toFixed(2)}% DNA in common.`);
        },

        // Checks if specimen will survive
        willLikelySurvive() {
            let baseCount = 0;
            for (let i = 0; i < this.dna.length; i++) {
                if (this.dna[i] === 'C' || this.dna[i] === 'G') {
                    baseCount++;
                }
            }
            return ((baseCount / this.dna.length) * 100 >= 60) ? true : false;
        },
    }
}




// ------------------
// Test section below
// ------------------


/*
// Stores specimen that will survive
const pAequor = [];

// Only create specimen that will survive
for (let i = 0; i < 30; i++) {
    let mockSpecimen = mockUpStrand();
    let newSpecimen = pAequorFactory(i, mockSpecimen);
    let survivalCheck = newSpecimen.willLikelySurvive();
    while (!survivalCheck) {
        organismList.pop();
        mockSpecimen = mockUpStrand();
        newSpecimen = pAequorFactory(i, mockSpecimen);
        survivalCheck = newSpecimen.willLikelySurvive();
    }
    pAequor.push(newSpecimen);
}

// Stores randomly created specimen
const randSpecimen = [];

// Create random specimen
for (let i = 30; i < 60; i++) {
    randSpecimen.push(pAequorFactory(i, mockUpStrand()));
}

/*
pAequor.forEach(specimen => {
    console.log('Specimen survive? : ' + specimen.willLikelySurvive());
});
*/

/*
randSpecimen.forEach(specimen => {
    console.log('Specimen survive? : ' + specimen.willLikelySurvive());
});
*/

//const mock1 = mockUpStrand();
//const mock2 = mockUpStrand();

//const mock3 = pAequorFactory(103, mockUpStrand());
//const mock4 = pAequorFactory(104, mockUpStrand());
//console.log(mock3.dna);
//console.log(mock4.dna);
//console.log(mock3.willLikelySurvive());
//console.log(mock4.willLikelySurvive());

//const mutateTest = pAequorFactory(100, mock1);
//console.log(mutateTest);
//console.log(mutateTest.mutate());

//mock3.compareDNA(mock104);

//console.log(mock103.willLikelySurvive());
