create database Prokat
use Prokat

drop table if exists users
drop table if exists Vehicle
drop table if exists typeV
drop table if exists Clients
drop table if exists SystemShtraf
drop table if exists Shtrafi
drop table if exists Vidachi

create table users(
id_u int primary key identity,
login nvarchar(20) default 'user',
password nvarchar(15) default '1234')

insert into users values ('user1','1111'),('admin','1234')

create table typeV(
id_tv int primary key identity,
label nvarchar(15) default 'empty')

create table Vehicle(
id_v int primary key identity,
model nvarchar(50) default '?',
year int default '2000',
gosnum nvarchar(10) default '0000 AM-7',
fk_tv int foreign key references typeV(id_tv),
priceOneDay money default 0)


create table Clients(
id_c int primary key identity,
name1 nvarchar(50) default 'name1',
surname nvarchar(50) default 'name2',
otchestvo nvarchar(50) default 'name3',
phone nvarchar(55) default '?',
passport nvarchar(10) default '?',
adress nvarchar(50) default '?')

create table SystemShtraf(
id_s int primary key identity,
name nvarchar(30) default '?',
price money default '0')


create table Vidachi(
id_v int primary key identity,
fk_c int foreign key references Clients(id_c),
fk_v int foreign key references Vehicle(id_v),
dateVidachi date default getdate(),
dateReturn date default getdate(),
price money default 0)

create table Shtrafi(
id_shtraf int primary key identity,
fk_s int foreign key references SystemShtraf(id_s),
fk_v int foreign key references Vidachi(id_v),
date date default getdate())

create or alter trigger Summ on Vidachi after insert, update as
update Vidachi set price = ((select DATEDIFF(day,Vidachi.dateVidachi,Vidachi.dateReturn) from inserted) * (select Vehicle.priceOneDay from Vehicle where id_v = (select fk_v from inserted)))
where id_v = (select id_v from inserted)
select * from Vidachi 

insert into typeV values ('�����'),('���������'),('����'), ('�����������')

insert into Vehicle values  ('Tesla model S','2020','1488 BM-7',1,550),
							('Tesla Model Y','2020','1337 AP-7',1,600),
							('Tesla Model 3','2020','1338 BM-7',1,650),
							('Tesla model X','2020','8888 PM-7',1,580),
							('Mercedes S-Class','2020','1717 KK-7',1,1145),
							('Mercedes Maybach S-Class','2020','7777 MM-7',1,2565),
							('Mercedes AMG GT','2020','8448 GG-7',1,1005),
							('Mercedes AMG G 65','2020','0909 LK-7',4,2110),
							('Mercedes AMG SLC','2020','6565 RR-7',3,955),

							('Lamborghini Aventador S','2021','9999 KK-7',3,3674),
							('Lamborghini Aventador S Roadster','2021','7777 UU-7',3,3888),
							('Lamborghini Aventador SVJ','2021','1111 RR-7',3,3456),
							('Lamborghini Aventador SVJ Roadster','2021','2222 JJ-7',3,3989),
							('Lamborghini Huracan EVO','2021','5555 ll-7',3,3678),
							('Lamborghini Huracan EVO RWD','2021','7878 PP-7',3,3456),
							('Lamborghini Huracan EVO RWD Spyder','2021','9999 II-7',3,4521),
							('Lamborghini Huracan EVO Fluo Capsule','2021','4444 ZZ-7',3,4123),
							('Lamborghini Huracan STO','2021','8888 XX-7',3,3999)





insert into Clients values ('������', '����', '��������', 293366699,'MP3213212','��������� 3'), 
							('������', '����', '��������', 255556987,'MP3423456','�������� 12'), 
							('�������', '�������', '�������������', 333258963,'MP1111111','����������� 12')

insert into SystemShtraf values ('����������',100),('������ �� �������',550),('������������ ��������',350)

insert into Vidachi(fk_c,fk_v,dateVidachi,dateReturn) values (1,1,'2020.06.20',GETDATE())
insert into Vidachi(fk_c,fk_v,dateVidachi,dateReturn) values (3,3,'2020.06.22',GETDATE())
insert into Vidachi(fk_c,fk_v,dateVidachi,dateReturn) values (4,4,'2020.06.18',GETDATE())
select* from Vidachi

