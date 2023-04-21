USE master;
CREATE DATABASE test;
GO
USE test;
CREATE TABLE [output](
				id INT IDENTITY(1,1),
				myText NVARCHAR(20));
				
USE master;
DROP DATABASE test;

USE test;
insert into [output](myText) values (N'Привет');
insert into [output](myText) values (N'test002');