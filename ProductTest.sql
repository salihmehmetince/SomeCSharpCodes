
/*create table TblCategory(
	Id int not null identity(1,1),
	cName nvarchar(40) not null,
	constraint PK_CId primary key (Id),
	constraint CK_CName check(len(cName)>2),

);


create table TblProduct(
	Id int not null identity(1,1),
	pName nvarchar(40) not null,
	stock int not null,
	buyingPrice decimal(7,2) not null,
	sellingPrice decimal(7,2) not null,
	category int not null
	constraint PK_PId primary key (Id),
	constraint CK_PName check(len(pName)>2),
	constraint CK_PStock check(stock>0),
	constraint CK_PBuyingPrice check(buyingPrice>0),
	constraint CK_PSellingPrice check(sellingPrice>0),
	constraint FK_PCategory foreign key(category) references TblCategory(Id)

);*/
--insert into TblCategory values('Electornics');
--insert into TblCategory values('Home Entertainment Systems');

/*insert into TblProduct values('fýrýn',20,1200,1500,1);
insert into TblProduct values('buz dolabý',30,1100,1200,1);
insert into TblProduct values('Laptop',10,13200,15000,2);
insert into TblProduct values('Blender',14,200,500,3);*/

/*create table AdminTable(
	Id int not null identity(1,1),
	aName nvarchar(40) not null,
	aPassword nvarchar(40) not null
	constraint PK_AID primary key(Id),
	constraint CK_AName check(len(aName)>2),
	constraint CK_APassword check(len(aPassword)>2)
)*/

--select cName, COUNT(*) from TblProduct inner join TblCategory on TblProduct.category=TblCategory.Idgroup by cName