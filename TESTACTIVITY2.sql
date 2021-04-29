--1) Print the city name and the count of authors from every city
use pubs 
select * from authors
select city,count(au_id) as NoOfAuthors from authors group by au_id,city

--2) Print the authors who are not from the city in which the publisher 'New Moon Books' is from.
select * from publishers
select * from authors
select distinct city,au_fname from authors where city not in
(select city from publishers where pub_name = 'New Moon Books')
--3) Create a procudure that will take the author first name and last name and new price .
--The procedure should update teh price of the books written by the author with the give name 
create proc UpdatePrice(@fname varchar(20),@lname varchar(20),@price int)
as
begin
	   update titles set price=@price where title_id in
	   ( select title_id from titles where title_id in 
      (select title_id from titleauthor where au_id in 
      (select au_id from authors where au_fname=@fname and au_lname=@lname )))
end
drop proc UpdatePrice
exec UpdatePrice 'Charlene','Locksley',300
select * from titles --PS7777
select * from authors --486-29-1786
select * from titleauthor

--4) Create a function that will calculate tax for the sale of every book
--If quantity <10 tax is 2%
--10 -20 tax is 5%
--20 - 50 tax is 6%
--above 30 tax is 7.5%
--The fuction should take quantity and return tax


select * from sales
select * from titles

create function printQtyTax(@qty int)
returns @QtyTAX table
(
   TaxForTheQuantity float )
as
begin
declare
@tax float
set @qty=(select qty from titles t join sales s
on t.title_id = s.title_id
where s.qty = @qty)
if(@qty<10)
    set @tax=2
else if(@qty>10 and @qty<20)
    set @tax=5
else if(@qty>20 and @qty<50)
    set @tax=6
else
    set @tax=7
insert into @QtyTAX values(@tax)
return
end
drop function printQtyTax
select * from dbo.printQtyTax(5)



