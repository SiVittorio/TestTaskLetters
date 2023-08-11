create table LetterKinds
(
	"Guid" uniqueidentifier not null,
	"Name" nvarchar(30) unique not null,
	CONSTRAINT PK_LetterKinds PRIMARY KEY("Guid")
);



create table BaseLetters
(
	"Id" int IDENTITY(1,1) not null,
	"LetterKind" nvarchar(30),
	"Name" nvarchar(30) not null,
	"Subject" nvarchar(1000),
	"CreateDate" datetime,
	"DocumentNumber" nvarchar(100) unique not null,
	"LetterKindGuid" uniqueidentifier not null
	constraint PK_BaseLetters primary key("Id")
	constraint FK_BaseLetters_LetterKinds foreign key ("LetterKindGuid")
		references LetterKinds ("Guid")
);

create table IncomingLetters
(
	"Id" int IDENTITY(1,1) not null,
	"LetterKind" nvarchar(30),
	"Name" nvarchar(30) not null,
	"Subject" nvarchar(1000),
	"CreateDate" datetime,
	"DocumentNumber" nvarchar(100) unique not null,
	"LetterKindGuid" uniqueidentifier not null,
	"AddresseeId" int not null,
	"DeliveryMethodId" int not null,
	"OrganisationId" int not null,
	"CounterpartyId" int not null,
	constraint PK_Incoming primary key("Id"),
	constraint FK_IncomingLetters_LetterKinds foreign key ("LetterKindGuid")
		references LetterKinds ("Guid"),

	constraint FK_IncomingLetters_Addressees foreign key ("AddresseeId")
		references Addressees ("Id"),
	constraint FK_IncomingLetters_DeliveryMethods foreign key ("DeliveryMethodId")
		references DeliveryMethods ("Id"),
	constraint FK_IncomingLetters_Organisations foreign key ("OrganisationId")
		references Organisations ("Id"),
	constraint FK_IncomingLetters_Counterparties foreign key ("CounterpartyId")
		references Organisations ("Id")
);

create table Addressees
(
	"Id" int IDENTITY(1,1) not null,
	"FirstName" nvarchar(30) not null,
	"LastName" nvarchar(30) not null,
	"MiddleName" nvarchar(30),
	constraint PK_Addressees primary key("Id")
);

create table DeliveryMethods
(
	"Id" int IDENTITY(1,1) not null,
	"Name" nvarchar(50) not null,
	constraint PK_DeliveryMethods primary key("Id")
);

create table Organisations
(
	"Id" int IDENTITY(1,1) not null,
	"Name" nvarchar(50) not null,
	constraint PK_Organisations primary key("Id")
);


insert into LetterKinds
values (newid(), N'Базовый документ'), (newid(), N'Входящий документ');

insert into BaseLetters ("Name", "Subject", "DocumentNumber", "LetterKindGuid")
values (N'да', 'sadslakdla', '2233a-sdd', 'D68D99DB-F8A5-414A-93FE-C27FFA74AAF8')

insert into IncomingLetters ("Name", "Subject", "DocumentNumber", "LetterKindGuid", "AddresseeId", "DeliveryMethodId", "OrganisationId", "CounterpartyId")
values (N'да', 'sadslakdla', '213a-sdd', 'D68D99DB-F8A5-414A-93FE-C27FFA74AAF8', 2, 3, 5, 6)

insert into Addressees ("FirstName", "LastName", "MiddleName")
values ('Alaina Doughty', 'Rubio', 'Trey Langlois'),
('Jona Garnett', 'Gibson-Boatright', 'Noelia Judd'),
('Candy Lee-Mackie', 'Maggard-Peebles', 'Na Frias'),
('Loise Morley', 'Swank', 'Lyn Hammett'),
('Millicent Vernon', 'Morin', 'Deedra Shivers'),
('Kory Kimball', 'Hewitt', 'Fernando Galvez'),
('Ronald Haggard', 'Peebles', 'Francisco Sumpter'),
('Susana Abner', 'Marvin', 'Cherie Clanton'),
('Noella Humes', 'Jordan', 'Nancy Vogt'),
('Gertude Meeker', 'Lockwood', 'Sherrell Whitfield')

insert into DeliveryMethods ("Name")
values ('signatures'), ('isaac'), ('clip'),
('pamela'), ('shakira'), ('districts'),
('illness'), ('rolls'), ('pixel'), ('skin')

insert into Organisations ("Name")
values ('Arrange Stores LLC'), ('Reduces International S.A'),
('Gang Software SIA'), ('Stopped Inc'),
('Responsibilities Software S.A'), ('Blank Industries A.G'),
('Illustration Holdings LLC'), ('Generations Mutual Ltd'),
('Allah Stores Corporation'), ('Editor Mutual SIA')

select * from IncomingLetters il
join DeliveryMethods dm on dm.Id = il.DeliveryMethodId
join Organisations org on org.Id = il.OrganisationId

delete from BaseLetters
where Id = 9

update BaseLetters set "Name" = 'no' where id = 3

drop table BaseLetters
drop table LetterKinds