--Create database KatTV
--drop database KatTV
use KatTV

create table TVkat(
	Numb int primary key not null, 
	Brand nvarchar(30) not null, 
	Name nvarchar(15), 
	Light int , 
	Angle int, 
	ThPatrtDev nvarchar(30), 
	MatrResponce int, 
	ScrExten nvarchar(11), 
	color nvarchar(15), 
	Diagonal int , 
	cost float);
	--create database stand
	--drop database stand

insert into TVkat(numb, brand, Name, Light, Angle, ThPatrtDev, MatrResponce , ScrExten, color, Diagonal, cost) 
Values
(1, 'TvBrand1',  'TV1', 1, 1,'ThPatrtDev1', 1, 'ScrEx1', 'red', 21, 1000),
(2,  'TvBrand2',  'TV2', 2, 2,'ThPatrtDev2', 2, 'ScrEx2', 'red', 22, 2000),
(3,  'TvBrand3',  'TV3', 3, 3,'ThPatrtDev3', 3, 'ScrEx3', 'red', 23, 3000),
(4,  'TvBrand4',  'TV4', 4, 4,'ThPatrtDev4', 4, 'ScrEx4', 'red', 24, 4000),
(5, 'TvBrand5',  'TV5', 5, 5,'ThPatrtDev5', 5, 'ScrEx5', 'red', 25, 5000),
(6, 'TvBrand6',  'TV6', 6, 6,'ThPatrtDev6', 6, 'ScrEx6', 'red', 26, 6000)
select * from TVkat;
--drop table users
create table users(
loginn nvarchar(30) primary key,
pass nvarchar(30) not null,
access int not null,
countOfWrongAut int not null)

insert into users(loginn, pass, access, countOfWrongAut) values 
(1, 123, 1, 0),
(2, 234, 2, 0)
select * from users
