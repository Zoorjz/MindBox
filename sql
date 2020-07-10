create table goods (id int, n text);

insert into goods values
   (1, 'товар0')
  ,(2, 'товар1')
  ,(3, 'товар2')
;

create table categories (id int, n text);
insert into categorys values
   (1, 'категория0')
  ,(2, 'категория1')
  ,(3, 'категория2')
;

create table GC (f int, t int);
insert into ft values
   (1, 1)
  ,(1, 2)
  ,(1, 3)
  ,(2, 1)
  ,(2, 3)
  ,(3, 2)
;

-----------------------------------------------------------------------------------------sql запрос

select goods.*, group_concat(categories.n)
 from goods
join GC
 on GC.f = goods.id
join categories
 on categories.id = GC.t
group by goods.id
