const form = document.querySelector('form');

form.addEventListener('submit', (event) => {
    event.preventDefault();
    const inputhomens = document.getElementById('inputhomens');
    const inputmulheres = document.getElementById('inputmulheres');
    const inputcriancas = document.getElementById('inputcriancas');

    const outputBovina = document.getElementById('outputBovina'); 
    const outputFrango = document.getElementById('outputFrango'); 
    const outputLinguica = document.getElementById('outputLinguica'); 
    const outputRefrigerante = document.getElementById('outputRefrigerante'); 
    const outputCerveja = document.getElementById('outputCerveja'); 

    const valor_invalido = document.querySelector('#listaOutput');

    const homens = parseInt(inputhomens.value);
    const mulheres = parseInt(inputmulheres.value);
    const criancas = parseInt(inputcriancas.value);


    // Aqui eu envio as informações para o output

    if (isNaN (homens && mulheres && criancas)){
        valor_invalido.innerHTML = "Você precisa digitar apenas números inteiros em todos os campos! Recarregue a página e tente novamente."
    }
    else{
        outputBovina.innerHTML = QtdBovina(homens, mulheres, criancas) + ' KG de carne bovina';
        outputFrango.innerHTML = QtdFrango(homens, mulheres, criancas) + ' KG de carne frango';
        outputLinguica.innerHTML = QtdLinguica(homens, mulheres, criancas) + ' KG de carne linguiça';
        outputRefrigerante.innerHTML = QtdRefrigerante(homens, mulheres, criancas) + ' L de refrigerante';
        outputCerveja.innerHTML = QtdCerveja(homens, mulheres, criancas) + ' L de cerveja';
    }
});

function somar(n1, n2, n3){
    const soma = n1 + n2 + n3;
    return soma;
}

function QtdBovina(n1, n2, n3){
    const qtd_bovina_homens = n1 * 0.5
    const qtd_bovina_mulheres = n2 * 0.3
    const qtd_bovina_criancas = n3 * 0.2
    const total = qtd_bovina_homens + qtd_bovina_mulheres + qtd_bovina_criancas
    
    return total.toFixed(1);
}

function QtdFrango(n1, n2, n3){
    const qtd_frango_homens = n1 * 0.2
    const qtd_frango_mulheres = n2 * 0.2
    const qtd_frango_criancas = n3 * 0.1
    const total = qtd_frango_homens + qtd_frango_mulheres + qtd_frango_criancas

    return total.toFixed(1);
}

function QtdLinguica(n1, n2, n3){
    const qtd_linguica_homens = n1 * 0.2
    const qtd_linguica_mulheres = n2 * 0.2
    const qtd_linguica_criancas = n3 * 0.2
    const total = qtd_linguica_homens + qtd_linguica_mulheres + qtd_linguica_criancas

    return total.toFixed(1);
}

function QtdRefrigerante(n1, n2, n3){
    const qtd_refrigerante_homens = n1 * 0.3
    const qtd_refrigerante_mulheres = n2 * 0.4
    const qtd_refrigerante_criancas = n3 * 0.2
    const total = qtd_refrigerante_homens + qtd_refrigerante_mulheres + qtd_refrigerante_criancas

    return total.toFixed(1);
}

function QtdCerveja(n1, n2, n3){
    const qtd_cerveja_homens = n1 * 0.8
    const qtd_cerveja_mulheres = n2 * 0.5
    const qtd_cerveja_criancas = n3 * 0
    const total = qtd_cerveja_homens + qtd_cerveja_mulheres + qtd_cerveja_criancas

    return total.toFixed(1);
}