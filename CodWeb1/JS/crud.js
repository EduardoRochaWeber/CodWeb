var categorias = [];

function salvar(){
    let id = parseInt(document.getElementById("id").value);
    let nome = document.getElementById("nome").value;
    let descricao = document.getElementById("descricao").value;
    cat = {"id":id, "nome":nome, "descricao":descricao};
    categorias.push(cat);
    mostraTabela();
}
function mostraTabela(){
    let tabela = document.getElementById("categorias");
    let corpo = tabela.getElementsByTagName("tbody")[0];
    corpo.innerHTML = "";
    categorias.forEach(c => {
        corpo.innerHTML += `<tr><td>${c["id"]}</td><td>${c["nome"]}</td><td>${c["descricao"]}</td></tr>`;
    });
}
window.onload = function(){
    mostraTabela();
}