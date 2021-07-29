var categorias = [];

function salvar(){
    let id = parseInt(document.getElementById("id").value);
    let nome = document.getElementById("nome").value;
    let descricao = document.getElementById("descricao").value;
    cat = {"id":id, "nome":nome, "descricao":descricao};
    categorias.push(cat);
    localStorage.setItem("categorias", JSON.stringify(categorias));
    mostraStorage();
}
function mostraTabela(){
    let tabela = document.getElementById("categorias");
    let corpo = tabela.getElementsByTagName("tbody")[0];
    corpo.innerHTML = "";
    categorias.forEach(c => {
        corpo.innerHTML += `<tr><td>${c["id"]}</td><td>${c["nome"]}</td><td>${c["descricao"]}</td></tr>`;
    });
}
function mostraStorage(){
    categorias = JSON.parse(localStorage.getItem("categorias"));
}
window.onload = function(){
    mostraStorage();
    mostraTabela();
}
/*function deletar(id){
    let deletar = 
    categorias = JSON.parse(localStorage.getItem("categorias"));
    mostraTabela();
}
function editar(id){
    let editar = categorias.find("id");
    categorias[0].id = 
}*/