create or alter proc ����������
@login nvarchar(20),
@password nvarchar(15)
as
begin
select login, password 
from users
where login=@login and password=@password
end
exec ���������� 'user1','1111'

create or alter proc ������
@������������ int
as(
select SystemShtraf.name,SystemShtraf.price from SystemShtraf
join Shtrafi on Shtrafi.fk_s = SystemShtraf.id_s
where fk_v = @������������)



create or alter proc ������
@������ nvarchar(50),
@dateVidachi date
as(
select Clients.name1, Vehicle.model, Vidachi.dateVidachi, Vidachi.dateReturn, Vidachi.price from Vidachi
join Clients on Clients.id_c = Vidachi.fk_c
join Vehicle on Vehicle.id_v = Vidachi.fk_v
where name1 like '%' + @������ + '%' and dateVidachi = @dateVidachi )
exec ������ '',''

create or alter proc �������
@name1 nvarchar(50),
@surname nvarchar(50),
@otchestvo nvarchar(50),
@phone nvarchar(55),
@passport nvarchar(10),
@adress nvarchar(50)
as(
select Clients.name1, Clients.surname,  Clients.otchestvo,  Clients.phone, Clients.passport, Clients.adress from Clients
where name1 like '%' + @name1 + '%' and 
	  surname like '%' + @surname + '%' and 
	  otchestvo like '%' + @otchestvo + '%' and
	  phone like '%' + @phone + '%' and
	  passport like '%' + @passport + '%' and
	  adress like '%' + @adress + '%')
exec ������� '','','','','',''


create or alter proc ����������
@model nvarchar(30),
@gosnum nvarchar(10),
@type nvarchar(20)
as(
select Vehicle.model, typeV.label, Vehicle.gosnum, Vehicle.year, Vehicle.priceOneDay from Vehicle
join typeV on typeV.id_tv = Vehicle.fk_tv
where model like '%' + @model + '%' and gosnum like '%' + @gosnum + '%' and label like  '%' + @type + '%')
exec ���������� 'Tesla','AP',''

create or alter proc �����������
@login1 nvarchar(20),
@password1 nvarchar(15)
as(
select users.login, users.password from users 
where login like '%' + @login1  + '%' and password like '%' + @password1 + '%')
exec ����������� 'admin',''

create or alter proc �����������
@vidShtrafa nvarchar(30)
as(
select Shtrafi.id_shtraf, SystemShtraf.name, Vidachi.id_v, Shtrafi.date from Shtrafi
join SystemShtraf on Shtrafi.id_shtraf = Shtrafi.id_shtraf
join Vidachi on Vidachi.id_v = Shtrafi.id_shtraf
where SystemShtraf.name like '%' + @vidShtrafa + '%')
exec ����������� '����������'

create or alter proc ���
@prokat int as(
select Clients.surname as '���', Clients.phone as '�������', Clients.passport as '�������', Vehicle.model as '������', Vidachi.dateVidachi as '����������', Vidachi.dateReturn as '������������', Vidachi.price as '�����������������' from Vidachi
join Clients on Clients.id_c = Vidachi.fk_c
join Vehicle on Vehicle.id_v = Vidachi.fk_v
where Vidachi.id_v = @prokat)
exec ��� 1










select * from mysql.proc 
select name from mysql.proc where db='labaa'

create or alter proc labaa
@name1 nvarchar(30)
as( select * from Clients where clients.surname=@name1)
select '��������� �� �����'
exec labaa '������'

select comment from mysql.proc where name='labaa'
select name, comment from mysql.proc where db='labaa'




create or alter proc labaa
(@name1 nvarchar(30))
comment '��������� �� �����'
begin
( select * from Clients where clients.surname=@name1)
exec labaa '������'
end

select comment from mysql.proc where name='labaa'


create or alter view laba2
as( select * from Clients
join Vidachi on Clients.id_c=Vidachi.fk_c
)

create table laba13(
prim1 int,
prim2 int)
insert into laba13 values('14','5'), ('13','2'), ('55','6'), ('23','51'), ('1','76')
select * from laba13

create or alter proc laba3
as (select '��������� ��������')
(select prim1, prim2, prim1+prim2 as 'summ' from laba13)











