# WebApiSoftplan

As três requisições foram criadas conforme pede o teste, são elas: 
Pode ignorar a porta abaixo, foi a que usei para testar. 
- localhost:5001/taxaJuros
- localhost:5001/showmethecode
- localhost:5001/calculaJuros/valorInicial/meses

# Swagger 

- Para testar as urls via swagger basta rodar o projeto e navegar para "localhost:5001/swagger/index.html"; 

# TestesUnitarios

- Os testes estão na pasta "ApiSoftplanTest", fiz apenas 3 garantindo que as informações serão retornadas de forma correta.

# Docker

- Para baixar a imagem basta utilizar docker pull marcosmoski/webapisoftplan:latest
- O arquivo "Dockerfile" é o que foi usado para gerar a imagem, no arquivo ela foi gerada com a porta 5001.
