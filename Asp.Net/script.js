var tbody = document.querySelector('table tbody');
var aluno = {};


function Cadastrar(){
    tbody.innerHTML = '';
    
    aluno.nome = document.querySelector('#nome').value;
    aluno.sobrenome = document.querySelector('#sobrenome').value;          
    aluno.telefone = document.querySelector('#telefone').value;
    aluno.ra = document.querySelector('#ra').value;
    
    
    if(aluno.id === undefined || aluno.id === 0){
        salvarEstudante('POST', 0, aluno);
    }
    else{
        salvarEstudante('PUT', aluno.id, aluno);
    }
    
    carregarEstudante();
}




function Cancelar() {
    var btnSalvar = document.querySelector("#btnSalvar");
    var btnCancelar = document.querySelector("#btnCancelar");
    var titulo = document.querySelector("#titulo");
    
    btnSalvar.textContent = 'Cadastrar';
    btnCancelar.textContent = 'Limpar';
    titulo.textContent = 'Cadastrar Aluno';
    
    aluno = {};
    document.querySelector('#nome').value = '';
    document.querySelector('#sobrenome').value = '';           
    document.querySelector('#telefone').value = '';
    document.querySelector('#ra').value = '';
}

function carregarEstudante(){
    tbody.innerHTML = '';
    var xhr = new XMLHttpRequest();
    
    xhr.open("GET", `http://localhost:58548/api/aluno/` , true);
    
    xhr.onload = function(){
        var estudante = JSON.parse(this.responseText);
        for(var indice in estudante){
            adicionaLinha(estudante[indice]);
        }
    }
    
    xhr.send();
}

function salvarEstudante(metodo, id, corpo){
    var xhr = new XMLHttpRequest();
    
    if(id === undefined) id = '';
    
    
    //esperando ser recebido e retornado
    xhr.open(metodo, `http://localhost:58548/api/aluno/${id}` , false);
    
    xhr.setRequestHeader('content-type', 'application/json');
    xhr.send(JSON.stringify(corpo));
}


function deletarEstudante(id){
    var xhr = new XMLHttpRequest();
    
    //esperando ser recebido e retornado
    xhr.open('DELETE', `http://localhost:58548/api/aluno/${id}` , false);
    
    
    xhr.send();                
}


function deletar(id){
    deletarEstudante(id);
    carregarEstudante();
}


carregarEstudante();

function editarEstudante(estudante){
    var btnSalvar = document.querySelector("#btnSalvar");
    var btnCancelar = document.querySelector("#btnCancelar");
    var titulo = document.querySelector("#titulo");
    
    btnSalvar.textContent = 'Salvar';
    btnCancelar.textContent = 'Cancelar';
    titulo.textContent = `Editar Aluno ${estudante.nome}`;
    
    document.querySelector('#nome').value = estudante.nome
    document.querySelector('#sobrenome').value = estudante.sobrenome;           
    document.querySelector('#telefone').value = estudante.telefone
    document.querySelector('#ra').value = estudante.ra;
    
    aluno = estudante;
}



function adicionaLinha(estudante){
    var trow = `
    <tr>
    <td>${estudante.nome}</td>
    <td>${estudante.sobrenome}</td>
    <td>${estudante.telefone}</td>
    <td>${estudante.ra}</td>
    <td><button class="btn btn-info" data-toggle="modal" data-target="#exampleModal" onclick='editarEstudante(${JSON.stringify(estudante)})'>Editar</button>
    <button  class="btn btn-danger" onclick='deletar(${estudante.id})'>Deletar</button></td>
    </tr>
    
    `
    tbody.innerHTML += trow;
}