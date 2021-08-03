var animes = [];

window.onload = function(){
    CarregarHome();
    mostraStorage();
}

function CarregarHome(){
    let xhr = new XMLHttpRequest();
    xhr.open('GET','home.html');
    xhr.send();
    xhr.onload = function(){
        console.log(this.responseText);
        document.getElementById("guia-main").innerHTML = this.responseText;
    }
}

function CarregarCadastro(){
    let xhr = new XMLHttpRequest();
    xhr.open('GET','cadastro.html');
    xhr.send();
    xhr.onload = function(){
        document.getElementById("guia-main").innerHTML = this.responseText;
    }
}

function CarregarLista(){
    let xhr = new XMLHttpRequest();
    xhr.open('GET','lista.html');
    xhr.send();
    xhr.onload = function(){
        document.getElementById("guia-main").innerHTML = this.responseText;
        mostraTabela();
    }

}

function mostraTabela(){
    let corpo = document.getElementsByTagName("tbody")[0];
    corpo.innerHTML = "";
    animes.forEach(a => {
        corpo.innerHTML += `<tr><td>${a["id"]}</td><td>${a["nome"]}</td><td>${a["genero"]}</td><td>${a["qtTp"]}</td><td>${a["qtEp"]}</td><td class="opcoes"><a class="deletar" onclick="deletar(${a.id})">Deletar</a></td></tr>`;
    });
}

function salvar(){
    console.log("chamando salvar");
    let id = parseInt(document.getElementById("id").value);
    let nome = document.getElementById("nome").value;
    let genero = document.getElementById("genero").value;
    let qtTp = parseInt(document.getElementById("qtTp").value);
    let qtEp = parseInt(document.getElementById("qtEp").value);
    listaAnime = {"id":id, "nome":nome, "genero":genero, "qtTp":qtTp, "qtEp":qtEp};
    animes.push(listaAnime);
    localStorage.setItem("animes", JSON.stringify(animes));
    mostraStorage();
    console.log(listaAnime);
    console.log(animes);

}

function mostraStorage(){
    let animeJson = localStorage.getItem("animes");
    if(animeJson != null){
        animes = JSON.parse(animeJson);
    }
}

function deletar(id){
    animes.splice(animes.findIndex(a => a.id == id), 1);
    localStorage.setItem('animes', JSON.stringify(animes));
    mostraTabela();
}