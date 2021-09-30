[![Demonk](https://github.com/saulooliveira/devmonk/actions/workflows/demonk.yml/badge.svg)](https://github.com/saulooliveira/devmonk/actions/workflows/demonk.yml)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=saulooliveira_devmonk&metric=coverage)](https://sonarcloud.io/dashboard?id=saulooliveira_devmonk)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=saulooliveira_devmonk&metric=bugs)](https://sonarcloud.io/dashboard?id=saulooliveira_devmonk)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=saulooliveira_devmonk&metric=code_smells)](https://sonarcloud.io/dashboard?id=saulooliveira_devmonk)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=saulooliveira_devmonk&metric=security_rating)](https://sonarcloud.io/dashboard?id=saulooliveira_devmonk)


# How to start

```bash=
git clone https://github.com/saulooliveira/devmonk.git
dotnet restore
cd Devmonk.API
dotnet run
```




dotnet tool install --global dotnet-sonarscanner

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

# Como subir branchs
- git push origin develop


https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test
https://renatogroffe.medium.com/net-5-cobertura-de-testes-com-coverlet-7cbec2f052d9
https://www.seeleycoder.com/blog/sonarqube-with-github-actions-and-net-core-5-x/?ref=morioh.com&utm_source=morioh.com
https://sonarcloud.io/projects

https://github.com/github/gitignore
https://github.com/github/gitignore/blob/master/VisualStudio.gitignore
