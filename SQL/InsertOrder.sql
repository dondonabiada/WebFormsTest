USE [WebFormsApp]
GO

INSERT INTO [dbo].[Orders]
           ([OrderNumber]
           ,[OrderDate]
           ,[OrderAmount]
           ,[OrderDescription]
           ,[CustomerId])
     VALUES
           (1
           ,'2022-07-22 08:00'
           ,10.00
           ,'Sample Description'
           ,1)
GO


