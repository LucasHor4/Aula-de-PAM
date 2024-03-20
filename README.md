<h3>Integrantes: João Attila, Lucas Hora e Thiago</h3>

<h1>Relatório</h1>

<H2>Pegamos um projeto já existente, colocamos no github e dentro do proprio github modificamos o memso, puxamos o projeto do github para o computador e adicionamos um novo commit e recolocamos no github</H2>

⦁	Clique com botão direito na pasta do seu projeto e logo em seguida em "Open git bash here".
 ![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/eeb51b86-9e7b-42de-ba6a-a80abfbc8d97)
 
⦁	Após abrir o git bash, digite o comando "git init". Ele ira iniciar os arquivos essenciais do git na pasta local, para visualizar a pasta dos arquivos do git, vá no seu gerenciador de arquivos em exibir -> Mostrar/Ocultar -> exibir itens ocultos e você verá um arquivo chamado ".git" (recomendo não mexer nisso).
![image](https://private-user-images.githubusercontent.com/150953092/314195913-2fece3e4-d276-4158-8286-ccb870dc0396.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MTA5MzU3MTQsIm5iZiI6MTcxMDkzNTQxNCwicGF0aCI6Ii8xNTA5NTMwOTIvMzE0MTk1OTEzLTJmZWNlM2U0LWQyNzYtNDE1OC04Mjg2LWNjYjg3MGRjMDM5Ni5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjQwMzIwJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI0MDMyMFQxMTUwMTRaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT05MzZiNDc4YjA2M2Q0OGI3OTRhMWY4M2M2YjMwOGRiMzA1ZmQ2MTRkNGQ5MzA2YmQyNmFmNmM0MWU3ZTJlMWY0JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.QY1taLy5jMkMTAwanHYVaUN-6IC0VA4I7ZL4EcdCPuQ)
 
⦁	Em seguida use o comando "git config - -global user.name “(Digite seu nome)”  " e em seguida o "git config - -global user.email (digite o email que foi usado para criar a conta do GitHub). Esse comando conecta sua conta do github ao git bash do projeto local.
 ![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/fba1d23e-3936-4711-90a8-18ba2d0324c8)

⦁	Digite " git status ", esse comando serve para verificar se os arquivos do seu projeto estão conectados/salvos. Os arquivos vermelhos são os que não estão conectados e os verdes os que estão. Para salvar os arquivos digite o comando " git add . " , ele vai adicionar todos os arquivos que não estão conectados ao seu gitbash(note que eles ficaram verdes).
 ![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/e5271769-6240-4617-8fa1-0156ba065585)
 
⦁	Em seguida use o comando "git commit -m "(Aqui vai o que você quer escrever)" " ,  serve como um lembrete para o que seus últimos passos fizeram .
 ![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/505a375d-eec8-4eb3-816d-d82e5a93abb3)
 
⦁	Para visualizar seus commit's use o comando "git log", além de exibir os commit's ele exibe nome, data, dono do projeto/criador do projeto com seu nome de usuario e email.
⦁	No github em sua conta , vá ao canto superior da esquerda e clique no simbolo de + e depois em " New repository " , onde depois de dar um nome e descrição(opcional) ao repositório , você irá apertar em "Create repository".
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/98c74f7e-f770-4a37-a0d4-c614db4c1a36)
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/67b8dc06-84ed-4a92-942c-c56cc6018f06)

⦁	Logo em seguida você será redirecionado para essa tela , onde você ira copiar as três linhas de comando separadamente, e irá copia-las no gitbash. Depois disso o seu repositório vai ter recebido os arquivos do seu projeto .
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/d93a3ee4-d15b-4b34-a15d-f4645aad76c3)
	 
⦁	Entre em seu repositório e clique em "Add file" e depois em "Create new file".
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/b8ce07d3-61bc-456e-87eb-ab34e0da65a8)
  
⦁	Aqui você pode criar uma nova pasta dentro do github.
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/b87a3486-4e77-4c2d-84be-9d66b288d3de)
 
⦁	Clique em "<Code>" e copie o link de HTTPS.
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/bd7dfed7-0a74-4d7c-bb92-3e5b386c3f72) 

⦁	Caso você esteja em outro computador , crie uma nova pasta e use o gitbash nela, após isso use o comando "git clone (Link que copiou do github)", isso vai permitir que você altere uma copia do projeto.
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/d999e413-37c5-49ac-9909-4008c298e945)
	 
⦁	Para colocar o projeto alterado no github use o comando " git push ".
![image](https://github.com/LucasHor4/Aula-de-PAM/assets/150953092/b9b3577f-b09d-4833-9fab-5a1cb1ef15e9)
