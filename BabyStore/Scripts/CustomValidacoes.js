// Adicionamos o método ranger para sobrepor o método original e corrigir os valores passados,
// retirando o ponto milhar e trocando a virgula decimal por ponto decimal, 
// Com isto solucionamos os conflitos ao tentar definir um range para um valor quando utilizamos o atributo NumeroBrasil 
$.validator.addMethod('range',
    function (value, element, params) {

        // Coleta os parametros passados, valor maximo e minimo
        var min = params[0];
        var max = params[1];

        // Retira todo ponto de milhar formatado no campo valor
        var pos = value.indexOf('.');
        while (pos > -1) {
            value = value.replace('.', '');
            pos = value.indexOf('.');
        }

        // Troca virgula decimal por ponto decimal
        value = value.replace(',', '.');

        // Faz a validacao do valor, comparando com o valor minimo e maximo
        if (value < min) {
            return false;
        }

        if (value > max) {
            return false;
        }

        return true;
    });