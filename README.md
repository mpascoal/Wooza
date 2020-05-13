# Wooza
API de Avaliação de conhecimento para Desenvolvedor da Wooza

Essa api simples demonstra a estrutura organizacional DDD.
Foram utilizados:
 - .Net Framework Core 
 - EntityFramework Core
 - xUnit (Testes)
 
 No context da aplicação, utilizei o driver MySql por questão de praticidade.
 As configuração estão injetadas no proprio código para facilitar o teste do avaliador.
 
    optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
 
 
