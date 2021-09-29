dotnet new sln -o Devmonk
dotnet new webapi --no-openapi=true -name Devmonk.API
dotnet sln add ./Devmonk.API/Devmonk.API.csproj
	- dotnet add package Microsoft.EntityFrameworkCore
	- dotnet add package Microsoft.EntityFrameworkCore.Design
	- dotnet add package Pomelo.EntityFrameworkCore.MySql
	- dotnet ef dbcontext scaffold "server=my01.winhost.com;user id=devmonk;password=devmonk;database=mysql_17753_devmonk" Pomelo.EntityFrameworkCore.MySql -o Models --data-annotations --force
	
dotnet new xunit -o Devmonk.API.Tests
dotnet sln add ./Devmonk.API.Tests/Devmonk.API.Tests.csproj
code .

add .gitignore 

git init
git add .
git commit -m "first commit"
git branch -M master
git remote add origin https://github.com/saulooliveira/devmonk.git
git push -u origin master


# Como juntar commits
- git rebase --interactive --root
	- wq! para sair
- git push --force


https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test
https://renatogroffe.medium.com/net-5-cobertura-de-testes-com-coverlet-7cbec2f052d9

https://github.com/github/gitignore
https://github.com/github/gitignore/blob/master/VisualStudio.gitignore