create or alter proc laba15 ()
begin
if (datename(WEEKDAY, GETDATE()) in (N'Saturday', N'Sunday'))
	select 'Weekend';
else
	select 'Weekday';
end

select getdate()

create or alter proc laba15_2 ()
begin
if (datename(WEEKDAY, getdate()) in (N'�����������')) 
	select 'Today is Monday'
else if (datename(WEEKDAY, getdate()) in (N'�������'))
	select 'Today is Tuesday'
else if (datename(WEEKDAY, getdate()) in (N'�����'))
	select 'Today is Wednesday'
else if (datename(WEEKDAY, getdate()) in (N'�������'))
	select 'Today is Thursday'
else if (datename(WEEKDAY, getdate()) in (N'�������'))
	select 'Today is Friday'
else if (datename(WEEKDAY, getdate()) in (N'�������'))
	select 'Today is Saturday'
else 
	select 'Today is Sunday'
end

create or alter proc laba15_3 ()
begin
if (MONTH(GETDATE()) >=1 and (MONTH(GETDATE()) <= 2) or (MONTH(GETDATE()) = 12))
	select '����(((('
if (MONTH(GETDATE()) >=3 and (MONTH(GETDATE()) <= 5))
	select '�������!!!'
if (MONTH(GETDATE()) >=6 and (MONTH(GETDATE()) <= 8))
	select '������!!!'
if (MONTH(GETDATE()) >=9 and (MONTH(GETDATE()) <= 11))
	select '�����((('
end


create or alter procedure getavgprice
as
declare @avgprice money 
select @avgprice = avg(priceOneDay)
from Vehicle
return @avgprice

declare @result money
exec @result = getavgprice
print @result












select * from Vehicle

create or alter proc laba16()
declare @i int
set @i =0;
while @i<=3 
begin
	select * from Vehicle
	where fk_tv = @i;
	set @i=@i+1;
end 


select * from Vidachi

create or alter proc laba16_2()
declare @y int
set @y =0;
while @y<=4 
begin
	select * from Vidachi
	where fk_c = @y;
	set @y=@y+1;
end 


create table lab16 (s1 date, day nvarchar(50), s2 int, s3 int, s4 int, date2 date, day2 nvarchar(50))
drop table lab16

declare @qq int;
declare @ww int;
declare @date date;
declare @ee int;
declare @aaaa int;
declare @day nvarchar(50);
declare @date2 date;
declare @day2 nvarchar(50);
set @qq = 0;
set @ww = 50;
set @ee = 1001;
set @aaaa = @ww + @ee;
set @day = datename(WEEKDAY, getdate());
set @date2 = GETDATE();
set @day2 = datename(WEEKDAY, getdate());
set @date = GETDATE()
while @qq <= 20 
begin
	insert into lab16 values(@date, @day, @ww, @ee, @aaaa, @date2, @day2)
	set @ww = @ww + 50;
	set @ee = @ee + 101;
	set @aaaa = @ww + @ee;
	set @date2 = DATEADD(YEAR,1,@date2);
	set @day2 = datename(WEEKDAY, @date2);
	set @qq = @qq + 1;
end 

select * from lab16






























create table ������(
id_������ int primary key identity,
�������� nvarchar(50),
���� nvarchar(50),
������ int ,
�������� nvarchar(50),
����������� nvarchar(50))

create table ��������(
id�������� int primary key identity,
������� nvarchar(50),
��� nvarchar(50),
otchestvo nvarchar(50),
������ int,
����� int,
date������ date default getdate())

create table �������(
fk_������ int foreign key references ������(id_������),
date������� date default getdate(),
����������� money,
fk_�������� int foreign key references ��������(id��������),
id������� int primary key identity)




insert into ������ values ('������� ������','��������','1','��','���'),
							('����','����������','5','��','���'),
							('����','������','3','��','���'),
							('���������','��������','6','��','���')

insert into �������� values ('������', '����', '��������', 5,456, getdate()), 
							('������', '����', '��������', 2,222, getdate()), 
							('�������', '�������', '�������������', 1,156, getdate())


insert into ������� values (1, getdate(), 77, 1), 
							(2, getdate(), 33, 2), 
							(3, getdate(), 16, 3)