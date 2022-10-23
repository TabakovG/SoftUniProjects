function solve() {
    class Contact {
        constructor(firstName, lastName, phone, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this._online = false;
        }
        get online() { return this._online }
        set online(value) {
            if (value) {
                this._online = value;
                let name = `${this.firstName} ${this.lastName}`;
                let box = Array.from(document.querySelectorAll(".title"))
                    .filter(a => a.textContent.includes(name))[0];
                if (box !== undefined) {
                    box.classList.add('online');
                }
            }
            else {
                this._online = value;
                let name = `${this.firstName} ${this.lastName}`;
                let box = Array.from(document.querySelectorAll(".title"))
                    .filter(a => a.textContent.includes(name))[0];
                if (box !== undefined) {
                    box.classList.remove('online');
                }
            }
        }

        render(containerId) {
            let article = document.createElement('article');
            let title = document.createElement('div');
            let button = document.createElement('button');
            let info = document.createElement('info');
            let sp1 = document.createElement('span');
            let sp2 = document.createElement('span');

            title.classList.add('title');
            title.textContent = `${this.firstName} ${this.lastName}`;
            if (this.online) {
                title.classList.add('online');
            }
            button.innerHTML = `&#8505;`;
            info.classList.add('info');
            info.style.display = 'none';
            sp1.innerHTML = `&phone;` + ` ${this.phone}`;
            sp2.innerHTML = `&#9993; ${this.email}`;

            info.appendChild(sp1);
            info.appendChild(sp2);

            title.appendChild(button);
            article.appendChild(title);
            article.appendChild(info);

            button.addEventListener('click', (e) => {
                info.style.display = info.style.display === 'block' ? 'none' : 'block';
            })

            let target = document.getElementById(containerId);
            target.appendChild(article);
        }
    }

    let contacts = [
        new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
        new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
        new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
    ];
    contacts[2].online = true;
    contacts.forEach(c => c.render('main'));

    // After 1 second, change the online status to true
    setTimeout(() => contacts[1].online = true, 2000);
}