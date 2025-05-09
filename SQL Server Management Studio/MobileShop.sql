create database MobileShop

create table newMobile(

mid int NOT NULL IDENTITY (1,1) primary key,
cname varchar(250) not null,
mname varchar(250) not null,
ram varchar(250) not null,
rom varchar(250) not null,
expandable varchar(250) not null,
displaytype varchar(250) not null,
displaysize varchar(250) not null,
rear varchar(250) not null,
front varchar(250) not null,
os varchar(250) not null,
chipset varchar(250) not null,
sim varchar(250) not null,
network varchar(250) not null,
secure varchar(250) not null,
price bigint not null,
quantity bigint not null
);

create table newUser(

userid int NOT NULL IDENTITY (1,1) primary key,
uname varchar(250) not null,
upass varchar(250) not null,
);

select * from newUser

DROP TABLE newUser
DROP TABLE customerPurchase

select * from newMobile

create table customerPurchase(
cid int not null IDENTITY(1,1) primary key,
cname varchar(250) not null,
gender varchar(250) not null,
contact bigint not null,
email varchar(250) not null,
caddress varchar(250) not null,
company varchar(250) not null,
model varchar(250) not null,
imei varchar(250) not null
);





select * from customerPurchase

i

cname,gender,contact,email,caddress,company,model,imei
