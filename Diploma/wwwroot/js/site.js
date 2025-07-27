
document.addEventListener('DOMContentLoaded', function () {

    switch (window.location.pathname) {
        case "/Add/Point":
            fillSelect('SelectedContractId', 'SelectedAbonentId', '/Add/LoadSecondListPoint?SelectedContractId='); break;
        case "/Add/MountMeter":
            fillSelect('Type', 'SelectedMeterId', '/Add/LoadSecondListMeter?Type='); break;
        case "/Arhive/ToArhive":
            hideLists(); break;
        case "/Arhive/FromArhive":
            hideLists(); break;
        case "/Delete/Delete":
            hideLists(); break;
    }
   
});

function fillSelect(firstlistID, secondlistID, url) {
    const firstList = document.getElementById(firstlistID);
    const secondList = document.getElementById(secondlistID);
    firstList.addEventListener('change', async function () {
        const selectedValue = this.value.toString();
        secondList.innerHTML = '';
        const defaultOption = document.createElement('option');
        defaultOption.value = '';
        defaultOption.textContent = 'Выберите значение';
        secondList.appendChild(defaultOption);

        if (selectedValue) {
            try {
                const response = await fetch(`${url}${encodeURIComponent(selectedValue)}`);
                const data = await response.json();

                data.forEach(item => {
                    const option = document.createElement('option');
                    option.value = item.value;
                    option.textContent = item.text;
                    secondList.appendChild(option);
                });
            } catch (error) {
                console.error('Ошибка:', error);
            }
        }
    });
}

function hideLists() {
    let lists = document.querySelectorAll(".hide")
    lists.forEach(el => {
        el.style.display = 'none'
    })
}
document.getElementById('object-list')?.addEventListener('change', function () {
    const selectedValue = this.value;
    const list = document.querySelectorAll('.hide')
    list.forEach(el => {
        if (selectedValue === el.id && selectedValue === 'nomabn') {
            el.style.display = 'flex'
            document.getElementById('nomdog').style.display = 'flex'
            switch (window.location.pathname) {
                case "/Arhive/ToArhive":
                    fillSelect('SelectedContractId', 'SelectedAbonentId', '/Arhive/LoadSecondListOpenedAbonents?SelectedContractId=');
                    break;
                case "/Arhive/FromArhive":
                    fillSelect('SelectedContractId', 'SelectedAbonentId', '/Arhive/LoadSecondListOpenedAbonents?SelectedContractId=');
                    break;
                case "/Delete/Delete":
                    fillSelect('SelectedContractId', 'SelectedAbonentId', '/Delete/LoadSecondListDeleteAbonents?SelectedContractId=');
                    break;
            }
        }
        else if (selectedValue === el.id && selectedValue !== 'nomabn') {
            el.style.display = 'flex'
        }
        else  {
            el.style.display = 'none'
        }
    })
});