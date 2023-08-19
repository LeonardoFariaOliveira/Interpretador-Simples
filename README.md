# Interpretador-Simples
Compilador feito em C# que converte o codigo fonte em linguagem de programação desejada para codigo assembly.

# ETokenType
Define os tipos de tokens que esse compilador possui, alguns exemplos:
* SUM // Token de soma
* DIV // Token de divisão
* MULT // Token de multiplicação

# Lexer
É o leitor léxico do compilador, serve para analisar o codigo fonte e converte-lo em uma sequencia de tokens, que são unidades significativas da linguagem. Cada token representa um elemento léxico, como palavras chaves, identificadores, números, operadores e simbolos especias

# SymbolTable
A tabela de simbolos serve para gerenciar a tabela de símbolos durante o processo de análise léxica e sintática de um compilador. Ela permite que o compilador mantenha informações sobre variáveis e outros símbolos à medida que eles são encontrados no código-fonte, facilitando a análise subsequente e a geração de código intermediário ou código de máquina

# TableEntry
A tabela de entrada funciona juntamente com a tabela de símbolos para criar uma estrutura que armazena e gerencia informações sobre os símbolos presentes no programa sendo compilado. a TableEntry usada para representar as entradas individuais na tabela de símbolos em um compilador. Cada TableEntry contém informações relevantes sobre um símbolo específico encontrado no código-fonte, como o tipo do símbolo (variável, palavra-chave, número, etc.), o nome do símbolo e, opcionalmente, o valor associado a ele (no caso de números ou constantes).

Na classe TableEntry:
* Possui três propriedades: Type, Name e Value.
* Type é uma propriedade que armazena o tipo do símbolo, usando a enumeração ETokenType que provavelmente é definida em algum lugar no seu código.
* Name é uma propriedade que armazena o nome do símbolo (por exemplo, o nome de uma variável ou palavra-chave).
* Value é uma propriedade que armazena o valor associado ao símbolo, se for aplicável. No caso de variáveis numéricas ou constantes, isso pode representar o valor numérico da variável.































# Instalação
Pré-requisitos: Certifique-se de ter o ambiente .NET Core instalado em sua máquina.

Clonando o Repositório: git clone https://github.com/LeonardoFariaOliveira/Interpretador-Simples
