window.onload = function () {
    console.log("loaded")

    //llenar personas
    var sel1 = document.getElementById("persona");

    for (var i = 0; i < personas.length; i++) {
        var opt = personas[i].Nombre;
        var el = document.createElement("option");
        el.textContent = opt;
        el.value = opt;
        sel1.appendChild(el);
    }

    //check personas
    var parentElement = document.getElementById('checkPersonas');

    for (var count in personas) {
        var newCheckBox = document.createElement('input');
        newCheckBox.type = 'checkbox';
        newCheckBox.id = 'persona' + count; // need unique Ids!
        newCheckBox.value = personas[count].Nombre;
        parentElement.appendChild(newCheckBox);

        var p = document.createElement('span');
        p.innerText = personas[count].Nombre;
        parentElement.appendChild(p);
    }
    

    //lenar proyectos   
    var sel2 = document.getElementById("proyecto");

    for (var i = 0; i < proyectos.length; i++) {
        var opt = proyectos[i].Nombre;
        var el = document.createElement("option");
        el.textContent = opt;
        el.value = opt;
        sel2.appendChild(el);
    }
}

var personas = [
    { Nombre: "Juan A", Email: "mail@servidor.com" },
    { Nombre: "Juan B", Email: "mail@servidor.com" },
    { Nombre: "Juan 1", Email: "mail@servidor.com" },
    { Nombre: "Juan 2", Email: "mail@servidor.com" },
    { Nombre: "Juan 3", Email: "mail@servidor.com" },
    { Nombre: "Juan 4", Email: "mail@servidor.com" },
    { Nombre: "Juan 5", Email: "mail@servidor.com" }
]

var proyectos = [
    { Nombre: "Proyecto1", Codigo: "PMX1" },
    { Nombre: "Proyecto2", Codigo: "PMX2" }
]