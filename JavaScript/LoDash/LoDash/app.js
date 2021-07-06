const _ = {

    // Clamp number to the closest number between lower and upper
    // If number is between lower and upper provided, number stays the same
    clamp(number, lower, upper)
    {
        const lowerClampedValue = Math.max(number, lower);
        const clampedValue = Math.min(lowerClampedValue, upper);
        return clampedValue;
    },

    // Returns true if number is between start and end and false if not
    inRange(number, start, end)
    {
        if (end === undefined)
        {
            end = start;
            start = 0;
        }
        if (start > end)
        {
            [start, end] = [end, start];
        }
        if (number < start || number >= end)
        {
            return false;
        }
        else
        {
            return true;
        }
    },

    // Returns array of all words in a provided string
    words(str)
    {
        const words = str.replace(/[^A-Za-z0-9 ]/g, '');
        return words.split(' ');
    },

    // Adds padding to start and end of input if input.length is less than inputLen
    pad(input, inputLen)
    {
        if (input.length >= inputLen)
        {
            return input;
        }
        else
        {
            const padStart = Math.floor((inputLen - input.length) / 2);
            const padEnd = Math.ceil((inputLen - input.length) / 2);
            const padding = ' ';
            const addPadStart = padding.repeat(padStart);
            const addPadEnd = padding.repeat(padEnd);
            return addPadStart + input + addPadEnd;
        };
    },

    // Check if object contains the key specified
    has(object, key)
    {
        const hasValue = object[key] ? true : false;
        return hasValue;
    },

    // Swaps all keys with their values in provided object
    invert(object)
    {
        const newObject = {};
        Object.keys(object).forEach(key => { newObject[object[key]] = key; });
        return newObject;
    },

    // Checks which key in the object provided contains a value where the predicate returns truthy first
    // NB, predicate was provided by codecademy for testing
    findKey(object, predicate)
    {
        let predicateReturnValue;
        Object.keys(object).forEach(key =>
        {
            predicate(object[key]) ? predicateReturnValue = key : predicateReturnValue = undefined
        });
        return predicateReturnValue;
    },

    // Removes specified amount from start of array and returns new array
    drop(array, amount)
    {
        if (amount === undefined)
        {
            amount = 1;
        }
        return array.slice(amount, (array.length + 1));
    },

    // Removes start element from array until predicate function returns falsy and return remaining elements not dropped
    dropWhile(array, predicate)
    {
        for (predicate in array)
        {
            array.shift();
        }
        return array;
    },

    // Splits array into new arrays containing amount of elements specified. If array is uneven, adds remainder elements in the last array.
    chunk(array, size)
    {
        if (size === undefined)
        {
            size === 1;
        }
        const arrayBeforeRemainder = array.length - (array.length % size)
        let newArray = []
        for (let i = 0; i < arrayBeforeRemainder; i += size) {
            newArray.push(array.slice(i, (i + size)));
        }
        if ((array.length % size) != 0) {
            newArray.push(array.slice(arrayBeforeRemainder, array.length));
        }
        return newArray;
    },

};



// Do not write or modify code below this line.
module.exports = _;