function saveMessage(firstName, lastName) {
    // alert(firstName + ' ' + lastName+' ' +'Record has beend saved successfully!');
    document.getElementById('divServerValidation').innerText = firstName + ' ' + lastName + ' ' + 'Record has beend saved successfully!';
}

function getCities() {
    var cities = ['Braila', 'Galati', 'Tulcea', 'Constanta'];
    return cities;
}