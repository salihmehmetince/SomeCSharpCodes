/*create table TblStudent(
	studentId int not null identity(1,1),
	studentName nvarchar(40) not null,
	studentSurname nvarchar(40) not null,
	studentNumber nchar(10) not null,
	studentDepartment nvarchar(40) not null,
	constraint PK_studentId primary key(studentId)

);


create table TblLecture(
	lectureId tinyint not null identity(1,1),
	lectureName nvarchar(40) not null,
	constraint PK_lectureId primary key(lectureId)
);

create table TblGrades(
	gradeId int not null identity(1,1),
	studentId int not null,
	lectureId tinyint not null,
	grade tinyint not null,
	constraint PK_gradeId primary key(gradeId),
	constraint FK_studentId foreign key (studentId) references TblStudent(studentId),
	constraint FK_lectureId foreign key (lectureId) references TblLecture(lectureId),
	constraint CK_grade check(grade>=0 and grade<=100)
);*/

/*insert into TblStudent values('name1','surname1','12323','computer engineering');
insert into TblStudent values('name2','surname2','15673','software engineering');
insert into TblStudent values('name3','surname3','17321','mechanical engineering');
insert into TblStudent values('name4','surname1','18532','software engineering');
insert into TblStudent values('name1','surname4','17342','mechanical engineering');

insert into TblLecture values('algorithm');
insert into TblLecture values('maths');
insert into TblLecture values('phisics');
insert into TblLecture values('ai');
insert into TblLecture values('programming');*/