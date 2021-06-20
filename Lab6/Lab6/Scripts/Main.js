function OnClick(event) {
    event.currentTarget.formAction += document.querySelector('input[name="NoteId"]:checked').value;
}

function UpdateButtonState() {
    var updateButton = document.querySelector('[name="updateButton"]');
    var deleteButton = document.querySelector('[name="deleteButton"]');
    var selectedRadioButton = document.querySelector('input[name="NoteId"]:checked');
    updateButton.disabled = selectedRadioButton == null;
    deleteButton.disabled = selectedRadioButton == null;
}