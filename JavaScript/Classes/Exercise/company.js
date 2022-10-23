class Company {
    constructor() {
        this.departments = {};

    }

    addEmployee(name, salary, position, department) {
        let validator = [name, salary, position, department];
        try {
            validator.forEach(n => {
                if (n.toString().length <= 0) {
                    throw new Error(`${validator} input is invalid!`);
                }
            })
        } catch (error) {
            throw new Error('Invalid input!');
        }

        if (Number(salary) < 0) {
            throw new Error('Invalid input!');
        }

        if (!this.departments.hasOwnProperty(department)) {
            this.departments[department] = [];
        }
        this.departments[department].push({ name, salary, position });
        this.departments[department].avgSalary =
            Number(this.departments[department].reduce((acc, x) => {
                return acc + x.salary
            }, 0)) / this.departments[department].length;
        return `New employee is hired. Name: ${name}. Position: ${position}`;
    }
    bestDepartment() {
        let sortable = [];
        for (let dep of Object.keys(this.departments)) {
            sortable.push([dep, dep.avgSalary]);
        }
        let bestDep = sortable.sort((a, b) => a[1] - b[1])[0][0];
        let result = `Best Department is: ${bestDep}\n` +
            `Average salary: ${this.departments[bestDep].avgSalary.toFixed(2)}\n`;

        let emplList = this.departments[bestDep].sort((a, b) =>
            b.salary - a.salary !== 0 ? b.salary - a.salary :
                a.name.localeCompare(b.name));

        for (const empl of emplList) {
            result += `${empl.name} ${empl.salary} ${empl.position}\n`
        }
        return result.trim();

    }
}

let c = new Company();
// c.addEmployee("Stanimir", 2000, "engineer", undefined);
// c.addEmployee("Stanimir", 2000, "engineer");
// c.addEmployee("", 2000, "engineer", "Construction");
// c.addEmployee("Stanimir", "engineer", "Construction");
// c.addEmployee("Stanimir", undefined, "engineer", "Construction");
// c.addEmployee("Stanimir", 1233, null, "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
