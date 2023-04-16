function get(url){
    let request = new XMLHttpRequest()
    request.open("GET", url, false)
    request.send()
    return request.responseText
}

function post(){

}

function put(){
    linha = document.createElement("tr")
    tdId = document.createElement("td")
    tdNome = document.createElement("td")

    tdId.innerHTML = users.email 
    tdNome.innerHTML = users.nome 

    linha.appendChild(tdId)
    linha.appendChild(tdNome)

    return linha
}

function del(){

}

function main(){
    let data = get("http://localhost:5148")
    let users = JSON.parse(data)
    let table = document.getElementById("res")
    users.forEach(element => {
        let linha = criaLinha(element)
        table.appendChild(linha)
    });
}
main()