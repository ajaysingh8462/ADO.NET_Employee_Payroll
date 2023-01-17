Create proc InsertEmployee_Details
(
@Name varchar(200),@Startdate date,@phone bigint,@Emp_Address varchar(200),@Department varchar(200),@Gender varchar(10), @Basic_Pay bigint,@Deductions bigint,@Taxable_Pay bigint,@Income_Tax bigint,@Net_Pay bigint
)
as
begin
insert into EmployepayrollTable(Name,Startdate,phone,Emp_Address,Department,Gender,Basic_Pay,Deductions,Taxable_Pay,Income_Tax,Net_Pay)
values(@Name,@Startdate,@phone,@Emp_Address,@Department,@Gender,@Basic_Pay,@Deductions,@Taxable_Pay,@Income_Tax,@Net_Pay)

End

select *from EmployepayrollTable


