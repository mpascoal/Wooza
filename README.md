# Wooza
API de Avaliação de conhecimento para Desenvolvedor da Wooza

Essa api simples demonstra a estrutura organizacional DDD.
Foram utilizados:
 - .Net Framework Core 
 - EntityFramework Core
 - FluentValidator
 - xUnit (Testes)
 
 A árvore da aplicação ficou da seguinte forma:
 
 Wooza (master)
    |
    1 - Application
    2 - Domain
    3 - Service
    4 - Infra
        |
        4.1 - Data
        4.2 - CrossCutting
    5 - Teste
 
 No context da aplicação, utilizei o driver MySql por questão de praticidade.
 As configuração estão injetadas no proprio código para facilitar o teste do avaliador.
 
    optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");

#Container
 
Foram adcionados os arquivos de configuração e geração de imagem do container Docker.
Ainda seria possível a utilização do cloud Azure-container caso optante pelo cliente interno.

O fato de usarmos .net core nos dá flexibilidade de trabalhar com qualquer sistema operacionar e qualquer container Manager.
