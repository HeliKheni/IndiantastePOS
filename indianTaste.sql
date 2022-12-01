create database DbIndianTaste;

create table Menu
(
	item_id int Primary key IDENTITY(1,1),
	item_name varchar(300),
	Category varchar(11),
	price decimal(5,2),
	added_at date DEFAULT GETDATE()
);

insert into Menu(item_name,Category,price) values('Samosa','Appetizer',4.99);
insert into Menu(item_name,Category,price) values('Khaman','Appetizer',8.99);
insert into Menu(item_name,Category,price) values('BhelPuti','Appetizer',9.99);
insert into Menu(item_name,Category,price) values('Veg Manchurian','Appetizer',11.99);
insert into Menu(item_name,Category,price) values('Chicken Manchurian','Appetizer',12.99);

insert into Menu(item_name,Category,price) values('Chana Masala','Vegetarian',14.99);
insert into Menu(item_name,Category,price) values('Dal Makhni','Vegetarian',14.99);
insert into Menu(item_name,Category,price) values('Paneer Makhni','Vegetarian',15.99);
insert into Menu(item_name,Category,price) values('Yellowe Dal Fry','Vegetarian',15.99);
insert into Menu(item_name,Category,price) values('Palak Paneer','Vegetarian',14.99);

select price from Menu where item_name='Samosa'
select * from Menu

insert into Menu(item_name,Category,price) values('Butter Chicken','Meat',14.99);
insert into Menu(item_name,Category,price) values('Lamb Karahi','Meat',14.99);
insert into Menu(item_name,Category,price) values('Beef Saag','Meat',15.99);

insert into Menu(item_name,Category,price) values('Naan','Bread',2.99);
insert into Menu(item_name,Category,price) values('Garlic Naan','Bread',3.99);
insert into Menu(item_name,Category,price) values('Roti','Bread',4.99);

insert into Menu(item_name,Category,price) values('Rice Pudding','Dessert',6.99);
insert into Menu(item_name,Category,price) values('Carrot Halwa','Dessert',4.99);
insert into Menu(item_name,Category,price) values('GulabJambun','Dessert',5.99);