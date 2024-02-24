create database S4E_Desafio
GO

USE [S4E_Desafio]
GO

create table Tarefa ( 
id int not null identity(1,1) primary key,
descricao  nvarchar(255) not null,
dataInicio date not null
)
GO


create table Etapa(
id int primary key identity(1,1) not null,
descricao nvarchar(255) not null,
dataInicio date not null,
dataConclusao date ,
idTarefa int not null foreign key references Tarefa(id) 
)
GO

create table Usuario (
id int primary key identity(1,1) not null,
nome nvarchar(255) not null

)
GO

create table TarefaUsuario(
idUsuario int not null foreign key references Usuario(id),
idTarefa int not null foreign key references Tarefa(id)
)