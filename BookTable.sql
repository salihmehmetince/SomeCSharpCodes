--create database DBBook;
/*create table TBLBook(
	ISBN int identity(1,1) not null,
	bookName nvarchar(40) not null,
	authourName nvarchar(40) not null,
	pageNumber tinyint not null,
	publicationDate date not null,
	publicationPlace nvarchar(100) not null,
	edition tinyint not null,
	publisher nvarchar(50) not null,
	price int not null,
	description nvarchar(500) not null,
	constraint PK_ISBN primary key (ISBN),
	constraint CK_bookName check (len(bookName)>=2),
	constraint CK_authourName check (len(authourName)>=2),
	constraint CK_pageNumber check (pageNumber>0),
	constraint CK_publicationPlace check (len(publicationPlace)>=5),
	constraint CK_edition check (edition>0),
	constraint CK_publisher check (len(publisher)>=2),
	constraint CK_price check (price>0)

);*/

/*insert into tblbook values ('book1', 'author1', 300, '2023-01-01', 'pub place1', 2, 'publisher1', 200, 'it is a book 1');
insert into tblbook values ('book2', 'author2', 200, '2013-01-08', 'pub place2', 2, 'publisher2', 600, 'it is a book 2');
insert into tblbook values ('book3', 'author3', 100, '2022-02-01', 'pub place3', 2, 'publisher3', 400, 'it is a book 3');
insert into tblbook values ('book4', 'author4', 400, '2021-05-04', 'pub place4', 2, 'publisher4', 400, 'it is a book 4');*/
--TRUNCATE TABLE tblbook;
