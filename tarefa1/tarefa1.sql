declare @Pessoa table
(
     ID int,
     Nome VARCHAR(MAX),
     Salario NUMERIC,
     DeptID INT
);
declare @Departamento table
(
     ID int,
     Nome VARCHAR(MAX)
);


insert into @Pessoa 
values 
(1, 'Joe', 7000.0, 1),
(2, 'Henry', 8000,2),
(3, 'Sam', 6000,2),
(4,'Max', 9000, 1)

insert into @Departamento 
values 
(1,'TI'),
(2, 'Vendas'),
(3,'Teste')



select e.Nome, E.Salario, d.Nome
from @Pessoa e inner join @Departamento d on (e.DeptID = d.ID)
where E.Salario in (select max(Salario) from @Pessoa group by DeptID)
