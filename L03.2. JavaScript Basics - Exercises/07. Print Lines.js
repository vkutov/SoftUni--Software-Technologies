function printLines(arr) {

    for (element of arr) {

        if (element === 'Stop') {
            break;
        }

        console.log(element);
    }
}

printLines(['3', '6', '5', '4', 'Stop', '10', '12']);