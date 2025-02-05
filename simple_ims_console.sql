create database simple_ims_console;
use simple_ims_console;

create table products(
	id int primary key not null,
	name varchar(100) not null,
	quantity_in_stock int not null default 0,
	price decimal not null
);