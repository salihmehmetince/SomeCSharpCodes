
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
/*create table TblCustomer(
	Id int not null identity(1,1),
	customerName nvarchar(40) not null,
	customerSurname nvarchar(40) not null,
	city nvarchar(40) not null,
	balance decimal(7,2) not null,
	constraint Pk_CustomerId primary key(Id),
	constraint CK_customerName check(len(customerName)>2),
	constraint CK_customerSurname check(len(customerSurname)>2),
	constraint CK_city check(len(city)>2),
	constraint CK_balance check(balance>0)
);*/

/*create table TblSales(
	Id int not null identity(1,1),
	product int not null,
	customer int not null,
	piece smallint not null,
	price decimal(7,2) not null,
	total decimal(7,2) not null,
	saleDate date not null,
	constraint Pk_SaleId primary key(Id),
	constraint FK_product foreign key (product) references TblProduct(Id),
	constraint FK_customer foreign key (customer) references TblCustomer(Id),
	constraint CK_piece check(piece>0),
	constraint CK_price check(price>0),
	constraint CK_total check(total>0)
);*/

/*insert into TblCustomer values('ad1','soyad1','city1',15000);
insert into TblCustomer values('ad2','soyad2','city2',25000);
insert into TblCustomer values('ad3','soyad3','city3',31000);
insert into TblCustomer values('ad4','soyad4','city3',47000);
insert into TblCustomer values('ad5','soyad5','city1',10000);*/
/*insert into TblSales values(2,3,2,1100.12,1100.12*2,'02.02.2018');
insert into TblSales values(4,6,1,200,200,'05.04.2019');
insert into TblSales values(4,3,2,200,400,'11.09.2020');
insert into TblSales values(2,2,2,1100.12,1100.12*2,'12.12.2021');*/

/*create procedure getSales as
select TblSales.Id,pName,customerName+' '+customerSurname as 'Customer', piece,price,total,saleDate
from TblSales inner join TblProduct on TblSales.product=TblProduct.Id 
inner join TblCustomer on TblSales.customer=TblCustomer.Id;*/

--execute getSales

/*create procedure getProduct(@productId int) as
select * from TblProduct where Id=@productId*/

--execute getProduct 4;
--select * from ViewGetSales

/*create table TblStock(
	piece int not null
)*/

--insert into TblStock values(0);

--update TblStock set piece=(select COUNT(*) from TblProduct)

/*create trigger increaseStock
on TblProduct after insert as update TblStock set piece=piece+1;*/

--insert into TblProduct values('Test',5,10,15,1);

/*create trigger decreaseStock
on TblProduct after delete
as update TblStock set piece=piece-1;*/

--delete from TblProduct where Id=7;

/*create table TblStocks(
	piece int not null
);*/

--insert into TblStocks values(0);
--update tblStocks set piece=(select sum(stock) from TblProduct);

/*create trigger increaseStocks
on TblProduct
after insert
as
declare @stocks int
select @stocks=stock from inserted
update TblStocks set piece=piece+@stocks;*/

--insert into TblProduct values('Test3',25,210,215,1);
CREATE PROCEDURE getSalesName
AS
BEGIN
    SELECT 
        TblSales.Id, 
        TblProduct.pName AS 'Product', 
        TblCustomer.customerName,
		TblCustomer.customerSurname, 
        TblSales.piece, 
        TblSales.price, 
        TblSales.total, 
        TblSales.saleDate
    FROM TblSales 
    INNER JOIN TblProduct ON TblSales.product = TblProduct.Id 
    INNER JOIN TblCustomer ON TblSales.customer = TblCustomer.Id;
END;

